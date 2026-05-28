using Microsoft.EntityFrameworkCore;
using T2_Murga_Nicolas.Models;

namespace T2_Murga_Nicolas.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Distribuidor> Distribuidor { get; set; }
    }
}