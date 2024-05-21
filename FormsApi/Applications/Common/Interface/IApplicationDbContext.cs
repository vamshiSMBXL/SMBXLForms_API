﻿using FormsApi.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data;

namespace FormsApi.Applications.Common.Interface
{
    public interface IApplicationDbContext
    {
        DbSet<JoiningForm> JoiningForm { get; set; }
        DbSet<EducationDetails> EducationDetails { get; set; }
        DbSet<ProfessionalRefernces> ProfessionalRefernces { get; set; }
        DbSet<FamilyDetails> FamilyDetails { get; set; }
        DbSet<CandidateInfo> CandidateInfo { get; set; }

        DbSet<ExitInterview> ExitInterview { get; set; }
        DbSet<CandidateEvalution> CandidateEvalution { get; set; }
        DbSet<InterviewEvaluation> InterviewEvaluation { get; set; }
        DbSet<EmployeeAnswer> EmployeeAnswer { get; set; }

        DbSet<EmploymentDetails> EmploymentDetails { get; set; }
        int SaveChanges();
    }
}
