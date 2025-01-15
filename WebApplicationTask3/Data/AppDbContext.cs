﻿using Microsoft.EntityFrameworkCore;
using WebApplicationTask3.Models;

namespace WebApplicationTask3.Data
{
    public class AppDbContext:DbContext
    {
           public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
