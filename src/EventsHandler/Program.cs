using System;
using System.Threading;

namespace EventsHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Product book = new Product(10001, "PeterPanMustDie", 1.20, 45);
            book.ProductsCountDecreased += new EventHandler<ProductsCountDecreasedEventArgs>(BooksCountDecreased);
 
            for (int i = 0; i <6; i++)
            {
                book.Count -= 7;
                Thread.Sleep(600);
                Console.WriteLine(book.Name + " count " + book.Count.ToString());
            }
        }
 
        static void BooksCountDecreased(object sender, ProductsCountDecreasedEventArgs args)
        {
            Console.WriteLine($"Books count : {args.ProductCount} ! Alarm !");
        }
    }
}
