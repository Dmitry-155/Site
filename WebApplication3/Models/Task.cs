using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace modelsTraining2.Models
{
    public class InvestmentContext : DbContext
    {
        public InvestmentContext() : base("DbConnection")
        {}
        public DbSet<Investment> Вложения_к_обращению { get; set; }
    }
}