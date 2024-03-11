using System.Collections.Generic;

namespace ExerciseOopHierarchy
{
    public class Customer
    {
        private List<Order> _orderHistory = new List<Order>();

        public Customer(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public string Name { get; }
        public string Email { get; }

        public IReadOnlyList<Order> OrderHistory => this._orderHistory.AsReadOnly();

        public void AddOrder(Order order)
        {
            this._orderHistory.Add(order);
        }
    }
}
