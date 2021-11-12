using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dynamic.Models
{
    public class Carro
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "MARCA")]
        public string Marca { get; set; }

        [Required]
        [Display(Name = "MODELO")]
        public string Modelo { get; set; }
    }
}
