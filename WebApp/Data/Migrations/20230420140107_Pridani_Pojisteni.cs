using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eshop.Data.Migrations
{
    public partial class Pridani_Pojisteni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AddInsuranceModel",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Typ",
                table: "AddInsuranceModel",
                newName: "TypPojisteni");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AddInsuranceModel",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TypPojisteni",
                table: "AddInsuranceModel",
                newName: "Typ");
        }
    }
}
