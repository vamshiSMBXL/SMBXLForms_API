namespace FormsApi.data
{
    public class FamilyDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string RelationShip { get; set; }
        public string DateOfBirth { get; set; }
        public string Occupation { get; set; }
        public Guid? Reference { get; set; }
    }
}
