namespace ApiUsuariosCurso.Models;
public class UsuarioModel
{
    public int Id { get; set; }
    public string Usuario { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public string Sobrenome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public byte[] SenhaHash { get; set; } = new byte[0];
    public byte[] SenhaSalt { get; set; }  = new byte[0];
    public DateTime DataCriacao { get; set; }
    public DateTime DataAlteracao { get; set; }
}