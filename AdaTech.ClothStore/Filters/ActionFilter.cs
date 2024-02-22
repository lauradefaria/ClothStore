using Microsoft.AspNetCore.Mvc.Filters;

namespace AdaTech.ClothStore.Filters
{
    public class ActionFilter : IActionFilter
    {
        private readonly ILogger<ActionFilter> _logger;

        public ActionFilter(ILogger<ActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation($"Action started: {context.ActionDescriptor.DisplayName} - {DateTime.Now}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation($"Action completed: {context.ActionDescriptor.DisplayName} - {DateTime.Now}");
        }
    }
}