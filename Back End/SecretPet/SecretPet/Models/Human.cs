﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecretPet.Models
{
    public class Human
    {
        public int HumanID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public List<Pet> MyPets { get; set; }
    }
}