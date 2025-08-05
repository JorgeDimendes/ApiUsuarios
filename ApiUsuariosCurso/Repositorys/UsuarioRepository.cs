using ApiUsuariosCurso.Data;
using ApiUsuariosCurso.DTO.Usuario;
using ApiUsuariosCurso.Models;
using ApiUsuariosCurso.Repositorys.Interfaces;

namespace ApiUsuariosCurso.Repositorys;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly AppDbContext _context;
    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioCriacaoDTO usuarioCriacaoDto)
    {
        ResponseModel<UsuarioModel> response = new ResponseModel<UsuarioModel>();

        try
        {
            if (!VerificaSeExisteEmailUsuarioRepitidos(usuarioCriacaoDto))
            {
                response.Mensagem = "Email/Usuario já está cadastrado!";
                response.Status = false;
                return response;
            }

            return response;
        }
        catch (Exception ex)
        {
            response.Mensagem = ex.Message;
            response.Status = false;
            return response;
        }
    }

    private bool VerificaSeExisteEmailUsuarioRepitidos(UsuarioCriacaoDTO usuarioCriacaoDto)
    {
        var usuario = _context.Usuarios.FirstOrDefault(x => x.Email == usuarioCriacaoDto.Email ||
                                                                       x.Usuario == usuarioCriacaoDto.Usuario);
        if (usuario != null)
        {
            return false;
        }
        return true;
    }
}