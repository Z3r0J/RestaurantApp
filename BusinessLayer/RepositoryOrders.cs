using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public sealed class RepositoryOrders
    {
        public static RepositoryOrders Instancia { get; } = new RepositoryOrders();

        public int PeopleQuantity = 0;

        public List<Orders> Orders = new List<Orders>(); 
        private RepositoryOrders()
        {

        }
    }
}
