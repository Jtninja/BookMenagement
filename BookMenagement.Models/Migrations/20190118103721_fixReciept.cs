using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMenagement.DAL.Migrations
{
    public partial class fixReciept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_BookCategory_BookCategoryId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Currency_CurrencyId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_RecieptHeader_Person_CostumerId",
                table: "RecieptHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_RecieptLine_Currency_CurrencyId",
                table: "RecieptLine");

            migrationBuilder.DropForeignKey(
                name: "FK_RecieptLine_Book_ProductIdId",
                table: "RecieptLine");

            migrationBuilder.DropIndex(
                name: "IX_RecieptLine_CurrencyId",
                table: "RecieptLine");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "RecieptLine");

            migrationBuilder.RenameColumn(
                name: "ProductIdId",
                table: "RecieptLine",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_RecieptLine_ProductIdId",
                table: "RecieptLine",
                newName: "IX_RecieptLine_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "RecieptHeaderId",
                table: "RecieptLine",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CostumerId",
                table: "RecieptHeader",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "RecieptHeader",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "Book",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookCategoryId",
                table: "Book",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Book",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RecieptLine_RecieptHeaderId",
                table: "RecieptLine",
                column: "RecieptHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_RecieptHeader_CurrencyId",
                table: "RecieptHeader",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_BookCategory_BookCategoryId",
                table: "Book",
                column: "BookCategoryId",
                principalTable: "BookCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Currency_CurrencyId",
                table: "Book",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecieptHeader_Person_CostumerId",
                table: "RecieptHeader",
                column: "CostumerId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecieptHeader_Currency_CurrencyId",
                table: "RecieptHeader",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecieptLine_Book_ProductId",
                table: "RecieptLine",
                column: "ProductId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecieptLine_RecieptHeader_RecieptHeaderId",
                table: "RecieptLine",
                column: "RecieptHeaderId",
                principalTable: "RecieptHeader",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_BookCategory_BookCategoryId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Currency_CurrencyId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_RecieptHeader_Person_CostumerId",
                table: "RecieptHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_RecieptHeader_Currency_CurrencyId",
                table: "RecieptHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_RecieptLine_Book_ProductId",
                table: "RecieptLine");

            migrationBuilder.DropForeignKey(
                name: "FK_RecieptLine_RecieptHeader_RecieptHeaderId",
                table: "RecieptLine");

            migrationBuilder.DropIndex(
                name: "IX_RecieptLine_RecieptHeaderId",
                table: "RecieptLine");

            migrationBuilder.DropIndex(
                name: "IX_RecieptHeader_CurrencyId",
                table: "RecieptHeader");

            migrationBuilder.DropColumn(
                name: "RecieptHeaderId",
                table: "RecieptLine");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "RecieptHeader");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "RecieptLine",
                newName: "ProductIdId");

            migrationBuilder.RenameIndex(
                name: "IX_RecieptLine_ProductId",
                table: "RecieptLine",
                newName: "IX_RecieptLine_ProductIdId");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "RecieptLine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CostumerId",
                table: "RecieptHeader",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "Book",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BookCategoryId",
                table: "Book",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Book",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_RecieptLine_CurrencyId",
                table: "RecieptLine",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_BookCategory_BookCategoryId",
                table: "Book",
                column: "BookCategoryId",
                principalTable: "BookCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Currency_CurrencyId",
                table: "Book",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecieptHeader_Person_CostumerId",
                table: "RecieptHeader",
                column: "CostumerId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecieptLine_Currency_CurrencyId",
                table: "RecieptLine",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecieptLine_Book_ProductIdId",
                table: "RecieptLine",
                column: "ProductIdId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
