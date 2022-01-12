using Microsoft.EntityFrameworkCore;

namespace PhoneBook.Models
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Person> people { get; set; }
    }
}
