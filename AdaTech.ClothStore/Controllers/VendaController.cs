using AdaTech.ClothStore.Data.Models;
using AdaTech.ClothStore.Data.Repository.Interface;
using AdaTech.ClothStore.RequestModels;
using AdaTech.ClothStore.RequestsModels;
using Microsoft.AspNetCore.Mvc;

namespace AdaTech.ClothStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController : ControllerBase
    {
        private readonly IVendaRepository _saleRepository;
        private readonly IItemRepository _itemRepository;

        public SaleController(IVendaRepository saleRepository, IItemRepository itemRepository)
        {
            _saleRepository = saleRepository;
            _itemRepository = itemRepository;
        }

        /// <summary>
        /// Registers a new sale.
        /// </summary>
        /// <param name="saleRequest">The details of the sale.</param>
        /// <returns>A response indicating whether the sale was successfully registered.</returns>
        [HttpPost(Name = "AddSale")]
        public IActionResult AddSale([FromBody] CreateVendaRequest saleRequest)
        {
            foreach (var saleItem in saleRequest.ItemVendido)
            {
                var item = _itemRepository.GetById(saleItem.IdProduto);

                if (!item.Tamanho.Contains(saleItem.Tamanho.ToUpper()))
                {
                    return BadRequest($"Size {saleItem.Tamanho} is not available for item with ID {saleItem.IdProduto}.");
                }
            }

            Venda sale = new Venda(saleRequest.DataVenda, saleRequest.NomeCliente, saleRequest.ItemVendido);

            _saleRepository.Add(sale);
            return CreatedAtAction("GetSaleById", new { saleId = sale.Id }, new { message = "Resource created successfully.", data = sale });
        }

        /// <summary>
        /// Retrieves all sales.
        /// </summary>
        /// <returns>A list of all sales.</returns>
        [HttpGet(Name = "GetAllSales")]
        public IActionResult GetAllSales()
        {
            return Ok(_saleRepository.GetAll());
        }

        /// <summary>
        /// Retrieves a specific sale by its ID.
        /// </summary>
        /// <param name="saleId">The ID of the sale to retrieve.</param>
        /// <returns>The sale with the specified ID.</returns>
        [HttpGet("{saleId}", Name = "GetSaleById")]
        public IActionResult GetSaleById([FromRoute] int saleId)
        {
            Venda sale = _saleRepository.GetById(saleId);

            return Ok(sale);
        }
    }
}