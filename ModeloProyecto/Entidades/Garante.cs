using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloProyecto.Entidades
{
    public class Garante
    {
        public int Garanteid { get; set; }
        public string NombreG { get; set; }
        public string ApellidoG { get; set; }

        public int CedulaG { get; set; }
        public int EdadG { get; set; }
        public string DireccionG { get; set; }
        public int IngresosAnualesG { get; set; }
        public int MicroEmpresarioId { get; set; }
        public Microempresario MicroempresarioG { get; set; }
    }
}
