using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormsApi.Migrations
{
    public partial class referencedataIDId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Reference",
                table: "ProfessionalRefernces",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Reference",
                table: "FamilyDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Reference",
                table: "EmploymentDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Reference",
                table: "EducationDetails",
                type: "uniqueidentifier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reference",
                table: "ProfessionalRefernces");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "FamilyDetails");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "EmploymentDetails");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "EducationDetails");
        }
    }
}
