namespace FormsApi.data
{
    public class InterviewerAppointing
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string Round { get; set; }   
        public Guid ApplicantId { get; set; }
        public string EmailId { get; set; } 
    }
}
