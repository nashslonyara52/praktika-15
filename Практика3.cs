using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        interface IGetterPrice
        {
            double GetPrice();
        }
        interface IGetterWarranty
        {
            int GetWarranty();
        }
        class Phone : IGetterPrice, IGetterWarranty
        {
            private double price;
            private int warranty;
            public Phone(double price, int warranty)
            {
                this.price = price;
                this.warranty = warranty;
            }
            public double GetPrice() => price;
            public int GetWarranty() => warranty;
        }
        class Laptop : IGetterPrice
        {
            private double price;
            public Laptop(double price)
            {
                this.price = price;
            }
            public double GetPrice() => price;
            static void Main(string[] args)
            {
                Phone phone = new Phone(12000, 4);
                Laptop laptop = new Laptop(40000);
                Console.WriteLine($"Общая стоимость: {phone.GetPrice() + laptop.GetPrice()}");
                Console.WriteLine($"Гарантия на телефон: {phone.GetWarranty()}");
                Console.WriteLine();
            }
        }
    }
}
