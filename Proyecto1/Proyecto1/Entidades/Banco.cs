﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class Banco
    {
        public int BancoId { get; set; }
        public string Sucursal { get; set; }
        public string Encargado { get; set; }
        public int PrestamoId { get; set; }
        public Prestamo PrestamoBanc { get; set; }
    }
}
