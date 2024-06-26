using Api.Reportes;
using Microsoft.EntityFrameworkCore;

namespace Api;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Evento> Eventos => Set<Evento>();

    public DbSet<AvisoSapPm> AvisosSapPm => Set<AvisoSapPm>();


    public DbSet<AvisoY2> AvisosY2 => Set<AvisoY2>();


    public DbSet<Firma> Firmas => Set<Firma>();



}
