using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormsApi.Migrations
{
    public partial class removingcloums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlignmentWithOurBussinesstwo",
                table: "CandidateEvalution");

            migrationBuilder.DropColumn(
                name: "Attitudetwo",
                table: "CandidateEvalution");

            migrationBuilder.DropColumn(
                name: "CommunicationSkilltwo",
                table: "CandidateEvalution");

            migrationBuilder.DropColumn(
                name: "Innovativetwo",
                table: "CandidateEvalution");

            migrationBuilder.DropColumn(
                name: "LeaderShiptwo",
                table: "CandidateEvalution");

            migrationBuilder.DropColumn(
                name: "OverallEvaluation",
                table: "CandidateEvalution");

            migrationBuilder.DropColumn(
                name: "Presentabilitytwo",
                table: "CandidateEvalution");

            migrationBuilder.DropColumn(
                name: "ProblemSolvingSkillstwo",
                table: "CandidateEvalution");

            migrationBuilder.DropColumn(
                name: "SimilarIndustryExperiencetwo",
                table: "CandidateEvalution");

            migrationBuilder.DropColumn(
                name: "TeamPlayertwo",
                table: "CandidateEvalution");

            migrationBuilder.DropColumn(
                name: "TechnicalKnowledgetwo",
                table: "CandidateEvalution");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlignmentWithOurBussinesstwo",
                table: "CandidateEvalution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Attitudetwo",
                table: "CandidateEvalution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CommunicationSkilltwo",
                table: "CandidateEvalution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Innovativetwo",
                table: "CandidateEvalution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LeaderShiptwo",
                table: "CandidateEvalution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OverallEvaluation",
                table: "CandidateEvalution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Presentabilitytwo",
                table: "CandidateEvalution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProblemSolvingSkillstwo",
                table: "CandidateEvalution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SimilarIndustryExperiencetwo",
                table: "CandidateEvalution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamPlayertwo",
                table: "CandidateEvalution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TechnicalKnowledgetwo",
                table: "CandidateEvalution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
