using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieDatabase.Data.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "274fcf33-ddd9-4e76-a72d-b342f87404d0", "AQAAAAIAAYagAAAAENVAQ6sfcDj5PWLt75AfznmkG63svt9c5MCOPzJe1/uxIJbOqyzsqKjBDUfXbIE92Q==", "364bf725-bc69-4009-a053-0e191ea5afda" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Comedy" },
                    { 2, "Drama" },
                    { 3, "Action" },
                    { 4, "Romance" },
                    { 5, "Science Fiction" },
                    { 6, "Fantasy" },
                    { 7, "Children" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "GenreId", "ImgFileName", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Luke Skywalker learns magic from a strange hermit in the desert, joins the rebels and fights the empire", 5, "Star Wars.jpg", new DateOnly(1977, 12, 16), "Star Wars" },
                    { 2, "Paul Atreides starts a holy war", 5, "Dune Part Two.jpg", new DateOnly(2024, 2, 28), "Dune Part Two" },
                    { 3, "A bunch of famous actors face the apocalypse and die", 1, "This-is-the-End-Film-Poster.jpg", new DateOnly(2013, 6, 3), "This is the end" },
                    { 4, "A mammoth, a sloth and a saber-toothed tiger find a human baby and go on a journey to find its family.", 7, "Ice Age.webp", new DateOnly(2002, 3, 15), "Ice Age" },
                    { 5, "A teacher who doesn't want to teach is transferred to the most remote school in the world.", 2, "A Yak in the Classroom.jpg", new DateOnly(2019, 10, 5), "Lunana: A Yak in the Classroom" },
                    { 6, "Greed and class discrimination threaten the newly-formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.", 1, "Parasite.jpg", new DateOnly(2019, 5, 30), "Parasite" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34123d52-f5fd-4e76-8e70-360344b7614c", "AQAAAAIAAYagAAAAEMowsYmEr8XnzVyYFHjbH4HQe+KgApcJ0dfIELlFM9Lh83aY5q4MxgnSILjuuzREMg==", "14a26353-fcb8-437e-a25f-f7462ed2df37" });
        }
    }
}
