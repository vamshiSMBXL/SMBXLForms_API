using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormsApi.Migrations
{
    public partial class AppointRoundStatuesCouloums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Appoint",
                table: "CandidateInfo",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round",
                table: "CandidateInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Statues",
                table: "CandidateInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Appoint",
                table: "CandidateInfo");

            migrationBuilder.DropColumn(
                name: "Round",
                table: "CandidateInfo");

            migrationBuilder.DropColumn(
                name: "Statues",
                table: "CandidateInfo");
        }
    }
}
