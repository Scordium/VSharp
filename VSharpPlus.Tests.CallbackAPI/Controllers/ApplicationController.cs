using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VSharpPlus.Clients;
using VSharpPlus.Entities;

namespace VSharpPlus.Tests.CallbackAPI.Controllers
{
    [ApiController]
    public class ApplicationController : Controller
    {
        public static VkClient Client;
        
        // [Route("callback")]
        // public async Task<ActionResult> Callback([FromBody]VkGatewayPayload body)
        // {
        //     return Ok(await Client.HandleDispatchAsync(body));
        // }
        
        
    }
    
    
    
}