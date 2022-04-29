using ApplicationWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApplicationWebAPI.Data
{
    public class CurrentContext : DbContext
    {
        public CurrentContext(DbContextOptions<CurrentContext> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<User> Users { get; set; }


        /*
        internal void Update(int userId, User user)
        {
            throw new NotImplementedException();
        }
        */


    }

}
