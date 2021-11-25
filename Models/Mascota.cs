 using System;
 using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace firstApp.Models
{
    public class Mascota
    {
        [Key]

       public int MascotaID {get; set;}



       [Required(ErrorMessage ="Nombre is required!")]

       [Display(Name= "Nombre de la Mascota")]

       public string Nombre {get; set;}
       

       [Required(ErrorMessage ="Edad is required!")]

       [Display(Name= "Edad(Meses)")]
       public string Edad {get; set;}
    }
}

