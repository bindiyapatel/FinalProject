using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FinalProject.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        [DisplayName("Subject Code")]
        public string? SubjectCode { get; set; }
        [DisplayName("Name")]
        public string? Name { get; set; }
        public string? IsActive { get; set; }
        public string? IsDelete { get; set; }

    }
}
