using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _eway.Models
{
    public class Producto
    {
        [Key]
        [Column(Order = 1)]
        [Required]
        [StringLength(13, ErrorMessage = "El largo maximo es 13")]
        [RegularExpression("^[0-9]*$", ErrorMessage="Debe contener numeros")]
        public string GLN { get; set; }
        [Key]
        [Column(Order = 2)]
        [Required]
        [StringLength(13, ErrorMessage="El largo maximo es 13")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Debe contener numeros")]
        public string GTIN { get; set; }

        [Required]
        public double Alto { get; set; }
        [Required]
        public double Ancho { get; set; }
        public string Categoria { get; set; }
        [Required]
        public string ContenidoNeto { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public int ID { get; set; }
        [Required]
        public string Marca { get; set; }
        public double PesoBruto { get; set; }
        [Required]
        public double Profundo { get; set; }
        [Required]
        public string Variedad { get; set; }
    }
}