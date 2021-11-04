using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Orders
    {
        public string ClientName { get; set; }
        public string EntryDish { get; set; }
        public string MainDish { get; set; }
        public string DessertDish { get; set; }
        public string Beverage { get; set; }

        public string GetOrders() {
            return $"Name: {ClientName} | Entry Dish: {EntryDish} | Main Dish: {MainDish} | Dessert Dish: {DessertDish} | Beverage: {Beverage}";
        }

    }
}
