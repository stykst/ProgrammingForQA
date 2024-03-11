using System.Collections.Generic;

namespace ExerciseOopHierarchy
{
    public class Order
    {
        private List<MenuItem> _items = new List<MenuItem>();

        public Order()
        {
        }

        public IReadOnlyCollection<MenuItem> Items => this._items.AsReadOnly();

        public void AddItem(MenuItem item)
        {
            this._items.Add(item);
        }

        public decimal GetTotal()
        {
            decimal total = 0;

            foreach (var item in this._items)
            {
                total += item.Price;
            }

            return total;
        }
        public override string ToString()
        {
            return $"{string.Join("\n ", this._items)}";
        }
    }
}
