﻿using System.ComponentModel.DataAnnotations;

namespace CaisseEnregistreuse.Models
{
    public class Product
    {
        public static int Count;
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public Product()
        {
            Id = ++Count;
        }
    }
}
