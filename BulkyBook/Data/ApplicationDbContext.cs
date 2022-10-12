using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BulkyBook.Data
{
    public class ApplicationDbContext : DbContext
    {

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        {
            
        }

        public  DbSet<Kategori> Categories { get; set; }   

    }
}
