using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.adminName).NotEmpty().WithMessage("İsim alanı boş olamaz");
            RuleFor(x => x.adminSurname).NotEmpty().WithMessage("Soyad alanı boş olamaz");
            RuleFor(x => x.adminMail).NotEmpty().WithMessage("Mail alanı boş olamaz");
            RuleFor(x => x.adminPassword).NotEmpty().WithMessage("Şifre alanı boş olamaz");
            RuleFor(x => x.adminPassword).MinimumLength(4).WithMessage("Şifre en az 4 karakterden oluşmalı");

        }
    }
}
