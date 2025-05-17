using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LearnBlazorCRUD.Models;

namespace LearnBlazorCRUD.Data
{
    public class LearnBlazorCRUDContext : DbContext
    {
        public LearnBlazorCRUDContext (DbContextOptions<LearnBlazorCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<LearnBlazorCRUD.Models.Student> Student { get; set; } = default!;
    }
}
