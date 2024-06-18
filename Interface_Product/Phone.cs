using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Product
{
    internal class Phone : IProduct
    {
        public string ProductName { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }// = 1;


    }
}
