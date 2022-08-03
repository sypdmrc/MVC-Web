using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sıfırdan.MVCWeb.Entity
{
    public class DataInitiliazer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        public override void InitializeDatabase(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name = "Kamera", Description = "Kamera Ürünleri"},
                new Category() {Name = "Bilgisayar", Description = "Bilgisayar Ürünleri"},
                new Category() {Name = "Elektronik", Description = "Elektronik Ürünleri"},
                new Category() {Name = "Telefon", Description = "Telefon Ürünleri"},
                new Category() {Name = "Beyaz Eşya", Description = "Beyaz Eşya Ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }

            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product()
                {
                    Name = "Canon", Description = "Kamaranın şahı", Price = 2500, Stock = 100, IsApproved = true,CategoryId =1,IsHome = true
                },
                new Product()
                {
                    Name = "Exile", Description = "Kamaranın şahı", Price = 1500, Stock = 300, IsApproved = true,CategoryId = 1,IsHome = true
                },
                new Product()
                {
                    Name = "KAMARA", Description = "Kamaranın şahı", Price = 2000, Stock = 200, IsApproved = true,CategoryId =1
                },
                new Product()
                {
                    Name = "kamera", Description = "Kamaranın şahı", Price = 1800, Stock = 400, IsApproved = true,CategoryId = 1
                },
                new Product()
                {
                    Name = "Abla", Description = "Kamaranın şahı", Price = 1700, Stock = 500, IsApproved = true,CategoryId =1,
                },
                new Product()
                {
                    Name = "ASUS", Description = "Kamaranın şahı", Price = 2500, Stock = 100, IsApproved = true,CategoryId = 2,IsHome = true
                },
                new Product()
                {
                    Name = "Manstır", Description = "Kamaranın şahı", Price = 2500, Stock = 100, IsApproved = true,CategoryId =2,IsHome = true
                },
                new Product()
                {
                    Name = "MSI", Description = "Kamaranın şahı", Price = 2500, Stock = 100, IsApproved = true,CategoryId = 2
                },
                new Product()
                {
                    Name = "ÇÖSPTIR", Description = "Kamaranın şahı", Price = 2500, Stock = 100, IsApproved = true,CategoryId = 2
                },
                new Product()
                {
                    Name = "ACER", Description = "Kamaranın şahı", Price = 2500, Stock = 100, IsApproved = true,CategoryId = 2
                },
                new Product()
                {
                    Name = "ASUS", Description = "Kamaranın şahı", Price = 2500, Stock = 100, IsApproved = true,CategoryId =3,IsHome = true
                },
                new Product()
                {
                    Name = "Manstır", Description = "Kamaranın şahı", Price = 2500, Stock = 100, IsApproved = true,CategoryId =3,IsHome = true
                },
                new Product()
                {
                    Name = "MSI", Description = "Kamaranın şahı", Price = 2500, Stock = 100, IsApproved = true,CategoryId = 3
                },
                new Product()
                {
                    Name = "ÇÖSPTIR", Description = "Kamaranın şahı", Price = 2500, Stock = 100, IsApproved = true,CategoryId = 3
                },
                new Product()
                {
                    Name = "ACER", Description = "Kamaranın şahı", Price = 2500, Stock = 100, IsApproved = true,CategoryId = 3,IsHome = true
                },

                };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}   