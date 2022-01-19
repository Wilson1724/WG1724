using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloProyecto.Entidades
{
    public class MicroEmprendimiento
    {
        public int EmproId { get; set; }
        public string NombreE { get; set; }
        public string Tipo { get; set; }

        public string Descripcion { get; set; }
        public string Ciudad { get; set; }
        public int CreditoNecesario { get; set; }
        public int Ganancias { get; set; }
        public int MicroId { get; set; }
        public Microempresario MicroempresarioEmpr { get; set; }
    }
}
