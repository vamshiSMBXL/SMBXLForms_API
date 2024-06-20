namespace FormsApi.data
{
    public class CandidateInfo
    {
        public Guid ID { get; set; }
        public string Date { get; set; }
        public string PositionAppliedFor { get; set; }
        public string? ReferredBy { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string CompleteAddress { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string MartalStatus { get; set; }
        public string? Reasons { get; set; }
        public string? NoticePeriod { get; set; }
        public string? ExpectedCTC { get; set; }
        public string DeclarationDate { get; set; }
        public string DeclarationSignature { get; set; }
        public int? years { get;set; }
        public int? month { get; set; }
        public bool? Appoint { get; set; }  
        public string? Round { get;set; }
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

    }
}
