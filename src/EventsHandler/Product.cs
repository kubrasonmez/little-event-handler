using System;

namespace EventsHandler
{
    [SerializableAttribute]
    public delegate void EventHandler<TEventArgs>(Object sender, TEventArgs e) where TEventArgs : EventArgs;
    public class Product
    {
        private int count;
        public Product(int id, string name, double price, int count)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.count = count;
        }        
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count {
            get{return this.count;}
            set{
                this.count = value;
                if(this.count < 5 && ProductsCountDecreased != null)
                {
                    ProductsCountDecreased(this, new ProductsCountDecreasedEventArgs(value));
                }
            }
        }
 
        public event EventHandler<ProductsCountDecreasedEventArgs> ProductsCountDecreased;   
    }
}