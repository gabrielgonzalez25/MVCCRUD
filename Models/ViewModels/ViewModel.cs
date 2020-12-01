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
        [StringLength(100, ErrorMessage ="Debe contener minimo 5 caracteres", MinimumLength = 5)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password",ErrorMessage ="Las contraseñas no son iguales")]
        public string ConfirmPassword { get; set; }
        [Required]
        public int Edad { get; set; }
    }

    public class EditViewModel
    {
        public long Id { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo electronico")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100, ErrorMessage = "Debe contener minimo 5 caracteres", MinimumLength = 5)]
        public string Email { get; set; }
        
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas no son iguales")]
        public string ConfirmPassword { get; set; }
        [Required]
        public int Edad { get; set; }
    }
}