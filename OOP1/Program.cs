﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.Unitprice = 500;
            product1.UnıtsInStock = 3;

            //important
            Product product2 = new Product {Id = 2, CategoryId= 5,
                UnıtsInStock = 5, ProductName="Pen", Unitprice= 35};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla2(3, 6);


            
            
                

        }
    }
}
