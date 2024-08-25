using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class NewsLetterValidator: AbstractValidator<NewsLetter>
    {
        public NewsLetterValidator()
        {
            RuleFor(x => x.Mail)
                .NotEmpty().WithMessage("Mail adresi boş olamaz")
                .EmailAddress().WithMessage("Geçerli bir mail adresi giriniz.");
        }
  
    }
}
