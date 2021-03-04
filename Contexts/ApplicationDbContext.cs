using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogService.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BlogService.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<Comments> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var states = new List<States>()
            {
                new States(){Id = 1, Description = "PendingToApproval" },
                new States(){Id = 2, Description = "Reject" },
                new States(){Id = 3, Description = "Approval" }
            };

            modelBuilder.Entity<States>().HasData(states);

            var posts = new List<Posts>()
            {
                new Posts(){Id = Guid.NewGuid(), AuthorName = "sergio.com", SubmitDate = DateTime.Now, State = 3 },
                new Posts(){Id = Guid.NewGuid(), AuthorName = "sergio.com", SubmitDate = DateTime.Now, State = 1 },
                new Posts(){Id = Guid.NewGuid(), AuthorName = "ser.com", SubmitDate = DateTime.Now, State = 3 }
            };

            modelBuilder.Entity<Posts>().HasData(posts);

            var comments = new List<Comments>()
            {
                new Comments(){Id = Guid.NewGuid(), PostId = Guid.Parse("8C8BFFC2-9347-4958-A27D-1F3085E7E98D"), Comment = "Comment test 1" },
                new Comments(){Id = Guid.NewGuid(), PostId = Guid.Parse("8C8BFFC2-9347-4958-A27D-1F3085E7E98D"), Comment = "Comment test 2" },
                 new Comments(){Id = Guid.NewGuid(), PostId = Guid.Parse("BAD5B4E7-B313-4B22-AB54-4C434C0D5A14"), Comment = "Comment test 2" },
            };

            modelBuilder.Entity<Comments>().HasData(comments);

            base.OnModelCreating(modelBuilder);
        }
    }
}
