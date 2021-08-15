using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectForItransition.Models.Collection;
using ProjectForItransition.Models.Item;

namespace ProjectForItransition.Repository
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContentCollection> Collections { get; set; }
        public DbSet<ContentItem> Items { get; set; }
        public DbSet<NameField> NameFields { get; set; }
        public DbSet<IntegerElement> IntegerElements { get; set; }
        public DbSet<StringElement> StringElements { get; set; }
        public DbSet<MarkdownElement> MarkdownElements { get; set; }
        public DbSet<DateTimeOffsetElement> DateTimeOffsetElements { get; set; }
        public DbSet<CheckboxElement> CheckboxElements { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ImageField> Images { get; set; }
        public DbSet<Like> Likes { get; set; }
    }
}
