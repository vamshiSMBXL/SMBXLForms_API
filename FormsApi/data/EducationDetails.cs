namespace FormsApi.data
{
    public class EducationDetails
    {
        public Guid Id { get; set; }    
        public string Degree { get; set; }
        public string Specialization { get; set; }
        public string CollageOrUniversity { get; set; }
        public string YearOfPassing { get; set; }
        public string Percentage { get; set; }
        public Guid? Reference { get; set; }
        public DateTime CretedDate { get; set; } = DateTime.Now;
        public DateTime? Updated { get; set; }
    }
}
