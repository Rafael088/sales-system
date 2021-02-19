using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller s1 = new Seller();
            s1.Name = "Jhan";
            s1.Age = 21;

            Seller s2 = new Seller();
            s1.Name = "Emma";
            s1.Age = 10;

            Seller s3 = new Seller();
            s1.Name = "Caro";
            s1.Age = 22;

            Product pro1 = new Product();
            pro1.Name = "TV";
            pro1.Price = 200;

            Product pro2 = new Product();
            pro2.Name = "Agua";
            pro2.Price = 100;

            Product pro3 = new Product();
            pro3.Name = "MP4";
            pro3.Price = 200;

            Sale Sa1 = new Sale();
            Sa1.Seller = s1;
            Sa1.Product = pro3;
            Sa1.Comments = "I like listening to music";

            Sale Sa2 = new Sale();
            Sa2.Seller = s2;
            Sa2.Product = pro1;
            Sa2.Comments = "I like watching movies";

            Sale Sa3 = new Sale();
            Sa3.Seller = s3;
            Sa3.Product = pro2;
            Sa3.Comments = "I was thirsty";


            //Calculate the price of the total sale
            int value1 = Sa1.Product.Price;
            int value2 = Sa2.Product.Price;
            int value3 = Sa3.Product.Price;

            int valueT = 0;
            valueT = value2 + value1 + value3;

            System.Console.WriteLine("Total cost of all sales : " + valueT);

        }
    }
}
