using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQDemo
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} -> {Name} -> {Price}";
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> productlist = new List<Product>()
            {
                new Product{Id=1, Name="Mouse", Price=999},
                new Product{Id=2, Name="Pen", Price=20},
                new Product{Id=3, Name="Book", Price=150},
                new Product{Id=4, Name="Marker", Price=50},
                new Product{Id=5, Name="Board", Price=800},
                new Product{Id=6, Name="Notebook", Price=45},
                new Product{Id=7, Name="Eraser", Price=5},
                new Product{Id=8, Name="Sharpner", Price=10},
                new Product{Id=9, Name="Scale", Price=17},
                new Product{Id=10, Name="Rounder", Price=35},



            };
            var result = from p in productlist select p;

            //var result = from p in productlist
            //             where p.Price < 50
            //             select p;

            //var result = from p in productlist
            //             where p.Price > 10 && p.Price < 30
            //             select p;

            //var result = from p in productlist
            //             where p.Name.Contains("Pe")
            //             select p;

            //var result = from p in productlist
            //             where p.Name.StartsWith("P")
            //             select p;

            //var result = from p in productlist
            //             where p.Name.EndsWith("r")
            //             select p;

            //var result = from p in productlist
            //             where p.Price<50
            //             orderby p.Price ascending
            //             select p;

            //var result = from p in productlist
            //             where p.Price < 50
            //             orderby p.Price descending
            //             select p;

            //var result = from p in productlist
            //             where p.Price < 50
            //             orderby p.Name descending
            //             select p;

            //var result = from p in productlist
            //             where p.Price < 50
            //             orderby p.Name ascending
            //             select p;


            foreach (Product p in result)
            {
                Console.WriteLine(p);
            }
        }
    }
}
