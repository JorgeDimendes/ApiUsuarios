using ApiUsuariosCurso.Data;
using ApiUsuariosCurso.DTO.Usuario;
using ApiUsuariosCurso.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace ApiUsuariosCurso.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginController : Controller
{
    private readonly UsuarioRepository _context;

    public LoginController(UsuarioRepository context)
    {
        _context = context;
    }

    [HttpPost]
    public ActionResult RegistrarUsuario(UsuarioCriacaoDTO usuario)
    {
        return Ok(usuario);
    }
}