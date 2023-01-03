using System.ComponentModel.DataAnnotations;

namespace CallLogSystem.Models
{
    public class CallLog
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Required")]
        public string? Problem { get; set; }

        [Required(ErrorMessage = "Required")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Required")]
        public string? Description { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? IssueDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public string? ReportedBy { get; set; }
        public string? Priority { get; set; }

        [Required(ErrorMessage = "Required")]
        public string? ActionTaken { get; set; }

        [Required(ErrorMessage = "Required")]
        public string? Remarks { get; set; }
        public bool? IsActive { get; set; }
        public bool? IssueResolved { get; set; }
      

    }
}
