using System.ComponentModel.DataAnnotations;

namespace FormsApi.data
{
    public class StateCityList
    {
        [Key]
        public int Id { get; set; } 
        public string NameOfCity { get; set; }
        public string State { get; set; } 

    }
}
