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
    //participants controller with  only meetup admin permission.

    [Authorize(Roles = "meetup_admin")]
    public class ParticipantsController : Controller
    {
        private readonly Tech_Meetups_DataContext _context;

        public ParticipantsController(Tech_Meetups_DataContext context)
        {
            _context = context;
        }

        // GET: Participants
        //Gets all participants using linq query.
        
        public async Task<IActionResult> Index()
        {
            return View(await (from participants in _context.Participant
                        select participants).ToListAsync());
        }

        // GET: Participants/Details/5
        //Gets the details using a a lamda query.
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        //Gets the participant for edit
      
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participant.FindAsync(id);
            if (participant == null)
            {
                return NotFound();
            }
            return View(participant);
        }

        // POST: Participants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
       //Edits the participant.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Mobile")] Participant participant)
        {
            if (id != participant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(participant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParticipantExists(participant.Id))
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
            return View(participant);
        }

        // GET: Participants/Delete/5
        //Gets the participant for delete using a lamda query.
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        // POST: Participants/Delete/5
        //Deletes the participant 
    
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var participant = await _context.Participant.FindAsync(id);
            _context.Participant.Remove(participant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //Checks the participant exists using a lamda query.
        private bool ParticipantExists(int id)
        {
            return _context.Participant.Any(e => e.Id == id);
        }
    }
}
