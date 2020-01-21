using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMenagement.DAL.Migrations
{
    public partial class AddPersonalNrToPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersonalNr",
                table: "Person",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalNr",
                table: "Person");
        }
    }
}
