namespace FormsApi.data
{
    public class InterviewEvaluation
    {
        public Guid Id { get; set; }
        public string Date { get; set; }
        public string interViewBy { get; set; }
        public int Statues { get; set; }
        public string CandidateName { get; set; }
        public string Interviewer { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string TotalWorkExperience { get; set; }
        public string RelevantExperience { get; set; }
        public string AcademicQualifications { get; set; }
        public string CoursesAndCertifications { get; set; }    
        public string TraniningAndInternship { get; set; }
        public string TechinalRating { get; set; }
        public string PersonalAccomplishments { get; set; }
        public string OverallImpression { get; set; }
        public string OverallEvaluationAndComment { get; set; }
    }
}
