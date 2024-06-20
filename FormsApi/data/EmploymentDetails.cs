namespace FormsApi.data
{
    public class EmploymentDetails
    {
        public Guid Id { get; set; }
        public string? Years { get; set; }
        public string? Months { get; set; }
        public string? Organizations { get; set; }
        public string? Designation { get; set; }
        public string? from { get; set; }
        public string? To { get; set; }
        public string? AnnualCTC { get; set; }
        public string? ReasonForLeaving { get; set; }
        public Guid? Reference { get; set; }
        public DateTime CretedDate { get; set; } = DateTime.Now;
        public DateTime? Updated { get; set; }
    }
}
