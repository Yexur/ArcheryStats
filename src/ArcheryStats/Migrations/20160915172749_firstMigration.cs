using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ArcheryStats.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PracticeStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BlackHits = table.Column<int>(nullable: false),
                    BlueHits = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    NumberOfShots = table.Column<int>(nullable: false),
                    PracticeDate = table.Column<DateTime>(nullable: false),
                    RedHits = table.Column<int>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    WhiteHits = table.Column<int>(nullable: false),
                    YellowHits = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticeStatistics", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PracticeStatistics");
        }
    }
}
