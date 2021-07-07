using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PingController : BaseApiController
    {
        [HttpGet]
        public ActionResult<string> Ping() 
        {
            return new ActionResult<string>("Ping OK");
        }
    }
}