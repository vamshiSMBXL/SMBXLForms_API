using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormsApi.Migrations
{
    public partial class Advisorasdasdcasdv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "CandidateInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "CandidateInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "CandidateInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pincode",
                table: "CandidateInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "CandidateInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "CandidateInfo");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "CandidateInfo");

            migrationBuilder.DropColumn(
                name: "City",
                table: "CandidateInfo");

            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "CandidateInfo");

            migrationBuilder.DropColumn(
                name: "State",
                table: "CandidateInfo");
        }
    }
}
