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
        public DbSet<investment> ��������_�_��������� { get; set; }
    }
}