using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrate
{


    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsletterDal;

        public NewsLetterManager(INewsLetterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {
            if (IsEmailExists(newsLetter.Mail))
            {
                throw new Exception("Bu e-posta adresi zaten mevcut.");
            }
            _newsletterDal.Insert(newsLetter);
        }
        public bool IsEmailExists(string email)
        {
            return _newsletterDal.GetList().Any(x => x.Mail == email);
        }

    }
}
