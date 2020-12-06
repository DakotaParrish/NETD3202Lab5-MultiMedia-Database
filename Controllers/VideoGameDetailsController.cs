using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETD3202Lab5_1.Models;

namespace NETD3202Lab5_1.Controllers
{
    public class VideoGameDetailsController : Controller
    {
        private readonly VideoGameContext _context;

        public VideoGameDetailsController(VideoGameContext context)
        {
            _context = context;
        }

        // GET: VideoGameDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.AdditionalGameDetails.ToListAsync());
        }

        // GET: VideoGameDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGameDetails = await _context.AdditionalGameDetails
                .FirstOrDefaultAsync(m => m.videoGameID == id);
            if (videoGameDetails == null)
            {
                return NotFound();
            }

            return View(videoGameDetails);
        }

        // GET: VideoGameDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VideoGameDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("videoGameID,videoGameDescription")] VideoGameDetails videoGameDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(videoGameDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(videoGameDetails);
        }

        // GET: VideoGameDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGameDetails = await _context.AdditionalGameDetails.FindAsync(id);
            if (videoGameDetails == null)
            {
                return NotFound();
            }
            return View(videoGameDetails);
        }

        // POST: VideoGameDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("videoGameID,videoGameDescription")] VideoGameDetails videoGameDetails)
        {
            if (id != videoGameDetails.videoGameID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(videoGameDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VideoGameDetailsExists(videoGameDetails.videoGameID))
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
            return View(videoGameDetails);
        }

        // GET: VideoGameDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGameDetails = await _context.AdditionalGameDetails
                .FirstOrDefaultAsync(m => m.videoGameID == id);
            if (videoGameDetails == null)
            {
                return NotFound();
            }

            return View(videoGameDetails);
        }

        // POST: VideoGameDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var videoGameDetails = await _context.AdditionalGameDetails.FindAsync(id);
            _context.AdditionalGameDetails.Remove(videoGameDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VideoGameDetailsExists(int id)
        {
            return _context.AdditionalGameDetails.Any(e => e.videoGameID == id);
        }
    }
}
