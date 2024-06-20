using Microsoft.AspNetCore.Mvc;
using FormsApi.Applications.Forms.Command;
using FormsApi.Applications.Common.Interface;
using FormsApi.data;
using FormsApi.Models;
using FormsApi.Applications.Common.Models;
using MediatR;
using System.IO;
using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

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

        [HttpPost("CandidateInfo")]
        public async Task<ActionResult<bool>> AddCandidateInfo(CandidateInfoModel request, CancellationToken cancellationToken)
        {
            CandidateInfo data = new CandidateInfo();
            data.ID = _seqIdGenerator.Id;
            data.Date = request.Date;
            data.ReferredBy = request.ReferredBy;
            data.PositionAppliedFor = request.PositionAppliedFor;
            data.Name = request.Name;
            data.lastname = request.lastname;
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
            data.Appoint = request.Appoint;
            data.AddressLine1 = request.AddressLine1;
            data.AddressLine2 = request.AddressLine2;
            data.Pincode = request.Pincode;
            data.City = request.City;
            data.skills = request.skills;
            data.github = request.github;
            data.LinkedIn = request.LinkedIn;

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
                educationDetails.CretedDate = DateTime.Now;

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
                familyDetails.CretedDate = DateTime.Now;

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
                employmentDetails.CretedDate = DateTime.Now;
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
                professionalRefernces.CretedDate = DateTime.Now;
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
            //data.CommunicationSkilltwo = request.CommunicationSkilltwo.ToString();
            //data.TechnicalKnowledgetwo = request.TechnicalKnowledgetwo.ToString();
            //data.SimilarIndustryExperiencetwo = request.SimilarIndustryExperiencetwo.ToString();
            //data.AlignmentWithOurBussinesstwo = request.AlignmentWithOurBussinesstwo.ToString();
            //data.Attitudetwo = request.Attitudetwo.ToString();
            //data.Presentabilitytwo = request.Presentabilitytwo.ToString();
            //data.TeamPlayertwo = request.TeamPlayertwo.ToString();
            //data.ProblemSolvingSkillstwo = request.ProblemSolvingSkillstwo.ToString();
            //data.LeaderShiptwo = request.LeaderShiptwo.ToString();
            //data.Innovativetwo = request.Innovativetwo.ToString();
            //data.OverallEvaluation = request.OverallEvaluation.ToString();
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
                //response.CommunicationSkilltwo = int.Parse(data.CommunicationSkilltwo);
                //response.TechnicalKnowledgetwo = int.Parse(data.TechnicalKnowledgetwo);
                //response.SimilarIndustryExperiencetwo = int.Parse(data.SimilarIndustryExperiencetwo);
                //response.AlignmentWithOurBussinesstwo = int.Parse(data.AlignmentWithOurBussinesstwo);
                //response.Attitudetwo = int.Parse(data.Attitudetwo);
                //response.Presentabilitytwo = int.Parse(data.Presentabilitytwo);
                //response.TeamPlayertwo = int.Parse(data.TeamPlayertwo);
                //response.ProblemSolvingSkillstwo = int.Parse(data.ProblemSolvingSkillstwo);
                //response.LeaderShiptwo = int.Parse(data.LeaderShiptwo);
                //response.Innovativetwo = int.Parse(data.Innovativetwo);
                //response.OverallEvaluation = int.Parse(data.OverallEvaluation);
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

        [HttpPost("SavePhoto")]
        public IActionResult SavePhoto([FromForm] FileModel fileModel, [FromServices] IWebHostEnvironment env)
        {
            string folderPath = Path.Combine(env.ContentRootPath, "Photos");

            try
            {
                // Ensure the directory exists
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    Console.WriteLine("Directory created at: " + folderPath);
                }

                // Create a file path for the uploaded file
                string filePath = Path.Combine(folderPath, fileModel.file.FileName);

                // Save the file to the specified path
                using (Stream stream = new FileStream(filePath, FileMode.Create))
                {
                    fileModel.file.CopyTo(stream);
                }

                return Ok(new { message = "Image saved successfully" });
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error: Access to the path is denied. " + ex.Message);
                return StatusCode(500, "Access to the path is denied.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return StatusCode(500, "An error occurred while saving the image.");
            }
        }
        [HttpGet("GetCollageList")]
        public async Task<ActionResult<List<ListofcollagesDetails>>> GetCollageListData()
        {
            List<ListofcollagesDetails> data = new List<ListofcollagesDetails>();
            data = _context.ListofcollagesDetails.ToList();
            return Ok(data);
        }
        public class FileModel
        {
            public string FileName { get; set; }
            public IFormFile file { get; set; }
        }

        [HttpGet("GetAllCandidateData")]
        public async Task<ActionResult<List<CandidateInfoModel>>> GetAllCandidates()
        {
            // Step 1: Query each related entity separately
            var candidates = _context.CandidateInfo.ToList();
            var educationDetails = _context.EducationDetails.ToList();
            var familyDetails = _context.FamilyDetails.ToList();
            var professionalReferences = _context.ProfessionalRefernces.ToList();
            var employmentDetails = _context.EmploymentDetails.ToList();

            // Step 2: Combine the results in-memory using LINQ
            var data = candidates.Select(c => new CandidateInfoModel
            {
                Id = c.ID,
                Date = c.Date,
                PositionAppliedFor = c.PositionAppliedFor,
                ReferredBy = c.ReferredBy,
                Name = c.Name,
                DateOfBirth = c.DateOfBirth,
                //CompleteAddress = c.CompleteAddress,
                MobileNumber = c.MobileNumber,
                EmailId = c.EmailId,
                MartalStatus = c.MartalStatus,
                Reasons = c.Reasons,
                NoticePeriod = c.NoticePeriod,
                ExpectedCTC = c.ExpectedCTC,
                DeclarationDate = c.DeclarationDate,
                DeclarationSignature = c.DeclarationSignature,
                years = c.years,
                month = c.month,
                educationDetails = educationDetails.Where(ed => ed.Reference == c.ID).Select(ed => new EducationDetailsModel
                {
                    // Add mapping of properties here
                    Degree = ed.Degree,
                    Specialization = ed.Specialization,
                    CollageOrUniversity = ed.CollageOrUniversity,
                    YearOfPassing = ed.YearOfPassing,
                    Percentage = ed.Percentage,
                }).ToList(),
                familyDetails = familyDetails.Where(fd => fd.Reference == c.ID).Select(fd => new FamilyDetailsModel
                {
                    // Add mapping of properties here
                    Name = fd.Name,
                    RelationShip = fd.RelationShip,
                    DateOfBirth = fd.DateOfBirth,
                    Occupation = fd.Occupation
                }).ToList(),
                ProfessionalReferenceData = professionalReferences.Where(pr => pr.Reference == c.ID).Select(pr => new ProfessionalReferencevalue
                {
                    Name = pr.Name,
                    Organisation = pr.Organisation,
                    Designation = pr.Designation,
                    ContactNo = pr.ContactNo,
                    EmailId = pr.EmailId
                }).ToList(),
                EmploymentDetailsData = employmentDetails.Where(em => em.Reference == c.ID).Select(em => new EmploymentDetailsvalue
                {
                    Years = em.Years,
                    Months = em.Months,
                    Organizations = em.Organizations,
                    Designation = em.Designation,
                    from = em.from,
                    To = em.To,
                    AnnualCTC = em.AnnualCTC,
                    ReasonForLeaving = em.ReasonForLeaving
                }).ToList()
            }).ToList();


            return Ok(data);
        }


        [HttpPost("dataentryforPositionList")]
        public async Task<ActionResult<bool>> dataentry(string role, int Id)
        {
            PositionList data = new PositionList();
            data.Id = _seqIdGenerator.Id;   
            data.DesignationName = role;
            data.roleId = Id;

            _context.PositionList.Add(data);
            _context.SaveChanges();
            return Ok(data);
        }
        [HttpGet("GetAllPositions")]
        public async Task<ActionResult<List<PositionList>>> getallpoitionsdata()
        {
            List<PositionList> data = new List<PositionList>();
            data = _context.PositionList.ToList();
            return Ok(data);
        }

        [HttpGet("Interviewerlist")]
        public async Task<ActionResult<List<users>>> getAllUsers()
        {
            List<users> data = new List<users>();
            data = _context.Users.ToList();
            return Ok(data);
        }
        [HttpPost("DataEnterForDegreeSpecialization")]
        public async Task<ActionResult<bool>> DataEntryValues(string degreename, int Id)
        {
            DegreeSpecialization data = new DegreeSpecialization();
            data.Id = _seqIdGenerator.Id;
            data.SpecializationName = degreename;
            data.DegreeId = Id;

            _context.DegreeSpecialization.Add(data);
            _context.SaveChanges(); 

            return Ok(data);
        }
        [HttpPost("DataEntrydegreeList")]
        public async Task<ActionResult<bool>> DataentryDegreeList(string degreename,int id)
        {
            DegreeList data = new DegreeList();
            data.Id = _seqIdGenerator.Id;
            data.degree = degreename;
            data.degreeId = id;
            _context.DegreeList.Add(data);
            _context.SaveChanges();
            return Ok(true);
        }
        [HttpGet("DegreeList")]
        public async Task<ActionResult<List<DegreeList>>> GetDegreeList()
        {
            List<DegreeList> data = new List<DegreeList>();
            data = _context.DegreeList.ToList();
            return data;
        }

        [HttpGet("DegreeSpecializationList")]
        public async Task<ActionResult<List<DegreeSpecialization>>> GetDegreeSpecialization()
        {
            List<DegreeSpecialization> data = new List<DegreeSpecialization>();
            data = _context.DegreeSpecialization.ToList();
            return data;
        }
        [HttpGet("ListOfstate")]
        public async Task<ActionResult<List<string >>> GetListOfStateAndCity()
        {
            var statelist = _context.StateCityList.Select( s => s.State).Distinct().ToList();

            return statelist;
        }
        [HttpGet("ListofCitysandStates")]
        public async Task<ActionResult<List<StateCityList>>> GetListofCitysandStates()
        {
            List<StateCityList> data = new List<StateCityList>();
            data = _context.StateCityList.ToList();
            return data;

        }
        [HttpPost("Skillsetdataentry")]
        public async Task<ActionResult<bool>> dataentryskillset(string skillset)
        {
            SkillSet data = new SkillSet();
            data.SkillName = skillset;

            _context.SkillSet.Add(data);
            _context.SaveChanges();
            return Ok(true);
        }
        [HttpGet("Getskillset")]
        public async Task<ActionResult<List<SkillSet>>> getSkillSetData()
        {
            List<SkillSet> data = new List<SkillSet>();
            data = _context.SkillSet.ToList();
            return Ok(data);    
        }
    }
}
