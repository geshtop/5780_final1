using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class Orders
    {
        public static List<Order> getOrders()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order() { });
            orders.Add(new Order() { });
            orders.Add(new Order() { });
            orders.Add(new Order() { });
            return orders;
        }
    }
}
