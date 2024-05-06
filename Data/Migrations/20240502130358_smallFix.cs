using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDatabase.Data.Migrations
{
    /// <inheritdoc />
    public partial class smallFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b6dd9c8-099d-4afc-a71e-ded2fb76c2a8", "ADMIN@MOVIEDATABASE.COM", "AQAAAAIAAYagAAAAEIc1whKEfJ9DkwyU4iU7duFusAjegDhY6mqLaczFIoiDMl6G1Q/bjusDbNoqb0CvrQ==", "ee47693d-0a04-4bac-a290-58ef432a7dde" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc1c3cd8-937b-48b0-8d4e-7237b2569eb9", "ADMIN", "AQAAAAIAAYagAAAAED4jcg1k3jhpVwoVPzpWXCYsA0wAYTlwMwpy1qdEAFD0kVXNT+yM4XDpLl/BkhBZww==", "e4ab89fd-5e63-473c-ab53-3ebc569a2141" });
        }
    }
}
