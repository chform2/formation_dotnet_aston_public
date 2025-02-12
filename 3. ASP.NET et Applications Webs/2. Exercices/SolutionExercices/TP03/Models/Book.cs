﻿using System.ComponentModel.DataAnnotations;
using TP03.Models.Enums;

namespace TP03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public static int Compteur { get; set; }

        [Display(Name = "Titre")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Couverture")]
        public string PictureURL { get; set; }

        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [Display(Name = "Prix")]
        public double Price { get; set; }

        [Display(Name = "Catégorie")]
        public BookCategory BookCategory { get; set; }

        [Display(Name = "Date de parution")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Auteur")]
        public Author Author { get; set; }

        public Book()
        {
            Id = ++Compteur;
        }

    }
}
