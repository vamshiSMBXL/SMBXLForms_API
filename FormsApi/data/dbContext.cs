using FormsApi.Applications.Common.Interface;
using FormsApi.Services;
using Microsoft.EntityFrameworkCore;

namespace FormsApi.data
{
    public partial class dbContext : DbContext, IApplicationDbContext
    {
        public dbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<JoiningForm> JoiningForm { get; set; }
        public virtual DbSet<CandidateEvalution> CandidateEvalution { get; set; }
        public virtual DbSet<CandidateInfo> CandidateInfo { get; set; }
        public virtual DbSet<ExitInterview> ExitInterview { get; set; }
        public virtual DbSet<EducationDetails> EducationDetails { get; set; }
        public virtual DbSet<EmploymentDetails> EmploymentDetails { get; set; }
        public virtual DbSet<FamilyDetails> FamilyDetails { get; set; }
        public virtual DbSet<ProfessionalRefernces> ProfessionalRefernces { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<EmployeeAnswer> EmployeeAnswer { get; set; }
        public virtual DbSet<Forms> Forms { get; set; }
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<InterviewEvaluation> InterviewEvaluation { get; set; }
        public virtual DbSet<ListofcollagesDetails> ListofcollagesDetails { get; set; }
        public virtual DbSet<users> Users { get; set; }
        public virtual DbSet<PositionList> PositionList { get; set; }
        public virtual DbSet<InterviewerAppointing> InterviewerAppointing { get; set; }
        public virtual DbSet<DegreeList> DegreeList { get; set; }
        public virtual DbSet<DegreeSpecialization> DegreeSpecialization { get; set; }
        public virtual DbSet<StateCityList> StateCityList { get; set; }
        public virtual DbSet<SkillSet> SkillSet { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListofcollagesDetails>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<StateCityList>()
                .HasKey(s => s.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
