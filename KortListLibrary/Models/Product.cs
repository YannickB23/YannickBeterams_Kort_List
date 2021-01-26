using KortListLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KortListLibrary.Models
{
    public class Product :IProduct
    {
        public string Merk { get; set; }
        public string Naam { get; set; }
        public string Volume { get; set; }
        public Product(string merk, string naam, string volume)
        {
            Merk = merk;
            Naam = naam;
            Volume = volume;
        }
        public string GetCode()
        {
            return $"{Merk.Substring(0, 3).ToUpper()}{Naam.Substring(0, 3).ToUpper()}{Volume.Replace(" ", "_")}";
        }
        public override string ToString()
        {
            return GetCode();
        }
    }
}
