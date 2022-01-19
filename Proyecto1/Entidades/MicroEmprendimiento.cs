using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class MicroEmprendimiento
    {
        public int EmproId { get; set; }
        public string nombreE { get; set; }
        public string tipo { get; set; }

        public string desccripcions { get; set; }
        public string Ciudad { get; set; }
        public int CreditoNecesario { get; set; }
        public int Ganancias { get; set; }
        public int MicroId { get; set; }
        public Microempresario MicroempresarioEmpr { get; set; }
    }
}
