﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    class productoss
    {


        public int id { get; set; }
        public string productos { get; set; }
        public string precio { get; set; }

        public string cantidad { get; set; }
        public productoss() { }

        public productoss(int id, string productos, string precio, string cantidad)
        {
            this.id = id;
            this.productos = productos;
            this.precio = precio;
            this.cantidad = cantidad;
        }












    }
}
