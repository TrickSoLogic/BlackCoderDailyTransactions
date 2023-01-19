using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackCoderDailyTransactions.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyTransaction",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionInAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionOutAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyTransaction", x => x.TransactionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyTransaction");
        }
    }
}
