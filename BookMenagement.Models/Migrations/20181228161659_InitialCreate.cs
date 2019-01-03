using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMenagement.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 2, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Code = table.Column<string>(maxLength: 2, nullable: false),
                    Symbol = table.Column<string>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    DefaultRatio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Surname = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArtistName = table.Column<string>(maxLength: 150, nullable: true),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Author_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecieptHeader",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TotalAmount = table.Column<decimal>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CostumerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecieptHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecieptHeader_Person_CostumerId",
                        column: x => x.CostumerId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: true),
                    BookCategoryId = table.Column<int>(nullable: true),
                    AuthorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_BookCategory_BookCategoryId",
                        column: x => x.BookCategoryId,
                        principalTable: "BookCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecieptLine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LineNo = table.Column<int>(nullable: false),
                    ProductIdId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecieptLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecieptLine_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecieptLine_Book_ProductIdId",
                        column: x => x.ProductIdId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Author_PersonId",
                table: "Author",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_BookCategoryId",
                table: "Book",
                column: "BookCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CurrencyId",
                table: "Book",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_RecieptHeader_CostumerId",
                table: "RecieptHeader",
                column: "CostumerId");

            migrationBuilder.CreateIndex(
                name: "IX_RecieptLine_CurrencyId",
                table: "RecieptLine",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_RecieptLine_ProductIdId",
                table: "RecieptLine",
                column: "ProductIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecieptHeader");

            migrationBuilder.DropTable(
                name: "RecieptLine");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "BookCategory");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
