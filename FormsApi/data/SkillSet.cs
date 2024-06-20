using System.ComponentModel.DataAnnotations;

namespace FormsApi.data
{
    public class SkillSet
    {
        [Key]
        public int Id { get; set; }
        public string SkillName { get; set; }    
    }
}
