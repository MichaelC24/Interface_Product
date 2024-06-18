using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Product
{
    internal interface IProduct
    {
        string ProductName { get; set; } 
        decimal ProductPrice { get; set; }

        
    }
}
