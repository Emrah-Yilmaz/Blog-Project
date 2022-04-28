using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidate : AbstractValidator<Blog>
    {
        public BlogValidate()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Adı Boş geçilemez");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("İçerik boş geçilemez");
            RuleFor(x => x.BlogTitle).MinimumLength(2).WithMessage("Başlık en az 2 karakter olmalıdır.");
            RuleFor(x => x.BlogTitle).MaximumLength(100).WithMessage("Başlık 100 karakterden fazla olamaz");
            RuleFor(x => x.BlogContent).MinimumLength(2).WithMessage("İçerik 2 karakterden falza olmalıdır.");
            RuleFor(x => x.BlogTitle).MaximumLength(1000).WithMessage("içerik 1000 karakterden fazla olamaz");

        }
    }
}
