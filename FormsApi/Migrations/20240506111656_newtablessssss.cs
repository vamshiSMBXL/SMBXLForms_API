using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormsApi.Migrations
{
    public partial class newtablessssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdhaarCard",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BloodGroup",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactNo",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Dateofjoining",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeclarationDate",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeclarationPlace",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeclarationSignature",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EMPcode",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactName",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactRelation",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExistBank",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IFSCcode",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IssuedOn",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PanCardNo",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PassportFlag",
                table: "JoiningForm",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PassportNo",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfIssue",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UanPf",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValidUpto",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "age",
                table: "JoiningForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    AnswerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateEvalution",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CandidateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresentDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommunicationSkillone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechnicalKnowledgeone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SimilarIndustryExperienceone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlignmentWithOurBussinessone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attitudeone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Presentabilityone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamPlayerone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProblemSolvingSkillsone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaderShipone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Innovativeone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommunicationSkilltwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechnicalKnowledgetwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SimilarIndustryExperiencetwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlignmentWithOurBussinesstwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attitudetwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Presentabilitytwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamPlayertwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProblemSolvingSkillstwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaderShiptwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Innovativetwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OverallEvaluation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaOfImprovement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    feedbackObservation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CandidateStatues = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateEvalution", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CandidateInfo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionAppliedFor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferredBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompleteAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MartalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reasons = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoticePeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedCTC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeclarationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeclarationSignature = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EducationDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollageOrUniversity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfPassing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percentage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAnswer",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CandidateId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    AnswerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ECType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAnswer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Years = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Months = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Organizations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    from = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnualCTC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForLeaving = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExitInterview",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateWithOrganization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfResignation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeparationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalLengthOfService = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExitInterview", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FamilyDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationShip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    FormText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAtive = table.Column<bool>(type: "bit", nullable: false),
                    CretedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalRefernces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organisation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalRefernces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QusetionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "CandidateEvalution");

            migrationBuilder.DropTable(
                name: "CandidateInfo");

            migrationBuilder.DropTable(
                name: "EducationDetails");

            migrationBuilder.DropTable(
                name: "EmployeeAnswer");

            migrationBuilder.DropTable(
                name: "EmploymentDetails");

            migrationBuilder.DropTable(
                name: "ExitInterview");

            migrationBuilder.DropTable(
                name: "FamilyDetails");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "ProfessionalRefernces");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "AdhaarCard",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "Branch",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "ContactNo",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "Dateofjoining",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "DeclarationDate",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "DeclarationPlace",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "DeclarationSignature",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "EMPcode",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "EmergencyContactName",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "EmergencyContactRelation",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "ExistBank",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "IFSCcode",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "IssuedOn",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "PanCardNo",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "PassportFlag",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "PassportNo",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "PlaceOfIssue",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "UanPf",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "ValidUpto",
                table: "JoiningForm");

            migrationBuilder.DropColumn(
                name: "age",
                table: "JoiningForm");
        }
    }
}
