using System.ComponentModel.DataAnnotations;

namespace LabManagementSystem.Models
{
    public class LabReport
    {
        [Key]
        public int ReportID { get; set; }
        public string? TestType { get; set; }
        public DateTime EnteredTime { get; set; }
        public DateTime TimeofTest { get; set; }
        public string? Results { get; set; }
      //  public Patient Patient{ get; set; }
       

    }
}
