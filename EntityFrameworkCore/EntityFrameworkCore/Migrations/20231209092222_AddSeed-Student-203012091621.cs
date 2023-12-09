using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Migrations
{
    public partial class AddSeedStudent203012091621 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5801f726-3bd3-4524-a080-31dbde3cf4ce"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b59a518d-6bb2-48b1-a569-211a09f7080f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f6a50b3b-7b98-4817-a8d9-3153c2efc454"));

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("41b59623-549d-4bee-b055-ad6fcb98ccb6"), "Binh Tan, HCM", 18, "Datsunbae" },
                    { new Guid("c262da4f-6a04-484c-8996-21eb92f8aa05"), "Go Vap, HCM", 21, "Van Dat" },
                    { new Guid("c2df7bd2-1f47-4c60-a482-b936604a550c"), "USA", 21, "Justin" },
                    { new Guid("daa362be-7555-471b-9afd-1e578d5ffb87"), "Go Vap, HCM", 20, "Kodoku" },
                    { new Guid("f02d37be-f61f-4212-87b4-5fb4a4f79ae0"), "USA", 22, "Ronaldo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("41b59623-549d-4bee-b055-ad6fcb98ccb6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c262da4f-6a04-484c-8996-21eb92f8aa05"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c2df7bd2-1f47-4c60-a482-b936604a550c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("daa362be-7555-471b-9afd-1e578d5ffb87"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f02d37be-f61f-4212-87b4-5fb4a4f79ae0"));

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Age", "Name" },
                values: new object[] { new Guid("5801f726-3bd3-4524-a080-31dbde3cf4ce"), "Binh Tan, HCM", 18, "Datsunbae" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Age", "Name" },
                values: new object[] { new Guid("b59a518d-6bb2-48b1-a569-211a09f7080f"), "Go Vap, HCM", 21, "Van Dat" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Age", "Name" },
                values: new object[] { new Guid("f6a50b3b-7b98-4817-a8d9-3153c2efc454"), "Go Vap, HCM", 20, "Kodoku" });
        }
    }
}
