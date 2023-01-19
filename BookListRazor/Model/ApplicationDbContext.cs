using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackCoderDailyTransactions.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions <ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DailyTransaction> DailyTransaction { get; set; }



    }

}
