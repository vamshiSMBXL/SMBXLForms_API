namespace FormsApi.data
{
    public class ProfessionalRefernces
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Organisation { get; set; }
        public string Designation { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
        public Guid? Reference { get; set; }
    }
}
