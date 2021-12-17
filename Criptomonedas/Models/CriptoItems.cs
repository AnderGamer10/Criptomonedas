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
        public decimal ValorMaximo { get; set; }
        public decimal ValorActual { get; set; } 
    }
}
