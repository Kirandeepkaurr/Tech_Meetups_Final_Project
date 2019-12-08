using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tech_Meetups_Final_Project.Models
{
    //Meet up info
    public class Meetup
    {
        //Meet up id
        public int Id { get; set; }

        //Event name
        public string EventTitle { get; set; }

        //Venue of meetup
        public string Venue { get; set; }

        //Date of meetup
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //Start time of mmet up
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        //End time of meet up
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

    }
}
