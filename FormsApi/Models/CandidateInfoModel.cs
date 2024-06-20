namespace FormsApi.Models
{
    public class CandidateInfoModel
    {
        public Guid? Id { get; set; }   
        public string Date { get; set; }
        public string PositionAppliedFor { get; set; }
        public string ReferredBy { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string CompleteAddress { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string MartalStatus { get; set; }
        public string Reasons { get; set; }
        public string NoticePeriod { get; set; }
        public string ExpectedCTC { get; set; }
        public string DeclarationDate { get; set; }
        public string DeclarationSignature { get; set; }
        public int? years { get; set; }
        public int? month { get; set; }
        public bool? Appoint { get; set; }
        public string? Round { get; set; }
        public string? Statues { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? Pincode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? skills { get; set; }
        public string? github { get; set; }
        public string? LinkedIn { get; set; }
        public string? lastname { get; set; }
        public List<EducationDetailsModel> educationDetails { get; set; }
        public List<FamilyDetailsModel> familyDetails { get; set; }
        public List<ProfessionalReferencevalue> ProfessionalReferenceData { get; set; }
        public List<EmploymentDetailsvalue> EmploymentDetailsData { get; set; }
    }
    public class ProfessionalReferencevalue
    {
        public string Name { get; set; }
        public string Organisation { get; set; }
        public string Designation { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
    }
    public class EmploymentDetailsvalue
    {
        public string? Years { get; set; }
        public string? Months { get; set; }
        public string? Organizations { get; set; }
        public string? Designation { get; set; }
        public string? from { get; set; }
        public string? To { get; set; }
        public string? AnnualCTC { get; set; }
        public string? ReasonForLeaving { get; set; }
    }
}
