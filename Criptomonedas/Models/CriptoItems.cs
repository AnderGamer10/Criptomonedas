using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Criptomonedas.Models
{
    public class CriptoItems
    {
        [Key]
        public string Nombre { get; set; }
        public double ValorMaximo { get; set; }
        public double ValorActual { get; set; } 
    }
}
