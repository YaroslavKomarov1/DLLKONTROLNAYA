// Store.cs  Выполнено студентом Комаровым Ярославом Вячеславовичем 34ИС
using System;
using System.Collections.Generic;
namespace KomarovYaroslav.Library
{
    public class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }

        public Store()
        {
            Products = new List<Product>();
        }

        public void ShowAll()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}");
            foreach (Product product in Products)
            {
                product.Show();
            }
        }
    }
}