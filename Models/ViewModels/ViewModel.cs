using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCCrud1.Models.ViewModels
{
    
    public class ViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Correo electronico")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100, ErrorMessage ="", MinimumLength = 5)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        public string ConfirmPassword { get; set; }
        [Required]
        public int Edad { get; set; }
    }
}