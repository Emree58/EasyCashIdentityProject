using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alani bos geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alani bos geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanici adi alani bos  geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alani bos geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Sifre alani bos geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Sifre tekrar alani bos geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lutfen en fazla 30 karakter girisi yapin");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lutfen en az 2 karakter veri girisi yapin");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolariniz eslesmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lutfen geçerli bir mail adresi giriniz");
        }
    }
}
