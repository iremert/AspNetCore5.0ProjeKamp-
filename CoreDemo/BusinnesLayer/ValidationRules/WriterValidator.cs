using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
	
	public class WriterValidator : AbstractValidator<Writer>
	{
        public WriterValidator()
        {
			RuleFor(x => x.WriterName).NotNull().NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilmez aşko.").MaximumLength(50).MinimumLength(4).WithMessage("Lütfen ürün adı 4-50 karakter arasında olsun.");
			RuleFor(x => x.WriterMail).NotNull().NotEmpty().WithMessage("Mail adresi kısmı boş geçilmez.");
			RuleFor(x => x.WriterPassword).NotNull().NotEmpty().WithMessage("Şifre boş geçilmez").Matches("[a-zA-Z]").WithMessage("Şifre en az bir harf içermelidir").Matches("[0-9]").WithMessage("Şifre en az bir rakam içermelidir")
	.Matches("[!@#\\$]").WithMessage("Şifre en az bir özel karakter içermelidir")
	.Length(6, 20).WithMessage("Şifre 6 ila 20 karakter arasında olmalıdır");
			//RuleFor(x => x.WriterPassword).NotNull().NotEmpty().WithMessage("Şifre Boş Geçilemez.")
			//			.MinimumLength(8).WithMessage("Şifre 8 karakterden küçük olamaz.")
			//			.MaximumLength(16).WithMessage("Şifre 16 karakterden büyük olamaz.")
			//			.Matches(@"[A-Z]+").WithMessage("Şifrede en az bir büyük harf olmalıdır.")
			//			.Matches(@"[a-z]+").WithMessage("Şifrede en az bir küçük harf olmalıdır.")
			//			.Matches(@"[0-9]+").WithMessage("Şifrede en az bir rakam olmalıdır.");
		}

	}
}
