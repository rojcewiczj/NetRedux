using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Events.Any())
            {
                var events = new List<Event>
                {
                    new Event
                    {
                        Title = "Past Event 1",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "Event 2 months ago",
                        Category = "drinks",
                        Area = "Area",
                        Location = "Address"
                    },
                    new Event
                    {
                        Title = "Past Event 2",
                        Date = DateTime.Now.AddMonths(-1),
                        Description = "Event 1 month ago",
                        Category = "culture",
                        Area = "Area",
                        Location = "Address"
                    },
                    new Event
                    {
                        Title = "Future Event 1",
                        Date = DateTime.Now.AddMonths(1),
                        Description = "Event 1 month in future",
                        Category = "culture",
                        Area = "Area",
                        Location = "Address"
                    },
                    new Event
                    {
                        Title = "Future Event 2",
                        Date = DateTime.Now.AddMonths(2),
                        Description = "Event 2 months in future",
                        Category = "music",
                        Area = "Area",
                        Location = "Address"
                    },
                    new Event
                    {
                        Title = "Future Event 3",
                        Date = DateTime.Now.AddMonths(3),
                        Description = "Event 3 months in future",
                        Category = "drinks",
                        Area = "Area",
                        Location = "Address"
                    },
                    new Event
                    {
                        Title = "Future Event 4",
                        Date = DateTime.Now.AddMonths(4),
                        Description = "Event 4 months in future",
                        Category = "drinks",
                        Area = "Area",
                        Location = "Address"
                    },
                    new Event
                    {
                        Title = "Future Event 5",
                        Date = DateTime.Now.AddMonths(5),
                        Description = "Event 5 months in future",
                        Category = "drinks",
                        Area = "Area",
                        Location = "Address"
                    },
                    new Event
                    {
                        Title = "Future Event 6",
                        Date = DateTime.Now.AddMonths(6),
                        Description = "Event 6 months in future",
                        Category = "music",
                        Area = "Area",
                        Location = "Address"
                    },
                    new Event
                    {
                        Title = "Future Event 7",
                        Date = DateTime.Now.AddMonths(7),
                        Description = "Event 2 months ago",
                        Category = "travel",
                        Area = "Area",
                        Location = "Address"
                    },
                    new Event
                    {
                        Title = "Future Event 8",
                        Date = DateTime.Now.AddMonths(8),
                        Description = "Event 8 months in future",
                        Category = "film",
                        Area = "Area",
                        Location = "Address"
                    }

            };
                context.Events.AddRange(events);
                context.SaveChanges();
           } 
        }
    }
}
