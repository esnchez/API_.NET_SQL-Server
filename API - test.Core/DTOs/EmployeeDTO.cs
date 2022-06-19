using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API___test.Core.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string DNI { get; set; }

        public int Salary { get; set; }

        public int TeamId { get; set; }


    }
}
