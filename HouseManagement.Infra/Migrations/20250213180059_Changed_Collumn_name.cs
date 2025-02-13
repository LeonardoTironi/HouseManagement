using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseManagement.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Changed_Collumn_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsReceita",
                table: "Transactions",
                newName: "IsRevenue");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsRevenue",
                table: "Transactions",
                newName: "IsReceita");
        }
    }
}
