using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using DataAccsess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
        }

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    var result = productManager.GetProductDetails();
        //    //GetByUnitPriceMethod(productManager);

        //    if (result.Success == true)
        //    {
        //        foreach (var product in result.Data)
        //        {
        //            Console.WriteLine(product.ProductName + " / " + product.CategoryName + " / " + product.UnitsInStock);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}

        private static void GetByUnitPriceMethod(ProductManager productManager)
        {
            var result = productManager.GetByUnitPrice(50, 300);

            Console.WriteLine(result.Message);

            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName + " - " + product.UnitPrice);
            }
        }
    }
}
