using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieMania.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMania.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
