using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Data.Models
{
    public class MonterDataContext : DbContext
    {
        public MonterDataContext(DbContextOptions options)
             : base(options)
        {
           
        }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Monter> Monters { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AuthorityDto> Authorities { get; set; }
    }
}
