using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tech_Meetups_Final_Project.Models;

namespace Tech_Meetups_Final_Project.Controllers
{
    //Meet ups controller
    public class MeetupsController : Controller
    {
        private readonly Tech_Meetups_DataContext _context;

        public MeetupsController(Tech_Meetups_DataContext context)
        {
            _context = context;
        }

        // GET: Meetups
        //Gets the meetup list uing a linq query admin and participant permission
        [Authorize(Roles="participant, meetup_admin")]
        public async Task<IActionResult> Index()
        {
            return View((from meetup in _context.Meetup select meetup).ToList());
        }

        // GET: Meetups/Details/5
        //Gets the meetup details using lamda query.
        [Authorize(Roles = "participant, meetup_admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetup = await _context.Meetup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meetup == null)
            {
                return NotFound();
            }

            return View(meetup);
        }

        // GET: Meetups/Create
        //Gets the  meet up create form admin only.
        [Authorize(Roles = "meetup_admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Meetups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //Creates the meetup admin only 
        [Authorize(Roles = "meetup_admin")]
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventTitle,Venue,Date,StartTime,EndTime")] Meetup meetup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meetup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meetup);
        }

        // GET: Meetups/Edit/5
        //Gets the meetup for update admin only
        [Authorize(Roles = "meetup_admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetup = await _context.Meetup.FindAsync(id);
            if (meetup == null)
            {
                return NotFound();
            }
            return View(meetup);
        }

        // POST: Meetups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //Updates the meetup admin only
        [Authorize(Roles = "meetup_admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EventTitle,Venue,Date,StartTime,EndTime")] Meetup meetup)
        {
            if (id != meetup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meetup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetupExists(meetup.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(meetup);
        }

        // GET: Meetups/Delete/5
        //Gets the meetup for delete using a lamda query.
        [Authorize(Roles = "meetup_admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetup = await _context.Meetup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meetup == null)
            {
                return NotFound();
            }

            return View(meetup);
        }

        // POST: Meetups/Delete/5
        //Deletes the meetup admin only
        [Authorize(Roles = "meetup_admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meetup = await _context.Meetup.FindAsync(id);
            _context.Meetup.Remove(meetup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //Checks a meet up exists using a lamda query
        private bool MeetupExists(int id)
        {
            return _context.Meetup.Any(e => e.Id == id);
        }
    }
}
