using Microsoft.AspNetCore.Mvc;
using FormsApi.Applications.Forms.Command;
using FormsApi.Applications.Common.Interface;
using FormsApi.data;
using FormsApi.Models;
using FormsApi.Applications.Common.Models;
using MediatR;

namespace FormsApi.Controllers
{
    public class FormsController : BaseApiController
    {
        private readonly IApplicationDbContext _context;
        private readonly ISeqIdGenerator _seqIdGenerator;
        public FormsController(IApplicationDbContext context, ISeqIdGenerator seqIdGenerator)
        {
            _context = context;
            _seqIdGenerator = seqIdGenerator;
        }

        [HttpPost("AddNewJoining")]
        public async Task<ActionResult<bool>> AddJoinee(JoineeDataModel request, CancellationToken cancellationToken)
        {
            JoiningForm data = new JoiningForm();
            data.Id = _seqIdGenerator.Id;
            data.Name = request.Name;
            data.FatherName = request.FatherName;
            data.CorrespondenceAddress = request.CorrespondenceAddress;
            data.PermanentAddress = request.CorrespondenceAddress;
            data.MobileNumber = request.MobileNumber;
            data.EmailId = request.EmailId;
            data.Dateofbirth = request.Dateofbirth;
            data.Gender = request.Gender;
            data.Dateofjoining = request.Dateofjoining;
            data.Designation = request.Designation;
            data.Department = request.Department;
            data.BloodGroup = request.BloodGroup;
            data.MaritalStatus = request.MaritalStatus;
            data.age = request.age;
            data.AdhaarCard = request.AdhaarCard;
            data.UanPf = request.UanPf;
            data.PanCardNo = request.PanCardNo;
            if (request.PassportFlag == "1")
            {
                data.PassportFlag = true;
            }
            else
            {
                data.PassportFlag = false;
            }
            data.PassportNo = request.PassportNo;
            data.PlaceOfIssue = request.PlaceOfIssue;
            data.IssuedOn = request.IssuedOn;
            data.ValidUpto = request.ValidUpto;
            data.EmergencyContactName = request.EmergencyContactName;
            data.EmergencyContactRelation = request.EmergencyContactRelation;
            data.ContactNo = request.ContactNo;
            data.ExistBank = request.ExistBank;
            data.AccountNumber = request.AccountNumber;
            data.IFSCcode = request.IFSCcode;
            data.Branch = request.Branch;
            data.DeclarationDate = request.DeclarationDate;
            data.DeclarationPlace = request.DeclarationPlace;
            data.DeclarationSignature = request.DeclarationSignature;

            _context.JoiningForm.Add(data);
            _context.SaveChanges();

            EducationDetails educationDetails = new EducationDetails();
            foreach (var item in request.educationDetails)
            {
                educationDetails.Id = _seqIdGenerator.Id;
                educationDetails.Degree = item.Degree;
                educationDetails.Specialization = item.Specialization;
                educationDetails.CollageOrUniversity = item.CollageOrUniversity;
                educationDetails.YearOfPassing = item.YearOfPassing;
                educationDetails.Percentage = item.Percentage;
                educationDetails.Reference = data.Id;

                _context.EducationDetails.Add(educationDetails);
                _context.SaveChanges();
            }
            FamilyDetails familyDetails = new FamilyDetails();
            foreach (var item in request.familyDetails)
            {
                familyDetails.Id = _seqIdGenerator.Id;
                familyDetails.Name = item.Name;
                familyDetails.RelationShip = item.RelationShip;
                familyDetails.Occupation = item.Occupation;
                familyDetails.DateOfBirth = item.DateOfBirth;
                familyDetails.Reference = data.Id;

                _context.FamilyDetails.Add(familyDetails);
                _context.SaveChanges();
            }
            EmploymentDetails employmentDetails = new EmploymentDetails();
            foreach (var item in request.EmploymentDetailsData)
            {
                employmentDetails.Id = _seqIdGenerator.Id;
                employmentDetails.Years = item.Years;
                employmentDetails.Months = item.Months;
                employmentDetails.Organizations = item.Organizations;
                employmentDetails.Designation = item.Designation;
                employmentDetails.from = item.from;
                employmentDetails.To = item.To;
                employmentDetails.AnnualCTC = item.AnnualCTC;
                employmentDetails.ReasonForLeaving = item.ReasonForLeaving;
                employmentDetails.Reference = data.Id;

                _context.EmploymentDetails.Add(employmentDetails);
                _context.SaveChanges();
            }
            ProfessionalRefernces professionalRefernces = new ProfessionalRefernces();
            foreach (var item in request.ProfessionalReferenceData)
            {
                professionalRefernces.Id = _seqIdGenerator.Id;
                professionalRefernces.Name = item.Name;
                professionalRefernces.Organisation = item.Organisation;
                professionalRefernces.Designation = item.Designation;
                professionalRefernces.ContactNo = item.ContactNo;
                professionalRefernces.EmailId = item.EmailId;
                professionalRefernces.Reference = data.Id;

                _context.ProfessionalRefernces.Add(professionalRefernces);
                _context.SaveChanges();
            }

            return Ok(true);
        }
        //[HttpPost("EducationDetails")]
        //public async Task<ActionResult<bool>> AddEducationDetails(List<EducationDetailsModel> request, CancellationToken cancellationToken)
        //{
        //    EducationDetails data = new EducationDetails();
        //    foreach(var item in request) 
        //    {
        //        data.Id = _seqIdGenerator.Id;
        //        data.Degree = item.Degree;
        //        data.Specialization = item.Specialization;
        //        data.CollageOrUniversity = item.CollageOrUniversity;
        //        data.YearOfPassing = item.YearOfPassing;
        //        data.Percentage = item.Percentage;

        //        _context.EducationDetails.Add(data);
        //        _context.SaveChanges();
        //    }

        //    return Ok(true);
        //}
        //[HttpPost("FamilyDetails")]
        //public async Task<ActionResult<bool>> AddFamilyDetails(FamilyDetailsModel request
        //    , CancellationToken cancellationToken)
        //{
        //    FamilyDetails data = new FamilyDetails();
        //    data.Id = _seqIdGenerator.Id;
        //    data.Name = request.Name;
        //    data.RelationShip = request.RelationShip;
        //    data.DateOfBirth = request.DateOfBirth;
        //    data.Occupation = request.Occupation;

        //    _context.FamilyDetails.Add(data);
        //    _context.SaveChanges();

        //    return Ok(true);
        //}
        [HttpPost("CandidateInfo")]
        public async Task<ActionResult<bool>> AddCandidateInfo(CandidateInfoModel request, CancellationToken cancellationToken)
        {
            CandidateInfo data = new CandidateInfo();
            data.ID = _seqIdGenerator.Id;
            data.Date = request.Date;
            data.ReferredBy = request.ReferredBy;
            data.PositionAppliedFor = request.PositionAppliedFor;
            data.Name = request.Name;
            data.DateOfBirth = request.DateOfBirth;
            data.CompleteAddress = request.CompleteAddress;
            data.MobileNumber = request.MobileNumber;
            data.EmailId = request.EmailId;
            data.MartalStatus = request.MartalStatus;
            data.Reasons = request.Reasons;
            data.NoticePeriod = request.NoticePeriod;
            data.ExpectedCTC = request.ExpectedCTC;
            data.DeclarationDate = request.DeclarationDate;
            data.DeclarationSignature = request.DeclarationSignature;

            _context.CandidateInfo.Add(data);
            _context.SaveChanges();

            EducationDetails educationDetails = new EducationDetails();
            foreach (var item in request.educationDetails)
            {
                educationDetails.Id = _seqIdGenerator.Id;
                educationDetails.Degree = item.Degree;
                educationDetails.Specialization = item.Specialization;
                educationDetails.CollageOrUniversity = item.CollageOrUniversity;
                educationDetails.YearOfPassing = item.YearOfPassing;
                educationDetails.Percentage = item.Percentage;
                educationDetails.Reference = data.ID;

                _context.EducationDetails.Add(educationDetails);
                _context.SaveChanges();
            }
            FamilyDetails familyDetails = new FamilyDetails();
            foreach (var item in request.familyDetails)
            {
                familyDetails.Id = _seqIdGenerator.Id;
                familyDetails.Name = item.Name;
                familyDetails.RelationShip = item.RelationShip;
                familyDetails.Occupation = item.Occupation;
                familyDetails.DateOfBirth = item.DateOfBirth;
                familyDetails.Reference = data.ID;

                _context.FamilyDetails.Add(familyDetails);
                _context.SaveChanges();
            }
            EmploymentDetails employmentDetails = new EmploymentDetails();
            foreach (var item in request.EmploymentDetailsData)
            {
                employmentDetails.Id = _seqIdGenerator.Id;
                employmentDetails.Years = item.Years;
                employmentDetails.Months = item.Months;
                employmentDetails.Organizations = item.Organizations;
                employmentDetails.Designation = item.Designation;
                employmentDetails.from = item.from;
                employmentDetails.To = item.To;
                employmentDetails.AnnualCTC = item.AnnualCTC;
                employmentDetails.ReasonForLeaving = item.ReasonForLeaving;
                employmentDetails.Reference = data.ID;

                _context.EmploymentDetails.Add(employmentDetails);
                _context.SaveChanges();
            }
            ProfessionalRefernces professionalRefernces = new ProfessionalRefernces();
            foreach (var item in request.ProfessionalReferenceData)
            {
                professionalRefernces.Id = _seqIdGenerator.Id;
                professionalRefernces.Name = item.Name;
                professionalRefernces.Organisation = item.Organisation;
                professionalRefernces.Designation = item.Designation;
                professionalRefernces.ContactNo = item.ContactNo;
                professionalRefernces.EmailId = item.EmailId;
                professionalRefernces.Reference = data.ID;

                _context.ProfessionalRefernces.Add(professionalRefernces);
                _context.SaveChanges();
            }

            return Ok(true);
        }
        [HttpPost("CandidateEvalutionForm")]
        public async Task<ActionResult<bool>> CandidateEvalutionData(CandidateEvalutionModel request, CancellationToken cancellationToken)
        {
            CandidateEvalution data = new CandidateEvalution();
            data.ID = _seqIdGenerator.Id;
            data.CandidateName = request.CandidateName;
            data.PresentDate = request.PresentDate;
            data.InterviewerName = request.InterviewerName;
            data.CommunicationSkillone = request.CommunicationSkillone.ToString();
            data.TechnicalKnowledgeone = request.TechnicalKnowledgeone.ToString();
            data.SimilarIndustryExperienceone = request.SimilarIndustryExperienceone.ToString();
            data.AlignmentWithOurBussinessone = request.AlignmentWithOurBussinessone.ToString();
            data.Attitudeone = request.Attitudeone.ToString();
            data.Presentabilityone = request.Presentabilityone.ToString();
            data.TeamPlayerone = request.TeamPlayerone.ToString();
            data.ProblemSolvingSkillsone = request.ProblemSolvingSkillsone.ToString();
            data.LeaderShipone = request.LeaderShipone.ToString();
            data.Innovativeone = request.Innovativeone.ToString();
            data.CommunicationSkilltwo = request.CommunicationSkilltwo.ToString();
            data.TechnicalKnowledgetwo = request.TechnicalKnowledgetwo.ToString();
            data.SimilarIndustryExperiencetwo = request.SimilarIndustryExperiencetwo.ToString();
            data.AlignmentWithOurBussinesstwo = request.AlignmentWithOurBussinesstwo.ToString();
            data.Attitudetwo = request.Attitudetwo.ToString();
            data.Presentabilitytwo = request.Presentabilitytwo.ToString();
            data.TeamPlayertwo = request.TeamPlayertwo.ToString();
            data.ProblemSolvingSkillstwo = request.ProblemSolvingSkillstwo.ToString();
            data.LeaderShiptwo = request.LeaderShiptwo.ToString();
            data.Innovativetwo = request.Innovativetwo.ToString();
            data.OverallEvaluation = request.OverallEvaluation.ToString();
            data.AreaOfImprovement = request.AreaOfImprovement;
            data.feedbackObservation = request.feedbackObservation;
            data.Rating = request.Rating;
            data.CandidateStatues = request.CandidateStatues;
            data.Signature = request.Signature;
            data.Date = request.Date;

            _context.CandidateEvalution.Add(data);
            _context.SaveChanges();

            return Ok(true);
        }
        [HttpPost("InterviewEvaluationForm")]
        public async Task<ActionResult<bool>> InterviewEvaluation(InterviewEvaluationModel request, CancellationToken cancellationToken)
        {
            InterviewEvaluation data = new InterviewEvaluation();
            data.Id = _seqIdGenerator.Id;
            data.Date = request.Date;
            data.interViewBy = request.interViewBy;
            data.Statues = request.Statues;
            data.CandidateName = request.CandidateName;
            data.Interviewer = request.Interviewer;
            data.Position = request.Position;
            data.Department = request.Department;
            data.TotalWorkExperience = request.TotalWorkExperience;
            data.RelevantExperience = request.RelevantExperience;
            data.AcademicQualifications = request.AcademicQualifications;
            data.CoursesAndCertifications = request.CoursesAndCertifications;
            data.TraniningAndInternship = request.TraniningAndInternship;
            data.TechinalRating = request.TechinalRating;
            data.PersonalAccomplishments = request.PersonalAccomplishments;
            data.OverallImpression = request.OverallImpression;
            data.OverallEvaluationAndComment = request.OverallEvaluationAndComment;

            _context.InterviewEvaluation.Add(data);
            _context.SaveChanges();


            EmployeeAnswer answer = new EmployeeAnswer();
            foreach (var item in request.intervieweeAnswers)
            {
                answer.ID = _seqIdGenerator.Id;
                answer.EmpCode = item.EmpCode;
                answer.QuestionId = item.QuestionId;
                answer.AnswerId = item.AnswerId;
                answer.AnswerName = item.AnswerName;
                answer.IsActive = item.IsActive;
                answer.Comments = item.Comments;
                answer.ECType = item.ECType;
                answer.CreatedDate = item.CreatedDate;
                answer.FormId = item.FormId;
                answer.ReferenceId = data.Id;



                _context.EmployeeAnswer.Add(answer);
                _context.SaveChanges();

            }


            return Ok(true);

        }
        //[HttpPost("CandidateResponce")]
        //public async Task<ActionResult<bool>> Candidateresponcedata(CandidateResponceModel request, CancellationToken cancellationToken)
        //{
        //    EmployeeAnswer data = new EmployeeAnswer();
        //    data.ID = new Guid();
        //    data.CandidateId = request.CandidateId;
        //    data.QuestionId = request.QuestionId;
        //    data.AnswerName = request.AnswerName;
        //    data.AnswerId = request.AnswerId;
        //    data.IsActive = request.IsActive;
        //    data.Comments = request.Comments;
        //    data.ECType = request.ECType;
        //    data.CreatedDate = DateTime.Now;
        //    data.UpdatedDate = DateTime.Now;

        //    _context.EmployeeAnswer.Add(data);
        //    _context.SaveChanges();

        //    return Ok(true);
        //}
        [HttpGet("CandidateEvalutionFormPreview")]
        public async Task<ActionResult<CandidateEvalutionModel>> CandidateEvalutionFormPreview(string name, CancellationToken cancellationToken)
         {
            var data = _context.CandidateEvalution.FirstOrDefault(x => x.CandidateName == name);
            CandidateEvalutionModel response = new CandidateEvalutionModel();
            if (data != null)
            {
                response.CandidateName = data.CandidateName;
                response.PresentDate = data.PresentDate;
                response.InterviewerName = data.InterviewerName;
                response.CommunicationSkillone = int.Parse(data.CommunicationSkillone);
                response.TechnicalKnowledgeone = int.Parse(data.TechnicalKnowledgeone);
                response.SimilarIndustryExperienceone = int.Parse(data.SimilarIndustryExperienceone);
                response.AlignmentWithOurBussinessone = int.Parse(data.AlignmentWithOurBussinessone);
                response.Attitudeone = int.Parse(data.Attitudeone);
                response.Presentabilityone = int.Parse(data.Presentabilityone);
                response.TeamPlayerone = int.Parse(data.TeamPlayerone);
                response.ProblemSolvingSkillsone = int.Parse(data.ProblemSolvingSkillsone);
                response.LeaderShipone = int.Parse(data.LeaderShipone);
                response.Innovativeone = int.Parse(data.Innovativeone);
                response.CommunicationSkilltwo = int.Parse(data.CommunicationSkilltwo);
                response.TechnicalKnowledgetwo = int.Parse(data.TechnicalKnowledgetwo);
                response.SimilarIndustryExperiencetwo = int.Parse(data.SimilarIndustryExperiencetwo);
                response.AlignmentWithOurBussinesstwo = int.Parse(data.AlignmentWithOurBussinesstwo);
                response.Attitudetwo = int.Parse(data.Attitudetwo);
                response.Presentabilitytwo = int.Parse(data.Presentabilitytwo);
                response.TeamPlayertwo = int.Parse(data.TeamPlayertwo);
                response.ProblemSolvingSkillstwo = int.Parse(data.ProblemSolvingSkillstwo);
                response.LeaderShiptwo = int.Parse(data.LeaderShiptwo);
                response.Innovativetwo = int.Parse(data.Innovativetwo);
                response.OverallEvaluation = int.Parse(data.OverallEvaluation);
                response.AreaOfImprovement = data.AreaOfImprovement;
                response.feedbackObservation = data.feedbackObservation;
                response.Rating = data.Rating;
                response.CandidateStatues = data.CandidateStatues;
                response.Signature = data.Signature;
                response.Date = data.Date;

            }

            return Ok(response);
        }

        [HttpPost("AddExitinterview")]
        public async Task<ActionResult<bool>> AddExitinterviewdata(ExitInterviewModel request, CancellationToken cancellationToken)
        {
            try
            {
                if (request != null)
                {
                    ExitInterview data = new ExitInterview();
                    data.id = _seqIdGenerator.Id;
                    data.Name = request.Name;
                    data.EmployeeCode = request.EmployeeCode;
                    data.Designation = request.Designation;
                    data.StartDateWithOrganization = request.StartDateWithOrganization;
                    data.DateOfResignation = request.DateOfResignation;
                    data.SeparationDate = request.SeparationDate;
                    data.TotalLengthOfService = request.TotalLengthOfService;
                    data.FormFillDate = request.FormFillDate;
                    data.Signature = request.Signature;

                    _context.ExitInterview.Add(data);
                    _context.SaveChanges();



                    EmployeeAnswer answer = new EmployeeAnswer();
                    foreach (var item in request.EmployeeAnswerList)
                    {
                        answer.ID = _seqIdGenerator.Id;
                        answer.EmpCode = item.EmpCode;
                        answer.QuestionId = item.QuestionId;
                        answer.AnswerId = item.AnswerId;
                        answer.AnswerName = item.AnswerName;
                        answer.IsActive = item.IsActive;
                        answer.Comments = item.Comments;
                        answer.ECType = item.ECType;
                        answer.CreatedDate = item.CreatedDate;
                        answer.FormId = item.FormId;
                        answer.ReferenceId = data.id;



                        _context.EmployeeAnswer.Add(answer);
                        _context.SaveChanges();

                    }
                    return Ok(true);
                }
                else
                {
                    return BadRequest("Empty Data");
                }
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.ToString());   
            }

        }
    }
}
