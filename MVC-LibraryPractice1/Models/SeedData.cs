using Humanizer;
using Microsoft.EntityFrameworkCore;
using MVC_LibraryPractice1.Data;

namespace MVC_LibraryPractice1.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryPractice1Context(
                serviceProvider.GetRequiredService<DbContextOptions<
                    LibraryPractice1Context>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }

                context.AddRange(
                    new Book { Title = "Tiny C# Projects", CallNumber = "TDG 545" },
                    new Book { Title = "Book 2", CallNumber = "PRD 401" }
                    );
                context.SaveChanges();
            }
        }
    }
}
