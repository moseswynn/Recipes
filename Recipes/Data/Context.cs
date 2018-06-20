using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Recipes.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Recipes.Data
{
    public class Context : DbContext
    {
        public Context()
        {
            //Initialize database with seed data.
            Database.SetInitializer(new DatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Override the OnModelCreating method to enable cascade delete and prevent FK constraint problems when deleting.
            modelBuilder.Entity<Recipe>()
                .HasMany(r => r.Ingredients)
                .WithOptional()
                .WillCascadeOnDelete();

            modelBuilder.Entity<Recipe>()
                .HasMany(r => r.Instructions)
                .WithOptional()
                .WillCascadeOnDelete();
        }

        public DbSet<Recipe> Recipes { get; set; }
       
    }
}