using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Exam.Models
{
    public class QuoteDBContext : DbContext  //Inherit from DbContext class
    {
        //Constructor
        public QuoteDBContext(DbContextOptions<QuoteDBContext> options) : base (options)
        {

        }

        //Bundle the quotes into a list
        public DbSet<Quote> Quotes { get; set; }
    }
}
