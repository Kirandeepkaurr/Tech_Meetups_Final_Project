using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tech_Meetups_Final_Project.Models;

namespace Tech_Meetups_Final_Project.Controllers
{
    //Meetups Regsitration controller.
    public class MeetupRegistrationsController : Controller
    {
        private readonly Tech_Meetups_DataContext _context;

        public MeetupRegistrationsController(Tech_Meetups_DataContext context)
        {
            _context = context;
        }

        // GET: MeetupRegistrations
        //Get all meetup registrations  using lamda 
        [Authorize(Roles = "meetup_admin")]
        public IActionResult Index()
        {
            return View(_context.MeetupRegistration
                .Include(m=>m.Participant)
                .Include(m=> m.MeetUp).ToList());
        }

        // GET: MeetupRegistrations/Details/5
        //Gets the meeting regsitration details using a lamda query.
        [Authorize(Roles = "meetup_admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetupRegistration = await _context.MeetupRegistration.
                Include(m=> m.MeetUp)
                .Include(m => m.Participant)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meetupRegistration == null)
            {
                return NotFound();
            }

            return View(meetupRegistration);
        }

        // GET: MeetupRegistrations/Create
        //Creates the meetinf registration as request by the participant.
        [Authorize(Roles = "participant")]
        public IActionResult Create(int id)
        {
            var MeetUp = (from meetUp in _context.Meetup
                               where meetUp.Id == id
                               select meetUp).FirstOrDefault();

            var meetUpRegistration = new MeetupRegistration();

            meetUpRegistration.MeetUp = MeetUp;

            if (HttpContext.Session.GetString("participantId") !=null) {
               
                int participantId  = Int32.Parse(HttpContext.Session.GetString("participantId"));

                meetUpRegistration.Participant = (from participant in _context.Participant
                                                  where participant.Id == participantId
                                                  select participant).FirstOrDefault();
            }

            _context.MeetupRegistration.Add(meetUpRegistration);
            _context.SaveChanges();

            return View(meetUpRegistration);
        }


      

        // GET: MeetupRegistrations/Delete/5
        //Gets the Delete meeting registration form using a lamda. Admin only
        [Authorize(Roles = "meetup_admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetupRegistration = await _context.MeetupRegistration
                .Include(m=>m.Participant)
                .Include(m=>m.MeetUp)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meetupRegistration == null)
            {
                return NotFound();
            }

            return View(meetupRegistration);
        }

        // POST: MeetupRegistrations/Delete/5
        //Deletes the meetup registation. Admin only
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "meetup_admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meetupRegistration = await _context.MeetupRegistration.FindAsync(id);
            _context.MeetupRegistration.Remove(meetupRegistration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

      
    }
}
