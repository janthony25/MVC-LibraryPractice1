using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_LibraryPractice1.Models;

namespace MVC_LibraryPractice1.Data
{
    public class LibraryPractice1Context : DbContext
    {
        public LibraryPractice1Context (DbContextOptions<LibraryPractice1Context> options)
            : base(options)
        {
        }

        public DbSet<MVC_LibraryPractice1.Models.Book> Book { get; set; } = default!;
    }
}
