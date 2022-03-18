using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidate : AbstractValidator<Writer>
    {
        public WriterValidate()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçielemez");
            RuleFor(x => x.WriterPassword).MinimumLength(8).WithMessage("Şifre en az 8 karakter olmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazar adı 50 karakterden fazla olamaz"); 
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Adınız 2 karakterden falza olmalıdır.");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Bir mail adresi girmelisiniz...");
        }
    }
}
