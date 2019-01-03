using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMenagement.DAL.Migrations
{
    public partial class imageUrlSpecification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Book",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Book",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);
        }
    }
}
