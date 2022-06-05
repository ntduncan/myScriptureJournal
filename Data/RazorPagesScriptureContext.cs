using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myScriptureJournal.Models;

    public class RazorPagesScriptureContext : DbContext
    {
        public RazorPagesScriptureContext (DbContextOptions<RazorPagesScriptureContext> options)
            : base(options)
        {
        }

        public DbSet<myScriptureJournal.Models.Scripture>? Scripture { get; set; }
    }
