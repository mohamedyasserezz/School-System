﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SchoolProject.Data.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(500)]
        public string Phone { get; set; }
        public int? DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]

        [InverseProperty(nameof(Department.Students))]
        public virtual Department Department { get; set; }

    }
}
