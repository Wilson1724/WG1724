using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class Prestamo
    {
        public int PrestamoId { get; set; }
        public int Cantidad { get; set; }
        public int Plazo { get; set; }
        public int Interes { get; set; }
        public int CuotaMensual { get; set; }
        public int TotalDeuda { get; set; }
        public int BancoId { get; set; }
        public Banco BancoPres { get; set; }
        public int MicroId { get; set; }
        public Microempresario MicroempresarioPres { get; set; }
    }
}
