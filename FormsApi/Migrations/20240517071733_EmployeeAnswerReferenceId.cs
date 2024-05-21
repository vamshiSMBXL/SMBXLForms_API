using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormsApi.Migrations
{
    public partial class EmployeeAnswerReferenceId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "EmployeeAnswer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReferenceId",
                table: "EmployeeAnswer",
                type: "uniqueidentifier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormId",
                table: "EmployeeAnswer");

            migrationBuilder.DropColumn(
                name: "ReferenceId",
                table: "EmployeeAnswer");
        }
    }
}
