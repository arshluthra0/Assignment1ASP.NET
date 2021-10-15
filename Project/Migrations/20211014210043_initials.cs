using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginTbl",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Role = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTbl",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Img = table.Column<string>(type: "TEXT", nullable: true),
                    ProductType = table.Column<string>(type: "TEXT", nullable: true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    ProductDescription = table.Column<string>(type: "TEXT", nullable: true),
                    ProductCategory = table.Column<string>(type: "TEXT", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    ProductVolume = table.Column<decimal>(type: "TEXT", nullable: false),
                    Rating = table.Column<decimal>(type: "TEXT", nullable: false),
                    LoginId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTbl_LoginTbl_LoginId",
                        column: x => x.LoginId,
                        principalTable: "LoginTbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "LoginTbl",
                columns: new[] { "Id", "Name", "Password", "Role", "Username" },
                values: new object[] { "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "Testing Admin 1", "123456", 0, "admin1@gmail.com" });

            migrationBuilder.InsertData(
                table: "LoginTbl",
                columns: new[] { "Id", "Name", "Password", "Role", "Username" },
                values: new object[] { "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59", "Testing Admin 2", "123456", 0, "admin2@gmail.com" });

            migrationBuilder.InsertData(
                table: "LoginTbl",
                columns: new[] { "Id", "Name", "Password", "Role", "Username" },
                values: new object[] { "7cb86891-85de-48c6-b07e-c2b291aa950b", "Testing User 1", "123456", 1, "user1@gmail.com" });

            migrationBuilder.InsertData(
                table: "LoginTbl",
                columns: new[] { "Id", "Name", "Password", "Role", "Username" },
                values: new object[] { "be369e45-391b-472e-a339-c74791cb7f80", "Testing User 2", "123456", 1, "user2@gmail.com" });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "fb96cb6d-f820-4b0d-9813-52214a45611f", "https://images.unsplash.com/photo-1564245659875-79f41f648854?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=465&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category1", "Product detail will come here", "Product 1", 500m, null, 10m, 4.2m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "551d18d0-1686-4b01-ae35-220f5f3d9386", "https://images.unsplash.com/photo-1506152983158-b4a74a01c721?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=873&q=80", "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59", "ABC_Category3", "Product detail will come here", "Product 11", 10m, "ABC_Type3", 9m, 2.2m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "2d77198e-8203-4134-97c5-1c99b708f5b9", "https://images.unsplash.com/photo-1548426244-daec2adda8c8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=388&q=80", "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59", "ABC_Category3", "Product detail will come here", "Product 11", 10m, "ABC_Type3", 9m, 4.3m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "8a93c5da-2269-4ab2-af33-3b19addcc977", "https://images.unsplash.com/photo-1586339392738-65847e399f7e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80", "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59", "ABC_Category3", "Product detail will come here", "Product 9", 30m, "ABC_Type3", 0m, 3m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "308f13e4-a209-4b18-a0a0-2a922e32455b", "https://images.unsplash.com/photo-1508296695146-257a814070b4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=580&q=80", "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59", "ABC_Category2", "Product detail will come here", "Product 8", 50m, "ABC_Type3", 1m, 1.4m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "62e16838-f2d9-40d8-9068-6c3b27018524", "https://images.unsplash.com/photo-1589642380614-4a8c2147b857?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=774&q=80", "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59", "ABC_Category2", "Product detail will come here", "Product 7", 40m, "ABC_Type2", 2m, 4.9m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "8011ecef-48cc-4a69-8062-920102e902c0", "https://images.unsplash.com/photo-1580745223935-aefed3be334c?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=436&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category3", "Product detail will come here", "Product 11", 10m, "ABC_Type3", 9m, 4.2m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "b836b506-4c12-4058-b863-c08c4d108c16", "https://images.unsplash.com/photo-1625591344864-1006c8b89ff0?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=870&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category3", "Product detail will come here", "Product 11", 10m, "ABC_Type3", 9m, 3.9m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "58490707-49e8-4de0-871e-c6bb5f85543f", "https://images.unsplash.com/photo-1502929254524-5e4f51903baa?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category3", "Product detail will come here", "Product 11", 10m, "ABC_Type3", 9m, 2.4m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "2366be55-7343-429e-84c1-01ae9206aa2b", "https://images.unsplash.com/photo-1496185211634-1ef575aa844a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category3", "Product detail will come here", "Product 11", 10m, "ABC_Type3", 9m, 1.9m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "4a05d96f-6696-4889-a1b7-bf2aee39647e", "https://images.unsplash.com/photo-1532377394423-f5e9ce8c3511?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category3", "Product detail will come here", "Product 11", 10m, "ABC_Type3", 9m, 4.9m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "e912f2d3-3442-4165-82fe-ea030e107067", "https://images.unsplash.com/photo-1477064996809-dae46985eee7?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=387&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category3", "Product detail will come here", "Product 11", 10m, "ABC_Type3", 9m, 4.8m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "529dd274-2b86-4022-976f-b919bf6f479c", "https://images.unsplash.com/photo-1509695507497-903c140c43b0?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=2073&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category3", "Product detail will come here", "Product 11", 10m, "ABC_Type3", 9m, 3.1m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "94393e76-3c22-4e28-95e7-c135776fe8bd", "https://images.unsplash.com/photo-1515613813261-5cd015bcd184?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category3", "Product detail will come here", "Product 11", 10m, "ABC_Type3", 9m, 4.6m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "a8649ae1-acf1-4452-b030-27770408dc2f", "https://images.unsplash.com/photo-1579453437873-b765a26aba9c?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=389&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category3", "Product detail will come here", "Product 10", 20m, "ABC_Type3", 90m, 3.9m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "082dae65-3fb2-4b4a-ae27-cf8a8116c805", "https://images.unsplash.com/photo-1564867739458-f42235fab442?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=774&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category2", "Product detail will come here", "Product 6", 50m, "ABC_Type2", 8m, 4.1m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "9e8dd985-80dc-4d20-a77e-3d2cc165b069", "https://images.unsplash.com/photo-1577803645773-f96470509666?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=870&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category2", "Product detail will come here", "Product 5", 100m, "ABC_Type2", 3m, 4.3m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "208ce3c1-8028-4f79-a0ae-fb7b8270092e", "https://images.unsplash.com/photo-1625591341337-13dc6e871cee?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=790&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category1", "Product detail will come here", "Product 4", 200m, "ABC_Type1", 7m, 4.6m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "bc6a44ed-f415-4c18-95ac-41fab12391ef", "https://images.unsplash.com/photo-1594495024437-db507fd23fcc?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1031&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category1", "Product detail will come here", "Product 3", 300m, "ABC_Type1", 6m, 3.1m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "1bc7b921-a678-4140-85fa-3fb4fb60a652", "https://images.unsplash.com/photo-1625591339971-4c9a87a66871?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=744&q=80", "09ddbeaa-0071-411d-a6e8-25ffdcfcaea5", "ABC_Category1", "Product detail will come here", "Product 2", 400m, "ABC_Type1", 5m, 3m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "c69d52a8-d4de-45d1-9e0b-63ffba17aa6c", "https://images.unsplash.com/photo-1513065200622-9a226a3c7adc?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=870&q=80", "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59", "ABC_Category3", "Product detail will come here", "Product 11", 10m, "ABC_Type3", 9m, 5m });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "Id", "Img", "LoginId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductType", "ProductVolume", "Rating" },
                values: new object[] { "bd0dac0b-16c2-4a8f-a4ea-f0c0b82be90d", "https://images.unsplash.com/photo-1577744486770-020ab432da65?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=435&q=80", "d3fdea64-e7db-4c4d-aab0-8d2adf7b3c59", "ABC_Category3", "Product detail will come here", "Product 11", 10m, "ABC_Type3", 9m, 2.9m });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTbl_LoginId",
                table: "ProductTbl",
                column: "LoginId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTbl");

            migrationBuilder.DropTable(
                name: "LoginTbl");
        }
    }
}
