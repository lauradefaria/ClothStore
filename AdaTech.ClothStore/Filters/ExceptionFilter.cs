using AdaTech.ClothStore.Data.Exceptions;
using AdaTech.ClothStore.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AdaTech.ClothStore.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<ExceptionFilter> _logger;

        public ExceptionFilter(ILogger<ExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            if (context.Exception is ClothStoreException clothStoreSalesApiException)
            {
                var errorResult = new ErroResponse
                {
                    ErrorMessage = clothStoreSalesApiException.Message,
                    StatusCode = clothStoreSalesApiException.StatusCode
                };

                context.Result = new JsonResult(errorResult)
                {
                    StatusCode = errorResult.StatusCode
                };

                _logger.LogWarning(context.Exception, "Exceção capturada pelo exception filter");
            }
            else
            {
                var errorResult = new ErroResponse
                {
                    ErrorMessage = "Internal Server Error",
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                context.Result = new JsonResult(errorResult)
                {
                    StatusCode = errorResult.StatusCode
                };

                _logger.LogError(context.Exception, "Exceção capturada pelo exception filter");
            }
        }
    }
}