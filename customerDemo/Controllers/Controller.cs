using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace customerDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> MyName()
        {
            return new string[] { "İclal" };
        }
        
    }
}
