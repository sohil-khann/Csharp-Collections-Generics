using System;
namespace SmartWareHouse
{
    public class Storage<T> where T : WarehouseItem
    {
        private List<T> items;

        public Storage()
        {
            items = new List<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void DisplayAllItems()
        {
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
    }
}