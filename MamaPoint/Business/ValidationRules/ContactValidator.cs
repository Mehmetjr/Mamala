using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.subject).NotEmpty().WithMessage("Konu alanı boş bırakılamaz");
            RuleFor(x => x.subject).MinimumLength(4).WithMessage("Konu en az 4 karakterden oluşmalı");
            RuleFor(x => x.message).NotEmpty().WithMessage("Mesaj alanı boş bırakılamaz");
        }
    }
}
