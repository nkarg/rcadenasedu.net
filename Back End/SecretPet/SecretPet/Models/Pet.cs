using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecretPet.Models
{
    public class Pet
    {
        public int PetID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Breed { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public State State { get; set; }
        public string Avatar { get; set; }
        public TypeOfAnimal Animal { get; set; }
        public DateTime DateOfCreation { get; set; }
    }

    public enum State
    {
        FreeForAdoption,
        FreeForSale,
        Adopted,
        Sold
    }
    public enum TypeOfAnimal
    {
        Dog,
        Cat,
        Hamster,
        Rabbit
    }
}