using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatStore.WebMVC.Migrations
{
    public partial class Mig3_AutoFillAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Description", "Image", "IsLoving", "IsPlayful", "Name", "PetKind", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Всем привет, это самый луший кот, берите, непожелеете!", "emptyCatImage.jpg", true, true, "Мурзик", 1, 10, "Самый лучший кот!" },
                    { 2, 1, "Всем привет, это самый луший кот, берите, непожелеете!", "emptyCatImage.jpg", true, true, "Мурзик", 1, 10, "Второй самый лучший кот!" },
                    { 3, 1, "Всем привет, это самый луший кот, берите, непожелеете!", "emptyCatImage.jpg", true, true, "Мурзик", 1, 10, "Третий самый лучший кот!" },
                    { 4, 1, "Всем привет, это самый луший кот, берите, непожелеете!", "emptyCatImage.jpg", true, true, "Мурзик", 1, 10, "Четвертый самый лучший кот!" },
                    { 5, 1, "Всем привет, это самый луший кот, берите, непожелеете!", "emptyCatImage.jpg", true, true, "Мурзик", 1, 10, "Пятый самый лучший кот!" },
                    { 6, 1, "Всем привет, это самый луший кот, берите, непожелеете!", "emptyCatImage.jpg", true, true, "Мурзик", 1, 10, "Шестой самый лучший кот!" },
                    { 7, 7, "Всем привет, это самый луший кот, берите, непожелеете!", "emptyCatImage.jpg", true, true, "Мурзик", 1, 10, "Седьмой самый лучший кот!" },
                    { 8, 1, "Всем привет, это самый луший кот, берите, непожелеете!", "emptyCatImage.jpg", true, true, "Мурзик", 1, 10, "Восьмой самый лучший кот!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
