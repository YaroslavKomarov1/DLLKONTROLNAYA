// Product.cs Выполнено студентом Комаровым Ярославом Вячеславовичем 34ИС
using System;

namespace KomarovYaroslav.Library
{
    public class Product : IComparable
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}, Number: {Number}");
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Product otherProduct = obj as Product;
            if (otherProduct != null)
                return this.Number.CompareTo(otherProduct.Number);
            else
                throw new ArgumentException("Etot object - ne produkt");
        }
    }
}