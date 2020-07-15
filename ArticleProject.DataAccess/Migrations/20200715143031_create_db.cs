using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArticleProject.DataAccess.Migrations
{
    public partial class create_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 500, nullable: false),
                    Summary = table.Column<string>(nullable: false),
                    Abstract = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Author = table.Column<string>(maxLength: 255, nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");
        }
    }
}
