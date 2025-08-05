using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiUsuariosCurso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Minha Rola Gigante");
        }
    }
}