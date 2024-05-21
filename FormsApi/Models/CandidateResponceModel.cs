namespace FormsApi.Models
{
    public class CandidateResponceModel
    {
        public string EmpCode { get; set; }
        public string CandidateId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public string AnswerName { get; set; }
        public bool IsActive { get; set; }
        public string Comments { get; set; }
        public string ECType { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; }
    }
}
