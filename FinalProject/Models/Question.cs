using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Question
    {
        [Required]
        [DisplayName("Quiz Code")]
        public string? QuizCode { set; get; }
        public int QuestionId { set; get; }
        [Required]
        [StringLength(50, MinimumLength = 10)]
        [DisplayName("Question")]
        public string? Content { set; get; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        [DisplayName("Option A")]
        public string? OptionA { set; get; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        [DisplayName("Option B")]
        public string? OptionB { set; get; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        [DisplayName("Option C")]
        public string? Optionc { set; get; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        [DisplayName("Option D")]
        public string? OptionD { set; get; }
        [Required]
        [StringLength(1, MinimumLength = 1)]
        [DisplayName("Correct Answer")]
        public string? CorrectAnswer { set; get; }
    }
}
