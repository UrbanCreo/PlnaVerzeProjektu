using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eshop.Data.Migrations
{
    public partial class Seznam_Pojistencu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AddInsuranceModel");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AddInsuranceModel");

            migrationBuilder.DropColumn(
                name: "Jmeno",
                table: "AddInsuranceModel");

            migrationBuilder.DropColumn(
                name: "Mesto",
                table: "AddInsuranceModel");

            migrationBuilder.DropColumn(
                name: "PSC",
                table: "AddInsuranceModel");

            migrationBuilder.DropColumn(
                name: "Prijmeni",
                table: "AddInsuranceModel");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "AddInsuranceModel");

            migrationBuilder.DropColumn(
                name: "Ulice",
                table: "AddInsuranceModel");

            migrationBuilder.CreateTable(
                name: "NewInsuredModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jmeno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prijmeni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ulice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PSC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewInsuredModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewInsuredModel");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AddInsuranceModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AddInsuranceModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Jmeno",
                table: "AddInsuranceModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mesto",
                table: "AddInsuranceModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PSC",
                table: "AddInsuranceModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prijmeni",
                table: "AddInsuranceModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "AddInsuranceModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ulice",
                table: "AddInsuranceModel",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
