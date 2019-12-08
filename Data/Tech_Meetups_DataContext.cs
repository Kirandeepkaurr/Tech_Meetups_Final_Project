using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tech_Meetups_Final_Project.Models;

namespace Tech_Meetups_Final_Project.Models
{
    //Connects the model objects to database.
    public class Tech_Meetups_DataContext : DbContext
    {
        public Tech_Meetups_DataContext (DbContextOptions<Tech_Meetups_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Tech_Meetups_Final_Project.Models.Meetup> Meetup { get; set; }

        public DbSet<Tech_Meetups_Final_Project.Models.MeetupRegistration> MeetupRegistration { get; set; }

        public DbSet<Tech_Meetups_Final_Project.Models.Participant> Participant { get; set; }
    }
}
