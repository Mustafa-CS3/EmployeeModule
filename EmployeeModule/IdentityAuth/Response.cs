using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeModule.IdentityAuth
{
    public class Response
    {
        public string Status { get; set; }
        public  bool Success { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }
    }
}
