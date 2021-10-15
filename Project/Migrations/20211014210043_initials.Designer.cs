﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.DatabaseContext;

namespace Project.Migrations
{
    [DbContext(typeof(DbEntity))]
    [Migration("20211014210043_initials")]
    partial class initials
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Project.DatabaseContext.Tables.LoginTbl", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LoginTbl");

                    b.HasData(
                        new
                        {
                            Id = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            Name = "Testing Admin 1",
                            Password = "123456",
                            Role = 0,
                            Username = "admin1@gmail.com"
                        },
                        new
                        {
                            Id = "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59",
                            Name = "Testing Admin 2",
                            Password = "123456",
                            Role = 0,
                            Username = "admin2@gmail.com"
                        },
                        new
                        {
                            Id = "7cb86891-85de-48c6-b07e-c2b291aa950b",
                            Name = "Testing User 1",
                            Password = "123456",
                            Role = 1,
                            Username = "user1@gmail.com"
                        },
                        new
                        {
                            Id = "be369e45-391b-472e-a339-c74791cb7f80",
                            Name = "Testing User 2",
                            Password = "123456",
                            Role = 1,
                            Username = "user2@gmail.com"
                        });
                });

            modelBuilder.Entity("Project.DatabaseContext.Tables.ProductTbl", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Img")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductCategory")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductType")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ProductVolume")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Rating")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LoginId");

                    b.ToTable("ProductTbl");

                    b.HasData(
                        new
                        {
                            Id = "fb96cb6d-f820-4b0d-9813-52214a45611f",
                            Img = "https://images.unsplash.com/photo-1564245659875-79f41f648854?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=465&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category1",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 1",
                            ProductPrice = 500m,
                            ProductVolume = 10m,
                            Rating = 4.2m
                        },
                        new
                        {
                            Id = "1bc7b921-a678-4140-85fa-3fb4fb60a652",
                            Img = "https://images.unsplash.com/photo-1625591339971-4c9a87a66871?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=744&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category1",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 2",
                            ProductPrice = 400m,
                            ProductType = "ABC_Type1",
                            ProductVolume = 5m,
                            Rating = 3m
                        },
                        new
                        {
                            Id = "bc6a44ed-f415-4c18-95ac-41fab12391ef",
                            Img = "https://images.unsplash.com/photo-1594495024437-db507fd23fcc?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1031&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category1",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 3",
                            ProductPrice = 300m,
                            ProductType = "ABC_Type1",
                            ProductVolume = 6m,
                            Rating = 3.1m
                        },
                        new
                        {
                            Id = "208ce3c1-8028-4f79-a0ae-fb7b8270092e",
                            Img = "https://images.unsplash.com/photo-1625591341337-13dc6e871cee?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=790&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category1",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 4",
                            ProductPrice = 200m,
                            ProductType = "ABC_Type1",
                            ProductVolume = 7m,
                            Rating = 4.6m
                        },
                        new
                        {
                            Id = "9e8dd985-80dc-4d20-a77e-3d2cc165b069",
                            Img = "https://images.unsplash.com/photo-1577803645773-f96470509666?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=870&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category2",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 5",
                            ProductPrice = 100m,
                            ProductType = "ABC_Type2",
                            ProductVolume = 3m,
                            Rating = 4.3m
                        },
                        new
                        {
                            Id = "082dae65-3fb2-4b4a-ae27-cf8a8116c805",
                            Img = "https://images.unsplash.com/photo-1564867739458-f42235fab442?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=774&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category2",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 6",
                            ProductPrice = 50m,
                            ProductType = "ABC_Type2",
                            ProductVolume = 8m,
                            Rating = 4.1m
                        },
                        new
                        {
                            Id = "62e16838-f2d9-40d8-9068-6c3b27018524",
                            Img = "https://images.unsplash.com/photo-1589642380614-4a8c2147b857?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=774&q=80",
                            LoginId = "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59",
                            ProductCategory = "ABC_Category2",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 7",
                            ProductPrice = 40m,
                            ProductType = "ABC_Type2",
                            ProductVolume = 2m,
                            Rating = 4.9m
                        },
                        new
                        {
                            Id = "308f13e4-a209-4b18-a0a0-2a922e32455b",
                            Img = "https://images.unsplash.com/photo-1508296695146-257a814070b4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=580&q=80",
                            LoginId = "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59",
                            ProductCategory = "ABC_Category2",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 8",
                            ProductPrice = 50m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 1m,
                            Rating = 1.4m
                        },
                        new
                        {
                            Id = "8a93c5da-2269-4ab2-af33-3b19addcc977",
                            Img = "https://images.unsplash.com/photo-1586339392738-65847e399f7e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80",
                            LoginId = "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 9",
                            ProductPrice = 30m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 0m,
                            Rating = 3m
                        },
                        new
                        {
                            Id = "a8649ae1-acf1-4452-b030-27770408dc2f",
                            Img = "https://images.unsplash.com/photo-1579453437873-b765a26aba9c?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=389&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 10",
                            ProductPrice = 20m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 90m,
                            Rating = 3.9m
                        },
                        new
                        {
                            Id = "94393e76-3c22-4e28-95e7-c135776fe8bd",
                            Img = "https://images.unsplash.com/photo-1515613813261-5cd015bcd184?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 11",
                            ProductPrice = 10m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 9m,
                            Rating = 4.6m
                        },
                        new
                        {
                            Id = "2d77198e-8203-4134-97c5-1c99b708f5b9",
                            Img = "https://images.unsplash.com/photo-1548426244-daec2adda8c8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=388&q=80",
                            LoginId = "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 11",
                            ProductPrice = 10m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 9m,
                            Rating = 4.3m
                        },
                        new
                        {
                            Id = "551d18d0-1686-4b01-ae35-220f5f3d9386",
                            Img = "https://images.unsplash.com/photo-1506152983158-b4a74a01c721?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=873&q=80",
                            LoginId = "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 11",
                            ProductPrice = 10m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 9m,
                            Rating = 2.2m
                        },
                        new
                        {
                            Id = "529dd274-2b86-4022-976f-b919bf6f479c",
                            Img = "https://images.unsplash.com/photo-1509695507497-903c140c43b0?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=2073&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 11",
                            ProductPrice = 10m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 9m,
                            Rating = 3.1m
                        },
                        new
                        {
                            Id = "e912f2d3-3442-4165-82fe-ea030e107067",
                            Img = "https://images.unsplash.com/photo-1477064996809-dae46985eee7?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=387&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 11",
                            ProductPrice = 10m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 9m,
                            Rating = 4.8m
                        },
                        new
                        {
                            Id = "4a05d96f-6696-4889-a1b7-bf2aee39647e",
                            Img = "https://images.unsplash.com/photo-1532377394423-f5e9ce8c3511?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 11",
                            ProductPrice = 10m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 9m,
                            Rating = 4.9m
                        },
                        new
                        {
                            Id = "c69d52a8-d4de-45d1-9e0b-63ffba17aa6c",
                            Img = "https://images.unsplash.com/photo-1513065200622-9a226a3c7adc?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=870&q=80",
                            LoginId = "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 11",
                            ProductPrice = 10m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 9m,
                            Rating = 5m
                        },
                        new
                        {
                            Id = "2366be55-7343-429e-84c1-01ae9206aa2b",
                            Img = "https://images.unsplash.com/photo-1496185211634-1ef575aa844a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 11",
                            ProductPrice = 10m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 9m,
                            Rating = 1.9m
                        },
                        new
                        {
                            Id = "58490707-49e8-4de0-871e-c6bb5f85543f",
                            Img = "https://images.unsplash.com/photo-1502929254524-5e4f51903baa?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 11",
                            ProductPrice = 10m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 9m,
                            Rating = 2.4m
                        },
                        new
                        {
                            Id = "bd0dac0b-16c2-4a8f-a4ea-f0c0b82be90d",
                            Img = "https://images.unsplash.com/photo-1577744486770-020ab432da65?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=435&q=80",
                            LoginId = "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 11",
                            ProductPrice = 10m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 9m,
                            Rating = 2.9m
                        },
                        new
                        {
                            Id = "b836b506-4c12-4058-b863-c08c4d108c16",
                            Img = "https://images.unsplash.com/photo-1625591344864-1006c8b89ff0?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=870&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 11",
                            ProductPrice = 10m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 9m,
                            Rating = 3.9m
                        },
                        new
                        {
                            Id = "8011ecef-48cc-4a69-8062-920102e902c0",
                            Img = "https://images.unsplash.com/photo-1580745223935-aefed3be334c?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=436&q=80",
                            LoginId = "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5",
                            ProductCategory = "ABC_Category3",
                            ProductDescription = "Product detail will come here",
                            ProductName = "Product 11",
                            ProductPrice = 10m,
                            ProductType = "ABC_Type3",
                            ProductVolume = 9m,
                            Rating = 4.2m
                        });
                });

            modelBuilder.Entity("Project.DatabaseContext.Tables.ProductTbl", b =>
                {
                    b.HasOne("Project.DatabaseContext.Tables.LoginTbl", "LoginTbl")
                        .WithMany("ProductTbls")
                        .HasForeignKey("LoginId");

                    b.Navigation("LoginTbl");
                });

            modelBuilder.Entity("Project.DatabaseContext.Tables.LoginTbl", b =>
                {
                    b.Navigation("ProductTbls");
                });
#pragma warning restore 612, 618
        }
    }
}
