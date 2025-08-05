using ApiUsuariosCurso.DTO.Usuario;
using ApiUsuariosCurso.Models;

namespace ApiUsuariosCurso.Repositorys.Interfaces;

public interface IUsuarioRepository
{
    public Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioCriacaoDTO usuarioCriacaoDto);
}