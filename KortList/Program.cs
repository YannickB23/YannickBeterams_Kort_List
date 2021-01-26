using KortListLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortList
{
    class Program
    {
        static void Main(string[] args)
        {
            Products alleProducten = new Products();
            foreach (Product item in alleProducten)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
