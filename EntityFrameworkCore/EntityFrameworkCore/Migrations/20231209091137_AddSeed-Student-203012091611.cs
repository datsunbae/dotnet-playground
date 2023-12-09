using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Migrations
{
    public partial class AddSeedStudent203012091611 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c8cc471e-31f0-4086-94cc-06ec2e292a5c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e2b813b6-e6e2-451d-b73e-3bc101674af9"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("c8cc471e-31f0-4086-94cc-06ec2e292a5c"), "Binh Tan, HCM", 18, "Datsunbae" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Age", "Name" },
                values: new object[] { new Guid("e2b813b6-e6e2-451d-b73e-3bc101674af9"), "Go Vap, HCM", 20, "Kodoku" });
        }
    }
}
