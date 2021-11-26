using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {

        public PlatformsController()
        {
            
        }   
        [HttpPost] 
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound POST a Command Service");
            return Ok("Inbound Test of from Platforms Controller");
        }
    }


}