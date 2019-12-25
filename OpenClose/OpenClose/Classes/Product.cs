using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose.Classes
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockAmount { get; set; }
        public Brand Brand { get; set; }
    }

    public enum Brand
    {
        Volkswagen = 0,
        Heineken,
        Samsung,
        Unilever
    }
}
