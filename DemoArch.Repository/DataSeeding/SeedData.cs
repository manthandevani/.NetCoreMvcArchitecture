using DemoArch.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoArch.Repository.DataSeeding
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { FirstName = "Manthan", Id = 1, LastName = "Devani" });
        }
    }
}
