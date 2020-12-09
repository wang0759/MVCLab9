using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab9.Models.DataAccess
{
    public partial class AcademicRecord
    {
        
        public string CourseCode { get; set; }
        public string StudentId { get; set; }

        [Range(0,100)]
        public int? Grade { get; set; }

        public virtual Course CourseCodeNavigation { get; set; }
        public virtual Student Student { get; set; }
    }
}
