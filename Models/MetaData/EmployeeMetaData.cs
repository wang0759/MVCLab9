using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab9.Models.DataAccess
{
    public class EmployeeMetaData
    {

        public EmployeeMetaData()
        {
            EmployeeRole = new HashSet<EmployeeRole>();
        }

        public int Id { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]+\s+[A-Za-z]+", ErrorMessage ="Must be in the form of 1st name + last name")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Must be unique and more than 3 characters")]
        public string UserName { get; set; }

        [Required]
        [StringLength(30, MinimumLength =5, ErrorMessage ="Must be more than 5 characters")]
        public string Password { get; set; }

        [Required]
        public virtual ICollection<EmployeeRole> EmployeeRole { get; set; }
    }
}
