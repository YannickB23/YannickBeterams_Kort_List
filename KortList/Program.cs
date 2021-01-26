using KortListLibrary.Models;
using System;

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
