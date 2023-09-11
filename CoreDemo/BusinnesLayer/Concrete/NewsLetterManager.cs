using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsletterdal;

        public NewsLetterManager(INewsLetterDal newsletterdal) //bizden bir ınewsletter bekler bizde ef gönderdik o da Inewsletterdan kalıtım almıştı :)
        {
            _newsletterdal = newsletterdal;
        }

        public void AddNewsLetter(NewsLetter newsletter)
        {
            _newsletterdal.Insert(newsletter);
           
        }
    }
}
