using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string? Name { get; set; }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
    }
}
