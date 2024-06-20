using System.ComponentModel.DataAnnotations;
namespace FormsApi.data
{
    public class ListofcollagesDetails
    {
        [Key]
        public int Id { get; set; }
        public string UniversityName { get; set; }
        public string CollegeName { get; set; }
        public string CollegeType { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }    
    }
}
