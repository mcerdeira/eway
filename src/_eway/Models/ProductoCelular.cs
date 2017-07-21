using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _eway.Models
{
    public class ProductoCelular : Producto
    {
        public int CamaraResolucion { get; set; }
        public int CapacidadBateria { get; set; }
        public int MemoriaExpandida { get; set; }
        public string Procesador { get; set; }
        public string Resolicion { get; set; }
        public string ResolucionVideo { get; set; }
        public string SistemaOperativo { get; set; }
        public double TamanoPantalla { get; set; }
        public string VelocidadInternet { get; set; }
        public string VersionSistemaOperativo { get; set; }
    }
}