using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TSzKapu.Interfaces;

namespace TSzKapu.Authentication
{
    public class EspDeviceAut : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any())
            {
                return;
            }
            var auth = context.HttpContext.RequestServices.GetRequiredService<IDeviceAuth>();
            var deviceId = context.HttpContext.Request.Headers["X-Device-Id"];
            var apiKey = context.HttpContext.Request.Headers["X-Api-Key"];

            var device = await auth.GetDevice(deviceId);
            if (device == null || apiKey != apiKey)
            {
                context.Result = new UnauthorizedResult(); 
                return; 
            }
            context.HttpContext.Items["Device"] = device;
            await next();
        }
    }
}
