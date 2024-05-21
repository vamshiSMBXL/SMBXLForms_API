using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormsApi.Migrations
{
    public partial class newfeildsintablessss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "InterviewEvaluation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    interViewBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statues = table.Column<int>(type: "int", nullable: false),
                    CandidateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Interviewer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalWorkExperience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelevantExperience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademicQualifications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoursesAndCertifications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TraniningAndInternship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechinalRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalAccomplishments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OverallImpression = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OverallEvaluationAndComment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewEvaluation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterviewEvaluation");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "JoiningForm");
        }
    }
}
