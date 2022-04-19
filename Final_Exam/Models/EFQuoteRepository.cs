using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Exam.Models
{
    public class EFQuoteRepository : IQuoteRepository  //Inherits from IQuoteRepository
    {
        //Instance of the context file
        private QuoteDBContext _context { get; set; }

        //Constructor
        public EFQuoteRepository(QuoteDBContext temp)
        {
            _context = temp;
        }

        public IQueryable<Quote> Quotes => _context.Quotes;

        public void AddQuote(Quote q)
        {
            _context.Add(q);
            _context.SaveChanges();
        }

        public void DeleteQuote(Quote q)
        {
            _context.Quotes.Remove(q);
            _context.SaveChanges();
        }

        public void EditQuote(Quote q)
        {
            _context.Update(q);
            _context.SaveChanges();
        }
    }
}
