using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.userName).NotEmpty().WithMessage("İsim alanı boş olamaz");
            RuleFor(x => x.userSurname).NotEmpty().WithMessage("Soyad alanı boş olamaz");
            RuleFor(x => x.userMail).NotEmpty().WithMessage("Mail alanı boş olamaz");
            RuleFor(x => x.password).NotEmpty().WithMessage("Şifre alanı boş olamaz");
            RuleFor(x => x.password).MinimumLength(4).WithMessage("Şifre en az 4 karakterden oluşmalı");

        }
    }
}
