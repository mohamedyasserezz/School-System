﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entities
{
    public class DepartmentSubject
    {
        [Key]
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int SubjectId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public virtual Subjects Subject { get; set; }
    }
}
