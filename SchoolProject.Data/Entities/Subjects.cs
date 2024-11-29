﻿using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SchoolProject.Data.Entities
{
    public class Subjects
    {

        [Key]
        public int Id { get; set; }
        [StringLength(500)] 
        public string Name { get; set; }
        public DateTime Period { get; set; }
        public virtual ICollection<StudentSubject> StudentsSubjects { get; set; } = new HashSet<StudentSubject>();
        public virtual ICollection<DepartmentSubject> DepartmetsSubjects { get; set; } = new HashSet<DepartmentSubject>();
    }

}
