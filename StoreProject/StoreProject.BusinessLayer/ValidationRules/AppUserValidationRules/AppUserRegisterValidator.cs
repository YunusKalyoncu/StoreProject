using FluentValidation;
using StoreProject.DTOLayer.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
   public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDtos>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsmini Boş Geçemezsin");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Boş Geçemezsin");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Boş GEçemezsin");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadı Boş Geçemezsin");

        }
        
    }
}
