using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object
            ProductText();
            //IoC --> Manager içini new'lememek için . ileri öğreneceğiz.
            //CategoryTest();



        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var i in categoryManager.GetAll())
            {
                Console.WriteLine(i.CategoryName);
            }
        }

        private static void ProductText()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+ "/" +product.CategoryName);
            }
        }
    }
}
