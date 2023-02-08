using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(a => a.Title).NotEmpty().WithMessage("Blog başlığı boş olamaz.");
            RuleFor(a => a.Content).NotEmpty().WithMessage("Blog içeriği boş olamaz.");
            RuleFor(a => a.Image).NotEmpty().WithMessage("Blog görseli boş olamaz");
            RuleFor(a => a.Title).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha kısa bir metin giriniz");
            RuleFor(a => a.Title).MinimumLength(10).WithMessage("Lütfen 10 karakterden daha uzun bir metin giriniz");
        }
    }
}
