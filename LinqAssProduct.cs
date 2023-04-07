using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQDemo
{
        //    Using LINQ query

    public class Product1
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Comp_Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} -> {Name} -> {Comp_Name} -> {Price}";
        }

    }
    public class Program1
    {
        static void Main(string[] args)
        {
            List<Product1> product1list = new List<Product1>()
            {
                new Product1{Id=1, Name="Mouse", Comp_Name="DELL", Price=999},
                new Product1{Id=2, Name="laptop", Comp_Name="HP", Price=30000},
                new Product1{Id=3, Name="Mouse", Comp_Name="LENOVO", Price=1000},
                new Product1{Id=4, Name="laptop", Comp_Name="DELL", Price=40000},
                new Product1{Id=5, Name="Mouse", Comp_Name="HP", Price=800},
                new Product1{Id=6, Name="laptop", Comp_Name="LENOVO", Price=45000},
                new Product1{Id=7, Name="Keyboard", Comp_Name="DELL", Price=500},
                new Product1{Id=8, Name="laptop", Comp_Name="ACER", Price=41000},
                new Product1{Id=9, Name="Mouse", Comp_Name="ASUS", Price=1700},
                new Product1{Id=10, Name="Mouse", Comp_Name="ACER", Price=350},



            };
            //1. Display all products using LINQ query

            //var result = from p in product1list select p;


            //2. Display products whose price is in between 10000 to 40000

            //var result = from p in product1list
            //             where p.Price > 10000 && p.Price < 40000
            //             select p;

            //3. Display products of Dell company

            //var result = from p in product1list
            //             where p.Comp_Name.Contains("DELL")
            //             select p;


            //4. Display all company laptops

            //var result = from p in product1list
            //             where p.Name.Contains("laptop")
            //             select p;

            //5. Display products whose company name start with ‘A’

            //var result = from p in product1list
            //             where p.Comp_Name.StartsWith("A")
            //             select p;

            //6. Display all company mouse whose price is less than 1000

            //var result = from p in product1list
            //             where p.Name.Contains("Mouse")
            //             where p.Price < 1000
            //             select p;

            //7. Display all products descending order by their price

            //var result = from p in product1list
            //             orderby p.Price descending
            //             select p;


            //8. Display all products accessing order by their company name

            //var result = from p in product1list
            //             orderby p.Comp_Name ascending
            //             select p;

            //9. Display all keyboards accessing order by their price

            var result = from p in product1list
                         where p.Name.Contains("Keyboard")
                         orderby p.Price ascending
                         select p;


            foreach (Product1 p in result)
            {
                Console.WriteLine(p);
            }


            //Using Lambda Expressions
            //Display all products descending order by their price
            //Display product whose Id is 5
            //Display all products whose price less than 5000
            //Display 3 products which have maximum price
            //Display 5 products which have minimum price
        }
    }
}
