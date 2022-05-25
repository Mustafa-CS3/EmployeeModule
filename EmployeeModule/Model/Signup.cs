using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeModule.Model
{
    public class Signup
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "User Name is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "UserId is Required")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
