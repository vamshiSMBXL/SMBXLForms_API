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
    }
}
