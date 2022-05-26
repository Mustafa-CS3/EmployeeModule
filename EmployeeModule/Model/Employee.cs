using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeModule.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public int DeptId { get; set; }
        public string FullName { get; set; }
        public string Designation { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
