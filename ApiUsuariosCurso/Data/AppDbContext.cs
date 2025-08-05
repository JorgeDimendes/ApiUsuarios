using ApiUsuariosCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiUsuariosCurso.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<UsuarioModel> Usuarios { get; set; }
}