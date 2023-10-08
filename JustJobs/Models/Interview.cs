using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JustJobs.Models
{
    public class Interview
    {
        public int Id { get; set; }

        [Required]
        public DateTime InterviewDate { get; set; }

        public string Location { get; set; }

        public string VirtualMeetingLink { get; set; }

        public string InterviewerName { get; set; }

        public string InterviewerEmail { get; set; }

        public string Feedback { get; set; }

        public int JobApplicationId { get; set; }  // Foreign key to associate with JobApplication
        public JobApplication JobApplication { get; set; }
    }
}
