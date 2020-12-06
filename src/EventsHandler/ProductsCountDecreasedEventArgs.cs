using System;

namespace EventsHandler
{
    public class ProductsCountDecreasedEventArgs:EventArgs
    {
        public int ProductCount { get; set; }
        public ProductsCountDecreasedEventArgs(int productCount)
        {
            ProductCount = productCount;
        }
    }
}