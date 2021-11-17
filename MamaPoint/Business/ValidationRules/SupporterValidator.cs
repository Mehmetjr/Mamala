using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class SupporterValidator : AbstractValidator<Supporter>
    {
        public SupporterValidator()
        {
            RuleFor(x => x.SupporterImage).NotEmpty().WithMessage("Resim olmadan ekleme yapılmaz");
            RuleFor(x => x.supporterName).NotEmpty().WithMessage("Destekçi ismi giriniz");
        }
    }
}
