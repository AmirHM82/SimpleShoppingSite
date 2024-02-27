using SimpleShoppingSite.Models;
using SimpleShoppingSite.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShoppingSite.Repositories.Services
{
    public class ProductService : ShareService<Product>, IProduct
    {
        List<Product> items = new List<Product>()
        {
            new Product() {Id = 1, Title = "محصول اول", Price = 1500, Description = "محصول بی نظیر",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product2-2.jpg"},
            new Product() {Id = 2, Title = "محصول دوم", Price = 2000, Description = "خوبه",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product1.webp"},
            new Product() {Id = 3, Title = "محصول سوم", Price = 35000, Description = "چیز خوبیه",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product3-1.webp"},
            new Product() {Id = 4, Title = "محصول چهارم", Price = 4000, Description = "پر فروش",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product3-2.webp"},
            new Product() {Id = 5, Title = "محصول پنجم", Price = 5000, Description = "محبوب",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product2-1.webp"},
            new Product() {Id = 6, Title = "محصول ششم", Price = 1000, Description = "زیبا جادار مطمئن",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product2-2.jpg"},
            new Product() {Id = 7, Title = "محصول هفتم", Price = 2500, Description = "ارزان",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product1.webp"},
            new Product() {Id = 8, Title = "محصول هشتم", Price = 900, Description = "کادو تولد",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product3-1.webp"},
            new Product() {Id = 9, Title = "محصول نهم", Price = 1400, Description = "کادو ولنتاین",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product3-2.webp"},
            new Product() {Id = 10, Title = "محصول دهم", Price = 5600, Description = "مردانه",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product2-1.webp"},
            new Product() {Id = 11, Title = "محصول یازدهم", Price = 780, Description = "زنانه",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product2-2.jpg"},
            new Product() {Id = 12, Title = "محصول دوازدهم", Price = 1478, Description = "بچگانه",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow,ImageName = "product1.webp"},
            new Product() {Id = 13, Title = "محصول سیزدهم", Price = 6300, Description = "انتخابی مطمئن",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product3-1.webp"},
            new Product() {Id = 14, Title = "محصول چهاردهم", Price = 10000, Description = "به صرفه",
            IsAvailable = true, IsHidden = false, PostDate = DateTime.UtcNow, ImageName = "product1.webp"},
        };

        public int Count()
        {
            return items.Count;
        }

        public new List<Product> GetAllAsync(int page, int numberOfItems)
        {
            return items.Skip(--page * numberOfItems).Take(numberOfItems).ToList();
        }
    }
}