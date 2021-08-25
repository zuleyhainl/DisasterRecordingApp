using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class DisasterValidator : AbstractValidator<Disaster>
    {
        public DisasterValidator()
        {
            RuleFor(d => d.SerialNumber).NotEmpty().WithMessage("Seri Numarası boş bırakılamaz");
            RuleFor(d => d.GlideNumber).MaximumLength(30);
        }
    }
}
