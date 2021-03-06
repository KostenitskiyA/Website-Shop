using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Website_Shop.Models.Entities;

namespace Website_Shop.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Authorization> Authorizations { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Basket> Baskets { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<BasketItem> BasketItems { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var authorization1 = new Authorization()
            {
                Id = 1,
                Login = "Vadim",
                Password = "Alladin",
                UserId = 1
            };
            var authorization2 = new Authorization()
            {
                Id = 2,
                Login = "Vlad",
                Password = "Simpotyaga",
                UserId = 2
            };
            var authorization3 = new Authorization()
            {
                Id = 3,
                Login = "Alex",
                Password = "Brodyaga",
                UserId = 3
            };
            var authentications = new List<Authorization>()
            {
                authorization1,
                authorization2,
                authorization3
            };

            var profile1 = new Profile()
            {
                Id = 1,
                Name = "Вадим Чуйка",
                UserId = 1
            };
            var profile2 = new Profile()
            {
                Id = 2,
                Name = "Влад Валакас",
                UserId = 2
            };
            var profile3 = new Profile()
            {
                Id = 3,
                Name = "Александр Кашкай",
                UserId = 3
            };
            var profiles = new List<Profile>()
            {
                profile1,
                profile2,
                profile3
            };

            var user1 = new User()
            {
                Id = 1
            };
            var user2 = new User()
            {
                Id = 2
            };
            var user3 = new User()
            {
                Id = 3
            };
            var users = new List<User>()
            {
                user1,
                user2,
                user3
            };

            var category1 = new Category()
            {
                Id = 1,
                Name = "Смартфоны"
            };
            var category2 = new Category()
            {
                Id = 2,
                Name = "Планшеты"
            };
            var categories = new List<Category>()
            {
                category1,
                category2
            };

            var manufacturer1 = new Manufacturer()
            {
                Id = 1,
                Name = "Apple"
            }; 
            var manufacturer2 = new Manufacturer()
            {
                Id = 2,
                Name = "Samsung"
            };
            var manufacturers = new List<Manufacturer>() 
            {
                manufacturer1,
                manufacturer2
            };

            var product1 = new Product()
            {
                Id = 1,
                Name = "IPhone 11 64Gb",
                Description = "Классный телефон",
                CategoryId = 1,
                ManufacturerId = 1
            };
            var product2 = new Product()
            {
                Id = 2,
                Name = "IPhone 11 128Gb",
                Description = "Классный телефон",
                CategoryId = 1,
                ManufacturerId = 1
            };
            var product3 = new Product()
            {
                Id = 3,
                Name = "IPhone 11 256Gb",
                Description = "Классный телефон",
                CategoryId = 1,
                ManufacturerId = 1
            };
            var product4 = new Product()
            {
                Id = 4,
                Name = "IPhone 12 64Gb",
                Description = "Классный телефон",
                CategoryId = 1,
                ManufacturerId = 1
            };
            var product5 = new Product()
            {
                Id = 5,
                Name = "IPhone 12 128Gb",
                Description = "Классный телефон",
                CategoryId = 1,
                ManufacturerId = 1
            };
            var product6 = new Product()
            {
                Id = 6,
                Name = "IPhone 12 256Gb",
                Description = "Классный телефон",
                CategoryId = 1,
                ManufacturerId = 1
            };
            var product7 = new Product()
            {
                Id = 7,
                Name = "IPhone X 64Gb",
                Description = "Классный телефон",
                CategoryId = 1,
                ManufacturerId = 1
            };
            var product8 = new Product()
            {
                Id = 8,
                Name = "IPhone X 128Gb",
                Description = "Классный телефон",
                CategoryId = 1,
                ManufacturerId = 1
            };
            var products = new List<Product>()
            {
                product1,
                product2,
                product3,
                product4,
                product5,
                product6,
                product7,
                product8
            };

            var basket1 = new Basket()
            {
                Id = 1,
                UserId = 1
            };
            var basket2 = new Basket()
            {
                Id = 2,
                UserId = 2
            };
            var basket3 = new Basket()
            {
                Id = 3,
                UserId = 3
            };
            var baskets = new List<Basket>()
            {
                basket1,
                basket2,
                basket3
            };

            var basketItem1 = new BasketItem()
            {
                Id = 1,
                Count = 1,
                BasketId = 1,
                ProductId = 1
            };
            var basketItem2 = new BasketItem()
            {
                Id = 2,
                Count = 1,
                BasketId = 1,
                ProductId = 4
            };
            var basketItem3 = new BasketItem()
            {
                Id = 3,
                Count = 2,
                BasketId = 1,
                ProductId = 7
            };
            var basketItems = new List<BasketItem>()
            {
                basketItem1,
                basketItem2,
                basketItem3
            };

            var order1 = new Order()
            {
                Id = 1,
                UserId = 1
            };
            var order2 = new Order()
            {
                Id = 2,
                UserId = 1
            };
            var order3 = new Order()
            {
                Id = 3,
                UserId = 2
            };
            var orders = new List<Order>()
            {
                order1,
                order2,
                order3
            };

            var orderItem1 = new OrderItem()
            {
                Id = 1,
                Count = 1,
                OrderId = 1,
                ProductId = 1
            };
            var orderItem2 = new OrderItem()
            {
                Id = 2,
                Count = 1,
                OrderId = 1,
                ProductId = 4
            };
            var orderItem3 = new OrderItem()
            {
                Id = 3,
                Count = 2,
                OrderId = 1,
                ProductId = 7
            };
            var orderItems = new List<OrderItem>()
            {
                orderItem1,
                orderItem2,
                orderItem3
            };

            modelBuilder.Entity<Authorization>()
                .HasData(authentications);

            modelBuilder.Entity<Profile>()
                .HasData(profiles);

            modelBuilder.Entity<User>()
                .HasData(users);

            modelBuilder.Entity<BasketItem>()
                .HasData(basketItems);

            modelBuilder.Entity<Basket>()
                .HasData(baskets);

            modelBuilder.Entity<OrderItem>()
                .HasData(orderItems);

            modelBuilder.Entity<Order>()
                .HasData(orders);

            modelBuilder.Entity<Product>()
                .HasData(products);

            modelBuilder.Entity<Category>()
                .HasData(categories);

            modelBuilder.Entity<Manufacturer>()
                .HasData(manufacturers);

            /// Связь One-to-One
            modelBuilder.Entity<User>()
                .HasOne(u => u.Authorization)
                .WithOne(a => a.User)
                .HasForeignKey<Authorization>(a => a.UserId);

            /// Связь One-to-One
            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<Profile>(p => p.UserId);

            /// Связь One-to-One
            modelBuilder.Entity<User>()
                .HasOne(u => u.Basket)
                .WithOne(b => b.User)
                .HasForeignKey<Basket>(b => b.UserId);

            /// Связь One-to-Many
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);

            /// Связь One-to-Many
            modelBuilder.Entity<BasketItem>()
                .HasOne(b => b.Basket)
                .WithMany(b => b.Items)
                .HasForeignKey(i => i.BasketId);

            /// Связь One-to-Many
            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Order)
                .WithMany(o => o.Items)
                .HasForeignKey(i => i.OrderId);

            /// Связь One-to-Many
            modelBuilder.Entity<BasketItem>()
                .HasOne(b => b.Product)
                .WithMany(p => p.BasketItems)
                .HasForeignKey(b => b.ProductId);

            /// Связь One-to-Many
            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(o => o.ProductId);

            /// Связь One-to-Many
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            /// Связь One-to-Many
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Manufacturer)
                .WithMany(m => m.Products)
                .HasForeignKey(p => p.ManufacturerId);
        }
    }
}