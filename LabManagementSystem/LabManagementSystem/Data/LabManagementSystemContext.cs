using LabManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LabManagementSystem.Data
{
    public class LabManagementSystemContext : DbContext
    {
        public LabManagementSystemContext(DbContextOptions<LabManagementSystemContext> options) : base(options)
        {
            
        }
        public DbSet<Patient> patients { get; set; }
        public DbSet<LabReport> labReports { get; set; }
    }
}
