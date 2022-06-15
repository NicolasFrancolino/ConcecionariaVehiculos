namespace WebApi.Helpers;

using ConcecionariaVehiculos.Entities;
using Microsoft.EntityFrameworkCore;


public class DataContext : DbContext
{
    public DbSet<Usuarios> Users { get; set; }

    private readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder options)
    //{
       
    //    options.UseInMemoryDatabase("TestDb");
    //}
}