using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class ServiceOrders
    {
        public void Add(Orders item)
        {
            RepositoryOrders.Instancia.Orders.Add(item);

        }

        public List<Orders> GetOrders()
        {

            return RepositoryOrders.Instancia.Orders;
        }
    }
}
