using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
	public class ContactValidator: AbstractValidator<Contact>
	{
		public ContactValidator() 
		{
			RuleFor(x => x.ContactMessage).NotEmpty().WithMessage("Mail adresi boş olamaz");

		}
	}
}
