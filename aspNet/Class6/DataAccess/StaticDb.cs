using System;
using System.Collections.Generic;
using Domain.Models;

namespace DataAccess
{
    public static class StaticDb
    {
        public static List<Order> Orders;

        static StaticDb()
        {
            Orders = new List<Order>()
            {
                new Order()
                {
                    OrderId = 1,
                    User= "Maxx",
                    Pizza = "Margherita",



                };
            }
        }

    }
}
