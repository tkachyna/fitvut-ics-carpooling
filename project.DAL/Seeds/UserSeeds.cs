using System;
using System.Collections.Generic;
using project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace project.DAL.Seeds
{

    public static class UserSeeds
    {
        public static readonly UserEntity User1 = new()
        {
            Id = Guid.Parse("F78ED923-E094-4016-9045-3F5BB7F2EB88"),
            FirstName = "Jirka",
            LastName = "Babica",
            ImageUrl = "https://g.cz/sites/default/files/styles/gflex_landscape_large/public/field/image/2019/babica1.jpg?itok=MhSBirIa",
            Age = 42,
            //DrivesAsDriver = default,
            //DrivesAsPassenger = default,
            //IsOnJourney = true,

        };


        public static readonly UserEntity UserUpdate = User1 with
        {
            Id = Guid.Parse("143332B9-080E-4953-AEA5-BEF64679B052")
        };

        public static readonly UserEntity User2 = new()
        {
            Id = Guid.Parse("5BB0D024-42B1-4CEB-B643-93D35E82A367"),
            FirstName = "Ave",
            LastName = "Kuchyňka",
            ImageUrl = "https://cdn.discordapp.com/attachments/906656709345411113/973982403167141969/unknown.png",
            Age = 24,
            //DrivesAsDriver = default,
            //DrivesAsPassenger = default,
            //IsOnJourney = true,



        };

        static UserSeeds()
        {
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasData(
                User1,
                User2
            );
        }
    }
}