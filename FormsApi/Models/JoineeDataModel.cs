﻿namespace FormsApi.Models
{
    public class JoineeDataModel
    {
        public string? EMPcode { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string CorrespondenceAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Dateofbirth { get; set; }
        public string Dateofjoining { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string BloodGroup { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string age { get; set; }
        public string AdhaarCard { get; set; }
        public string? UanPf { get; set; }
        public string? PanCardNo { get; set; }
        public string PassportFlag { get; set; }
        public string PassportNo { get; set; }
        public string PlaceOfIssue { get; set; }
        public string IssuedOn { get; set; }
        public string ValidUpto { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactRelation { get; set; }
        public string ContactNo { get; set; }
        public string? ExistBank { get; set; }
        public string AccountNumber { get; set; }
        public string IFSCcode { get; set; }
        public string Branch { get; set; }
        public string DeclarationDate { get; set; }
        public string DeclarationPlace { get; set; }
        public string DeclarationSignature { get; set; }
        public List<EducationDetailsModel> educationDetails { get; set; }
        public List<FamilyDetailsModel> familyDetails { get; set; }
        public List<ProfessionalReferenceData> ProfessionalReferenceData { get; set; }
        public List<EmploymentDetailsData> EmploymentDetailsData { get; set; }
    }
    public class ProfessionalReferenceData
    {
        public string Name { get; set; }
        public string Organisation { get; set; }
        public string Designation { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
    }
    public class EmploymentDetailsData
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
