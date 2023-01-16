using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(w => w.Name).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez.");
			RuleFor(w => w.Mail).NotEmpty().WithMessage("Mail adresi kısmı boş geçilemez.");
			RuleFor(w => w.Password).NotEmpty().WithMessage("Şifre kısmı boş geçilemez.");
			RuleFor(w => w.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın.");
			RuleFor(w => w.Name).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapın.");
		}
	}
}

