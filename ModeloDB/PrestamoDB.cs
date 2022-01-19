using Microsoft.EntityFrameworkCore;
using ModeloProyecto.Entidades;
namespace ModeloDB
{
    public class PrestamoDB : DbContext
    {
        //Declaración de las entidades del modelo
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Microempresario> Microempresarios { get; set; }
        public DbSet<MicroEmprendimiento> Microemprendimientos { get; set; }
        public DbSet<Garante> Garantes { get; set; }

        //Configuración de la conección

    }
}
