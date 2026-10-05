using JeisonAmparo_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace JeisonAmparo_AP1_P1.Context;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Autores> Autores { get; set; }
}
