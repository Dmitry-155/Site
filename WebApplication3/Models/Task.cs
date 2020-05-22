using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace modelsTraining2.Models
{
    public class investmentContext : DbContext
    {
        public investmentContext() : base("DbConnection")
        {}
        public DbSet<investment> Вложения_к_обращению { get; set; }
    }
}