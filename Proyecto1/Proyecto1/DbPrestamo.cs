using Microsoft.EntityFrameworkCore;
using Proyecto1.Entidades;
namespace Proyecto1
{
    public class DbPrestamo:DbContext
    {
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Microempresario> Microempresarios { get; set; }
        public DbSet<MicroEmprendimiento> Microemprendimientos { get; set; }
        public DbSet<Garante> Garantes { get; set; }
    }
}
