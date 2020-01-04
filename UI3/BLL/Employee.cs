using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Employee:Person
    {
        int employeeId;

        public Employee(int employeeId, string name,string email, string password)
            : base(name, email, password)
        {
            this.employeeId = employeeId;
        }

        public int EmployeeId { get => employeeId; set => employeeId = value; }

        public override int Login(string email, string password)
        {
            if (email == "fatih@izu.edu.tr" && password == "karaman")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
