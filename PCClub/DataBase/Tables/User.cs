using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCClub.DataBase.Tables
{
    class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        public string? FirstName { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        public string? LastName { get; set; }
        public string? SureName { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        public string? Email { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        public string? Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? DateRegistration { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        public string? Login {  get; set; }
        public decimal Salary { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        public string? Password { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; } = 1;
        public Role? Role { get; set; }
    }
}
