using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Requirements { get; set; }

        public int DifficultyLevel { get; set; }

        public DateTime? FinishDate { get; set; }

        public DateTime? SubmissionDate { get; set; }


        public Team? Team { get; set; }


        public int? TeamId { get; set; }


        public bool PrivateRecruitment { get; set; }


        public string? RepositoryUrl { get; set; }

        public List<User> Applicants { get; set; }

        public List<Language> Languages { get; set; } 
        public List<Tech> Technologies { get; set; } 
    }
}
