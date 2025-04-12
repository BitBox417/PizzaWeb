using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzaKing.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Comments", "CreateTimeUTC", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "真不错", new DateTime(2024, 11, 19, 7, 9, 31, 621, DateTimeKind.Utc).AddTicks(9210), "noname1@hotmail.com", "阿莱克斯" },
                    { 2, "还是挺好吃的", new DateTime(2024, 11, 19, 7, 9, 31, 621, DateTimeKind.Utc).AddTicks(9350), "noname2@hotmail.com", "莱克斯" },
                    { 3, "啥轮七八糟的", new DateTime(2024, 11, 19, 7, 9, 31, 621, DateTimeKind.Utc).AddTicks(9350), "noname3@hotmail.com", "克斯" },
                    { 4, "厚切的才有嚼劲", new DateTime(2024, 11, 19, 7, 9, 31, 621, DateTimeKind.Utc).AddTicks(9350), "noname4@hotmail.com", "克斯" }
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "/images/毛细.png", "真的全是香肠啊", "香肠披萨", 12m, "全是香肠" },
                    { 2, "/images/细.png", "蔬菜什锦还有大鱼大肉", "什锦披萨", 10m, "全都有" },
                    { 3, "/images/三细.png", "可以拉丝的奶酪披萨", "奶酪披萨", 11m, "浓浓的芝士奶酪" },
                    { 4, "/images/二细.png", "意大利人的噩梦", "夏威夷披萨", 10m, "有菠萝" },
                    { 5, "/images/二柱子.png", "全国人民的最爱", "小龙虾披萨", 11m, "麻辣小龙虾口味" },
                    { 6, "/images/韭叶子.png", "瞎编的", "咸蛋黄虾仁披萨", 12m, "啥" },
                    { 7, "/images/薄宽.png", "还是我瞎编的", "川式腊味披萨", 11m, "啥啥" },
                    { 8, "/images/大宽.png", "面上加面碳水爆炸", "螺狮粉披萨", 10m, "臭臭的披萨" },
                    { 9, "/images/荞麦棱子.png", "可能也不太正宗", "正宗意大利披萨", 15m, "薄低番茄口" },
                    { 10, "/images/一窝丝.png", "应该还不错吧", "好吃的披萨", 15m, "从必胜客打包来的" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
