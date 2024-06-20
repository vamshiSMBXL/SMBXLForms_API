using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormsApi.Migrations
{
    public partial class createddateupdatedintablesda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CretedDate",
                table: "ProfessionalRefernces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "ProfessionalRefernces",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CretedDate",
                table: "FamilyDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "FamilyDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CretedDate",
                table: "EmploymentDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "EmploymentDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CretedDate",
                table: "EducationDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "EducationDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CretedDate",
                table: "CandidateInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "CandidateInfo",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CretedDate",
                table: "ProfessionalRefernces");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "ProfessionalRefernces");

            migrationBuilder.DropColumn(
                name: "CretedDate",
                table: "FamilyDetails");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "FamilyDetails");

            migrationBuilder.DropColumn(
                name: "CretedDate",
                table: "EmploymentDetails");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "EmploymentDetails");

            migrationBuilder.DropColumn(
                name: "CretedDate",
                table: "EducationDetails");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "EducationDetails");

            migrationBuilder.DropColumn(
                name: "CretedDate",
                table: "CandidateInfo");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "CandidateInfo");
        }
    }
}
