using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Exam.Models
{
    public interface IQuoteRepository
    {
        //Bring in data from Quote model
        IQueryable<Quote> Quotes { get; }

        //CRUD functionality
        public void EditQuote(Quote q);
        public void AddQuote(Quote q);
        public void DeleteQuote(Quote q);
    }
}
