﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [DisplayName("Фамилия")]
        [StringLength(24)]
        [RegularExpression(@"^[A-Z]+[a-z]*$")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Имя")]
        [StringLength(24)]
        [RegularExpression(@"^[A-Z]+[a-z]*$")]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата поступления")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [DisplayName("Студент")]
        public string FullName { get => $"{LastName} {FirstName}"; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
