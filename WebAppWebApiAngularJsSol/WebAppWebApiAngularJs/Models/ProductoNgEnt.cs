﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppWebApiAngularJs.Models
{
    public class ProductoNgEnt
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public float precio { get; set; }
        public string imagen { get; set; }
    }
}