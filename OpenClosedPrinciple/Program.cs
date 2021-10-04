
using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductType1 productType1 = new ProductType1();
            productType1.Name = "test1";
            productType1.Price = 100;

            Console.WriteLine("Hello World!" + productType1.GetDiscount());

            ProductType1 productType2 = new ProductType1();
            productType2.Name = "test2";
            productType2.Price = 200;

            Console.WriteLine("Hello World!" + productType2.GetDiscount());

            Console.ReadKey();

        }
    }


    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual double GetDiscount()
        {
            return 0;
        }
    }


    public class ProductType1 : Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 10;
        }
    }

    public class ProductType2 : Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 15;
        }
    }
}
