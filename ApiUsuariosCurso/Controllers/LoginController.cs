using ApiUsuariosCurso.Data;
using Microsoft.AspNetCore.Mvc;

namespace ApiUsuariosCurso.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginController : Controller
{
    private readonly AppDbContext _context;

    public LoginController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public ActionResult RegistrarUsuario()
    {
        return View("Index");
    }
}