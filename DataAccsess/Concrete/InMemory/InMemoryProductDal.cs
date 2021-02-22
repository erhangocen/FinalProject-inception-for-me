using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            // Bunlar normalde Oracle, Sql Server vs.'den geliyor
            _products = new List<Product>
            {
                new Product{ProductID = 1, CategoryID = 1, ProductName = "Bardak", UnitPrice=350, UnitsInStock=8},
                new Product{ProductID = 2, CategoryID = 2, ProductName = "Kamera", UnitPrice=350, UnitsInStock=8},
                new Product{ProductID = 3, CategoryID = 3, ProductName = "Telefon", UnitPrice=350, UnitsInStock=8},
                new Product{ProductID = 4, CategoryID = 4, ProductName = "Klavye", UnitPrice=350, UnitsInStock=8},
                new Product{ProductID = 5, CategoryID = 5, ProductName = "Mouse", UnitPrice=350, UnitsInStock=8},
            };
        }

        public void Add(Product product) 
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ yapısı var SingleOrDefault map gibi çalışıyor va sorguya göre atıyor...
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductID == product.ProductID);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetalis()
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetalist()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Başka bir class'ın özelliklerini (product) eski class ile değirebiliyoruz fakat ID'lerin eşit olması gerek. Yaani id'si aynı olan ürün ile yeni ürünü değiştiricek...
            //Gönderdiğim ürün Id'sine sahip ürünü listede bul demek
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
