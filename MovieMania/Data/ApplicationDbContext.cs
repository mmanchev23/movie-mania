using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieMania.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMania.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<AppUser> User { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
