using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._2._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Milk", 5.5, "Dairy"); //product בשם p1
            Product p2 = new Product("Bread", "Bakery");
            // Product p3 = new Product("Eggs", 3.5);
            string name = p1.GetProductName();
            string name2 = p2.GetProductName();
            double price1 = p1.GetProductprice();
            Console.WriteLine($" {name} {name2}");
            double sum = p1.GetProductprice() + p2.GetProductprice();
            p1.SetProductPrice(4.0); //הגדרת מחיר
            Console.WriteLine(price1);
            p1.UpdatePrice(20); 
            Console.WriteLine(price1);
        }
        class Product
        {
            private string productName; //בניית מחלקה
            private double price;
            private string category;
             public Product(string productName, double price, string category) //פעולה בונה
            {
                this.productName = productName;
                this.price = price;
                this.category = category;
            }
            public Product(string productName, string category) //פעולה בונה
            {
                this.productName = productName;
                this.category = category;
            }
            public string GetProductName()
            {
                return productName;
            }
            public double GetProductprice()
            {
                return price;
            }
            public void SetProductPrice(double price)
            {
                this.price = price;
            }
            //פעולה שמקבלת אחוז מסויים ומעדכנת את    המחיר
            public void UpdatePrice(double precent)
            {
                this.price = this.price + (this.price * precent / 100);
               
            }
            public bool IsExpensive()
            {
                return price > 100; 
            }
            public override string ToString() //דרוס את ה tostring הקודם
            {
                return $"Product name: {productName}," + $"Price: {price}, Category: {category}";
            }
        }
    }
}
