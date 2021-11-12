using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dynamic.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "NOME")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "CPF")]
        [MaxLength(11)]
        [MinLength(11)]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "Por Favor, digite um CPF válido.")]
        public string Cpf { get; set; }
        
        [Required]
        [Display(Name = "DATA DE NASCIMENTO")]
        [DataType(DataType.Date)]

        public DateTime DataNascimento { get; set; }
        
        [Required]
        [Display(Name = "SEXO")]
        public Sexo Sexo { get; set; }
        
        [Required]
        [Display(Name = "E-MAIL")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
       
    }

    public enum Sexo
    {
        [Display(Name = "Masculino")]
        M,
        [Display(Name = "Feminino")]
        F
    }
}
