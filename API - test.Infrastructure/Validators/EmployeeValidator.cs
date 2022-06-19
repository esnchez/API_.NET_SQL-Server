using API___test.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API___test.Infrastructure.Validators
{
    class EmployeeValidator : AbstractValidator<EmployeeDTO>
    {
        public EmployeeValidator()
        {
            RuleFor(employee => employee.DNI)
                .Length(9);
        }
    }
}
