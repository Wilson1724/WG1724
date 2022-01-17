using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class Microempresario
    {
        public int MicroId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public int cedula { get; set; }
        public int edad { get; set; }
        public string Direccion { get; set; }
        public int IngresosAnuales { get; set; }
        public int BancoId { get; set; }
        public Banco BancoM { get; set; }
        public int EmproId { get; set; }
        public Microemprendimiento MicroemprendimientoM { get; set; }
        public int  PrestamOId { get; set; }
        public Prestamo PrestamoM { get; set; }
    }
}
