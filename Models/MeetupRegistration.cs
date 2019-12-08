using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tech_Meetups_Final_Project.Models
{
    //Meet up registration info
    public class MeetupRegistration
    {
        //Meetup  registration id 
        public int Id { get; set; }

        //Meet up id 
        public int MeetupId { get; set; }

        //participant id
        public int ParticipantId { get; set; }
        //Meet up link
        public Meetup MeetUp{get; set;}

        //Participant link
        public Participant Participant { get; set; }




    }
}
