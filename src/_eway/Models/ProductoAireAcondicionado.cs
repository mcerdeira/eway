using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _eway.Models
{
    public class ProductoAireAcondicionado : Producto
    {
        public double AltoExterior { get; set; }
        public double AnchoExterior { get; set; }
        public bool Autolimpiante { get; set; }
        public bool DeflectorAire { get; set; }
        public bool DisplayLSD { get; set; }
        public string EficienciaEnergeticaCalor { get; set; }
        public string EficienciaEnergeticaFrio { get; set; }
        public int FrigoriasCalor { get; set; }
        public int FrigoriasFrio { get; set; }
        public bool FuncionAutomatico { get; set; }
        public bool FuncionDeshumificador { get; set; }
        public bool FuncionTurbo { get; set; }
        public bool FuncionVentilacion { get; set; }
        public int PotenciaCalefaccion { get; set; }
        public int PotenciaRefrigeracion { get; set; }
        public double ProfundidadExterior { get; set; }
        public bool Sleep { get; set; }
        public int TamanoAmbienteRecom { get; set; }
        public bool Timer { get; set; }
        public string TipoClimatizacion { get; set; }
        public bool Wifi { get; set; }
    }
}