using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FormsApi.data
{
    public class Forms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int FormId { get; set; }
        public string FormText { get; set; }
        public bool IsAtive { get; set; }
        public DateTime CretedDate { get; set; } = DateTime.Now;
        public DateTime? Updated { get; set; } 
    }
}
