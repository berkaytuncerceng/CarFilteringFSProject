﻿using DTOs.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class IlanForUpdateValidator : AbstractValidator<IlanForUpdateDto>
    {
        public IlanForUpdateValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("ID boş olamaz");
        }
    }
}
