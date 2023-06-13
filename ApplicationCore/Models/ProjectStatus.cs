using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class ProjectStatus
    {

        public int ProjectStatusId { get; set; }

        public Project? Project { get; set; }


        public Status? Status { get; set; }


        public int? ProjectId { get; set; }

        public int? StatusId { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
