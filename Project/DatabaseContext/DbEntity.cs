using Microsoft.EntityFrameworkCore;
using Project.DatabaseContext.Tables;
using System;
using Project.Models.Enums;
using System.Threading.Tasks;

namespace Project.DatabaseContext
{
    public class DbEntity : DbContext
    {
        public DbSet<LoginTbl> loginTbls { get; set; }
        public DbSet<ProductTbl> productTbls { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=project.db");
        }

        /// <summary>
        /// Migrate Database
        /// </summary>
        /// <returns></returns>
        public async Task MigrateDatabase()
        {
            await this.Database.MigrateAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string user1 = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5";
            string user2 = "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59";
            string user3 = "7cb86891-85de-48c6-b07e-c2b291aa950b";
            string user4 = "be369e45-391b-472e-a339-c74791cb7f80";
            modelBuilder.Entity<ProductTbl>()
                 .HasOne(p => p.LoginTbl)
                 .WithMany(b => b.ProductTbls)
                 .HasForeignKey(p => p.LoginId);

            modelBuilder.Entity<LoginTbl>().HasData(
                new LoginTbl { Id = user1, Name = "Testing Admin 1", Role = LoginEnum.Admin, Username = "admin1@gmail.com", Password = "123456" },
                new LoginTbl { Id = user2, Name = "Testing Admin 2", Role = LoginEnum.Admin, Username = "admin2@gmail.com", Password = "123456" },
                new LoginTbl { Id = user3, Name = "Testing User 1", Role = LoginEnum.User, Username = "user1@gmail.com", Password = "123456" },
                new LoginTbl { Id = user4, Name = "Testing User 2", Role = LoginEnum.User, Username = "user2@gmail.com", Password = "123456" });

            modelBuilder.Entity<ProductTbl>().HasData(
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 4.2M, Img = "https://images.unsplash.com/photo-1564245659875-79f41f648854?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=465&q=80", ProductCategory = "ABC_Category1", ProductName = "Product 1", ProductDescription = "Product detail will come here", ProductPrice = 500M, ProductVolume = 10, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 3, Img = "https://images.unsplash.com/photo-1625591339971-4c9a87a66871?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=744&q=80", ProductType = "ABC_Type1", ProductCategory = "ABC_Category1", ProductName = "Product 2", ProductDescription = "Product detail will come here", ProductPrice = 400M, ProductVolume = 5, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 3.1M, Img = "https://images.unsplash.com/photo-1594495024437-db507fd23fcc?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1031&q=80", ProductType = "ABC_Type1", ProductCategory = "ABC_Category1", ProductName = "Product 3", ProductDescription = "Product detail will come here", ProductPrice = 300M, ProductVolume = 6, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 4.6M, Img = "https://images.unsplash.com/photo-1625591341337-13dc6e871cee?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=790&q=80", ProductType = "ABC_Type1", ProductCategory = "ABC_Category1", ProductName = "Product 4", ProductDescription = "Product detail will come here", ProductPrice = 200M, ProductVolume = 7, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 4.3M, Img = "https://images.unsplash.com/photo-1577803645773-f96470509666?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=870&q=80", ProductType = "ABC_Type2", ProductCategory = "ABC_Category2", ProductName = "Product 5", ProductDescription = "Product detail will come here", ProductPrice = 100M, ProductVolume = 3, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 4.1M, Img = "https://images.unsplash.com/photo-1564867739458-f42235fab442?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=774&q=80", ProductType = "ABC_Type2", ProductCategory = "ABC_Category2", ProductName = "Product 6", ProductDescription = "Product detail will come here", ProductPrice = 50M, ProductVolume = 8, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 4.9M, Img = "https://images.unsplash.com/photo-1589642380614-4a8c2147b857?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=774&q=80", ProductType = "ABC_Type2", ProductCategory = "ABC_Category2", ProductName = "Product 7", ProductDescription = "Product detail will come here", ProductPrice = 40M, ProductVolume = 2, LoginId = user2, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 1.4M, Img = "https://images.unsplash.com/photo-1508296695146-257a814070b4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=580&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category2", ProductName = "Product 8", ProductDescription = "Product detail will come here", ProductPrice = 50M, ProductVolume = 1, LoginId = user2, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 3M, Img = "https://images.unsplash.com/photo-1586339392738-65847e399f7e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 9", ProductDescription = "Product detail will come here", ProductPrice = 30M, ProductVolume = 0, LoginId = user2, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 3.9M, Img = "https://images.unsplash.com/photo-1579453437873-b765a26aba9c?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=389&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 10", ProductDescription = "Product detail will come here", ProductPrice = 20M, ProductVolume = 90, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 4.6M, Img = "https://images.unsplash.com/photo-1515613813261-5cd015bcd184?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 11", ProductDescription = "Product detail will come here", ProductPrice = 10M, ProductVolume = 9, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 4.3M, Img = "https://images.unsplash.com/photo-1548426244-daec2adda8c8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=388&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 11", ProductDescription = "Product detail will come here", ProductPrice = 10M, ProductVolume = 9, LoginId = user2, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 2.2M, Img = "https://images.unsplash.com/photo-1506152983158-b4a74a01c721?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=873&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 11", ProductDescription = "Product detail will come here", ProductPrice = 10M, ProductVolume = 9, LoginId = user2, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 3.1M, Img = "https://images.unsplash.com/photo-1509695507497-903c140c43b0?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=2073&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 11", ProductDescription = "Product detail will come here", ProductPrice = 10M, ProductVolume = 9, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 4.8M, Img = "https://images.unsplash.com/photo-1477064996809-dae46985eee7?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=387&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 11", ProductDescription = "Product detail will come here", ProductPrice = 10M, ProductVolume = 9, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 4.9M, Img = "https://images.unsplash.com/photo-1532377394423-f5e9ce8c3511?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 11", ProductDescription = "Product detail will come here", ProductPrice = 10M, ProductVolume = 9, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 5M, Img = "https://images.unsplash.com/photo-1513065200622-9a226a3c7adc?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=870&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 11", ProductDescription = "Product detail will come here", ProductPrice = 10M, ProductVolume = 9, LoginId = user2, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 1.9M, Img = "https://images.unsplash.com/photo-1496185211634-1ef575aa844a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 11", ProductDescription = "Product detail will come here", ProductPrice = 10M, ProductVolume = 9, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 2.4M, Img = "https://images.unsplash.com/photo-1502929254524-5e4f51903baa?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 11", ProductDescription = "Product detail will come here", ProductPrice = 10M, ProductVolume = 9, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 2.9M, Img = "https://images.unsplash.com/photo-1577744486770-020ab432da65?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=435&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 11", ProductDescription = "Product detail will come here", ProductPrice = 10M, ProductVolume = 9, LoginId = user2, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 3.9M, Img = "https://images.unsplash.com/photo-1625591344864-1006c8b89ff0?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=870&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 11", ProductDescription = "Product detail will come here", ProductPrice = 10M, ProductVolume = 9, LoginId = user1, },
                new ProductTbl { Id = Guid.NewGuid().ToString(), Rating = 4.2M, Img = "https://images.unsplash.com/photo-1580745223935-aefed3be334c?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=436&q=80", ProductType = "ABC_Type3", ProductCategory = "ABC_Category3", ProductName = "Product 11", ProductDescription = "Product detail will come here", ProductPrice = 10M, ProductVolume = 9, LoginId = user1, });
        }
    }

}
