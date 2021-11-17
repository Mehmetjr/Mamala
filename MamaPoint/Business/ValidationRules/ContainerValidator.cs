using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class ContainerValidator : AbstractValidator<FoodContainer>
    {
        public ContainerValidator()
        {
            RuleFor(x => x.Lat).NotEmpty().WithMessage("Latitude alanı boş olamaz");
            RuleFor(x => x.Long).NotEmpty().WithMessage("Longtitude alanı boş olamaz");
            RuleFor(x => x.pin).NotEmpty().WithMessage("Pin alanı boş olamaz");
            RuleFor(x => x.time).NotEmpty().WithMessage("Time alanı boş olamaz");
            RuleFor(x => x.explain).NotEmpty().WithMessage("Time alanı boş olamaz");




        }
    }
}
