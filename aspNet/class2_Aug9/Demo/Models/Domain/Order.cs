using System;
namespace Demo.Models.Domain
{
    public class Order
    {
        public int ID { get; set; }
        public User User { get; set;}
        public string Pizza { get; set; }
        public double Price { get; set; }
    }
}
