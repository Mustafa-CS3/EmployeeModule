
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeModule.IRepository
{
    public interface IRepositoryWrapper
    {
        IEmployeeRepository Employee { get; }

       
        void Save();
    }
}
