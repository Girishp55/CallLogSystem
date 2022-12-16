using System.ComponentModel.DataAnnotations;

namespace CallLogSystem.Models
{
    public class CallLog
    {
        public int Id { get; set; }
        public string? Problem { get; set; }
        public string? Location { get; set; } 
        public string? Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? IssueDate { get; set; }
        public string? ReportedBy { get; set; }
        public string? Priority { get; set; }

        public string? ActionTaken { get; set; }
        public string? Remarks { get; set; }
        public bool IsActive { get; set; }
        public bool? IssueResolved { get; set; }
      

    }
}
