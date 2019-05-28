using System;
using Microsoft.EntityFrameworkCore;

namespace DojoActivity.Models
{
    public class ActivityContext : DbContext
    {
       public ActivityContext(DbContextOptions options) : base(options) {}

       public DbSet<User> Users {get;set;}
       public DbSet<Activity> Activities {get;set;}
       public DbSet<Roster> Rosters {get;set;}
    }
}