using KortListLibrary.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace KortListLibrary.Models
{
    public class Products : IEnumerable
    {
        private List<Product> producten = new List<Product>();
        public Products()
        {
            producten.Add(new Product("Cola", "Zero", "150 ml"));
            producten.Add(new Product("Fanta", "Lemon", "1000 ml"));
            producten.Add(new Product("Soda", "Gas", "300 ml"));
        }
        public IEnumerator GetEnumerator()
        {
            return producten.GetEnumerator();
        }
    }
}
