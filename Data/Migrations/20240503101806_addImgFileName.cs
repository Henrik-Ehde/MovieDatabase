using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDatabase.Data.Migrations
{
    /// <inheritdoc />
    public partial class addImgFileName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgFileName",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34123d52-f5fd-4e76-8e70-360344b7614c", "AQAAAAIAAYagAAAAEMowsYmEr8XnzVyYFHjbH4HQe+KgApcJ0dfIELlFM9Lh83aY5q4MxgnSILjuuzREMg==", "14a26353-fcb8-437e-a25f-f7462ed2df37" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgFileName",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b6dd9c8-099d-4afc-a71e-ded2fb76c2a8", "AQAAAAIAAYagAAAAEIc1whKEfJ9DkwyU4iU7duFusAjegDhY6mqLaczFIoiDMl6G1Q/bjusDbNoqb0CvrQ==", "ee47693d-0a04-4bac-a290-58ef432a7dde" });
        }
    }
}
