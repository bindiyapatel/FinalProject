using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FinalProject.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }
        [DisplayName("Quiz Title")]
        public string? QuizTitle { get; set; }
        [DisplayName("Subject")]
        public string? Subject { get; set; }
        [DisplayName("Quiz Code")]
        public string? QuizCode { get; set; }
        public string? IsDelete { get; set; }
    }
}
