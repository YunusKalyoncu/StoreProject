using FluentValidation;
using StoreProject.DTOLayer.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.BusinessLayer.ValidationRules.CategoryValidationRules
{
   public class CategoryCreateValdator:AbstractValidator<CreateCategoryDto>
    {
        public CategoryCreateValdator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklamasını Boş Geçemezsiniz.");
            RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage("Kategori Adı  En az 5 harf Olmalıdır.");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori Adı  En fazla 50 harf Olmalıdır.");
        }
    }
}
