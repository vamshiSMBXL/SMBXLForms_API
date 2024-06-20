﻿// <auto-generated />
using System;
using FormsApi.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FormsApi.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20240606090753_positionListapplied")]
    partial class positionListapplied
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FormsApi.data.Answers", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AnswerId")
                        .HasColumnType("int");

                    b.Property<string>("AnswerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("FormsApi.data.CandidateEvalution", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AlignmentWithOurBussinessone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AreaOfImprovement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Attitudeone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateStatues")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommunicationSkillone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Innovativeone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterviewerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeaderShipone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresentDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Presentabilityone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProblemSolvingSkillsone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SimilarIndustryExperienceone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamPlayerone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechnicalKnowledgeone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("feedbackObservation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CandidateEvalution");
                });

            modelBuilder.Entity("FormsApi.data.CandidateInfo", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompleteAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CretedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeclarationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeclarationSignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpectedCTC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MartalStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoticePeriod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionAppliedFor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reasons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferredBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("month")
                        .HasColumnType("int");

                    b.Property<int?>("years")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("CandidateInfo");
                });

            modelBuilder.Entity("FormsApi.data.EducationDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CollageOrUniversity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CretedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Percentage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Reference")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("YearOfPassing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EducationDetails");
                });

            modelBuilder.Entity("FormsApi.data.EmployeeAnswer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("AnswerId")
                        .HasColumnType("int");

                    b.Property<string>("AnswerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ECType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FormId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ReferenceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("EmployeeAnswer");
                });

            modelBuilder.Entity("FormsApi.data.EmploymentDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnnualCTC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CretedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Months")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organizations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonForLeaving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Reference")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("To")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Years")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("from")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmploymentDetails");
                });

            modelBuilder.Entity("FormsApi.data.ExitInterview", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DateOfResignation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormFillDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeparationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Signature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDateWithOrganization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalLengthOfService")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ExitInterview");
                });

            modelBuilder.Entity("FormsApi.data.FamilyDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CretedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Reference")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RelationShip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("FamilyDetails");
                });

            modelBuilder.Entity("FormsApi.data.Forms", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CretedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<string>("FormText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAtive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("FormsApi.data.InterviewEvaluation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AcademicQualifications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoursesAndCertifications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Interviewer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OverallEvaluationAndComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OverallImpression")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalAccomplishments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelevantExperience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Statues")
                        .HasColumnType("int");

                    b.Property<string>("TechinalRating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalWorkExperience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraniningAndInternship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("interViewBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InterviewEvaluation");
                });

            modelBuilder.Entity("FormsApi.data.JoiningForm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdhaarCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrespondenceAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dateofbirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dateofjoining")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeclarationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeclarationPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeclarationSignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMPcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContactRelation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExistBank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IFSCcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaritalStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PanCardNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PassportFlag")
                        .HasColumnType("bit");

                    b.Property<string>("PassportNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfIssue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UanPf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValidUpto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JoiningForm");
                });

            modelBuilder.Entity("FormsApi.data.ListofcollagesDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CollegeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniversityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ListofcollagesDetails");
                });

            modelBuilder.Entity("FormsApi.data.ProfessionalRefernces", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CretedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organisation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Reference")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProfessionalRefernces");
                });

            modelBuilder.Entity("FormsApi.data.Questions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QusetionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("FormsApi.data.users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
