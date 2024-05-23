using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Ej8Controller : ControllerBase
    {
        [HttpGet()]
        public int Get()
        {
            int num = 0;
            while (num < 100)
            {
                return num + 1;
            }
        }
    }
}





