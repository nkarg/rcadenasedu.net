using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class pokemonModel
    {
            [Required]
            [Display(Name = "ID del Pokemon")]
            public int PokemonId { get; set; }
            [Required]
            [Display(Name = "Name of The Pokemon")]
            public string Name { get; set; }
            [Required]
            [Display(Name = "Dia de Captura")]
            public DateTime CaptureDate { get; set; }
            [Required]
            [Display(Name = "Tipo del Pokemon")]
            public typeModel? Type { get; set; }

            public virtual trainerModel Trainer { get; set; }
    }
}