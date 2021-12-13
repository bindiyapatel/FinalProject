using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
namespace FinalProject.Models
{
    public class Score
    {

        public int ScoreId { get; set; }
        [DisplayName("User")]
        public int UserId { get; set; }
        [DisplayName("Quiz")]
        public int QuizId { get; set; }
        public int TotalMarks { get; set; }
        public int ObtainedMarks { get; set; }

    }
}
