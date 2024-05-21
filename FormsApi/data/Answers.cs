using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FormsApi.data
{
    public class Answers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }
        public int AnswerId { get; set; }
        public string AnswerName { get; set;}
        public int QuestionId { get; set;}
        public string AnswerType { get; set;}
        public bool IsActive { get; set;}
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set;}
    }
}
