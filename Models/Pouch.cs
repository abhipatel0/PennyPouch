using System;
using System.ComponentModel.DataAnnotations;

namespace PennyPouch.Models
{
    //attributes and characteristics of the product
    public class Pouch
    {
        [Key] //To make the ItemNumber primary key
        public int ItemNumber { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Style { get; set; }
        public string Pattern { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}
