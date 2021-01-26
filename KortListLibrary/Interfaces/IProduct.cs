using System;
using System.Collections.Generic;
using System.Text;

namespace KortListLibrary.Interfaces
{
    interface IProduct
    {
        string Merk { get; set; }
        string Naam { get; set; }
        string Volume { get; set; }
        string GetCode();
    }
}
