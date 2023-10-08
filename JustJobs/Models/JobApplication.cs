using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JustJobs.Models
{
    public class JobApplication
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string JobDescription { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public DateTime ApplicationDate { get; set; }

        // Path to uploaded resume (you might want to store this as a file path or a URL)
        public string ResumePath { get; set; }

        public string Source { get; set; }

        // Status enum for tracking (Pending, Applied, Interview Scheduled, etc.)
        public Status Status { get; set; }
    }

    public enum Status
    {
        Pending,
        Applied,
        InterviewScheduled,
        Offered,
        Rejected,
        OnHold
    }
}
