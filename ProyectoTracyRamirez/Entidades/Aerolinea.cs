﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades

{
    public class aerolinea

    {
        public int id{ get; set; }
        public string nombre { get; set; }

        public aerolinea(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
