﻿using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar İsmi boş bırakılamaz.");
            RuleFor(x => x.WriterName).NotEmpty().Length(5, 50).WithMessage("Yazar ismi en az 5 en fazla 50 karakter olmalıdır.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş bırakılamaz.");
            RuleFor(x => x.WriterPassword).Equal(x => x.WriterConfirmPassword).WithMessage("Şifreler aynı olmak zorundadır.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail kısmı boş bırakılamaz.");

        }
    }
}
