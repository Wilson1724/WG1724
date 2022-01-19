using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class Garante
    {
        public int Garanteid { get; set; }
        public string nombreG { get; set; }
        public string apellidoG { get; set; }

        public int cedulaG { get; set; }
        public int edadG { get; set; }
        public string DireccionG { get; set; }
        public int IngresosAnualesG { get; set; }
        public int MicroEmpresarioId { get; set; }
        public Microempresario MicroempresarioG { get; set; }
    }
}
