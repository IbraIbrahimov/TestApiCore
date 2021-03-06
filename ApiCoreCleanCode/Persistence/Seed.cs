﻿using Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context, UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser
                    {
                        DisplayName="Ibrahim",
                        UserName="ibrhaim",
                        Email="ibrahim@test.com"
                    },
                     new AppUser
                    {
                        DisplayName="Vugar",
                        UserName="vugar",
                        Email="vugar@test.com"
                    },
                      new AppUser
                    {
                        DisplayName="Bob",
                        UserName="bob",
                        Email="bob@test.com"
                    }

                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user,"Pa$$w0rd");
                }
            }

                if (!context.Actvities.Any())
                {
                    var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title="Past Activity 1",
                        Date=DateTime.Now.AddMonths(-2),
                        Description="Activity 2 month ago",
                        Category="drinks",
                        City="London",
                        Venue="Pub"
                    },
                     new Activity
                    {
                        Title="Past Activity 2",
                        Date=DateTime.Now.AddMonths(-1),
                        Description="Activity 1 month ago",
                        Category="culture",
                        City="Paris",
                        Venue="Louvre"
                    },
                        new Activity
                    {
                        Title="Future Activity 1",
                        Date=DateTime.Now.AddMonths(1),
                        Description="Activity 1 month in future",
                        Category="culture",
                        City="London",
                        Venue="Natural History Museum"
                    },
                    new Activity
                    {
                        Title="Future Activity 2",
                        Date=DateTime.Now.AddMonths(2),
                        Description="Activity 2 month in future",
                        Category="music",
                        City="London",
                        Venue="02 Arena"
                    },
                    new Activity
                    {
                        Title="Future Activity 3",
                        Date=DateTime.Now.AddMonths(3),
                        Description="Activity 3 month in future",
                        Category="drinks",
                        City="London",
                        Venue="Another Pub"
                    },
                    new Activity
                    {
                        Title="Future Activity 4",
                        Date=DateTime.Now.AddMonths(4),
                        Description="Activity 4 month in future",
                        Category="drinks",
                        City="London",
                        Venue="Yet Another Pub"
                    },
                    new Activity
                    {
                        Title="Future Activity 5",
                        Date=DateTime.Now.AddMonths(5),
                        Description="Activity 5 month in future",
                        Category="drinks",
                        City="London",
                        Venue="Just another pub"
                    },
                    new Activity
                    {
                        Title="Future Activity 6",
                        Date=DateTime.Now.AddMonths(6),
                        Description="Activity 6 month in future",
                        Category="music",
                        City="London",
                        Venue="04 Arena"
                    },
                    new Activity
                    {
                        Title="Future Activity 7",
                        Date=DateTime.Now.AddMonths(7),
                        Description="Activity 7 month in future",
                        Category="travel",
                        City="London",
                        Venue="Somewhere on the Thames"
                    },
                    new Activity
                    {
                        Title="Future Activity 8",
                        Date=DateTime.Now.AddMonths(8),
                        Description="Activity 8 month in future",
                        Category="film",
                        City="London",
                        Venue="Cinema"
                    }
                };

                    context.Actvities.AddRange(activities);
                    context.SaveChanges();
                }
        }
    }
}
