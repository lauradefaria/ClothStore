using AdaTech.ClothStore.Data.Models;
using AdaTech.ClothStore.Data.Repository.Interface;
using AdaTech.ClothStore.RequestModels;
using AdaTech.ClothStore.RequestsModels;
using Microsoft.AspNetCore.Mvc;

namespace AdaTech.ClothStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReturnController : ControllerBase
    {
        private readonly IVendaRepository _saleRepository;
        private readonly IRetornoRepository _returnRepository;

        public ReturnController(IVendaRepository saleRepository, IRetornoRepository returnRepository)
        {
            _saleRepository = saleRepository;
            _returnRepository = returnRepository;
        }

        /// <summary>
        /// Registers a return for a sale.
        /// </summary>
        /// <param name="saleId">The ID of the sale for which the return is being registered.</param>
        /// <param name="returnRequest">The details of the return.</param>
        /// <returns>A response indicating whether the return was successfully registered.</returns>
        [HttpPost("{saleId}", Name = "AddReturn")]
        public IActionResult AddReturn([FromRoute] int saleId, [FromBody] CreateRetornoTrocaRequest returnRequest)
        {
            Venda sale = _saleRepository.GetById(saleId);

            Retorno returnSale = new Retorno(returnRequest.Date, sale);

            _returnRepository.Add(returnSale);
            _saleRepository.Delete(sale);

            return Ok(new { Message = "Return registered successfully." });
        }

        /// <summary>
        /// Retrieves all returns.
        /// </summary>
        /// <returns>A list of all returns.</returns>
        [HttpGet(Name = "GetAllReturns")]
        public IActionResult GetAllReturns()
        {
            return Ok(_returnRepository.GetAll());
        }
    }
}