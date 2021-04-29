using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using report1;

namespace report1.Controllers
{
    public class IncidentReportsController : Controller
    {
        private readonly report1Context _context;

        public IncidentReportsController(report1Context context)
        {
            _context = context;
        }

        // GET: IncidentReports
        public async Task<IActionResult> Index()
        {
            var report1Context = _context.IncidentReport.Include(i => i.Ircreater).Include(i => i.Irform);
            return View(await report1Context.ToListAsync());
        }

        // GET: IncidentReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidentReport = await _context.IncidentReport
                .Include(i => i.Ircreater)
                .Include(i => i.Irform)
                .FirstOrDefaultAsync(m => m.Irid == id);
            if (incidentReport == null)
            {
                return NotFound();
            }

            return View(incidentReport);
        }

        // GET: IncidentReports/Create
        public IActionResult Create()
        {
            ViewData["IrcreaterId"] = new SelectList(_context.Users, "UserId", "Email");
            ViewData["IrformId"] = new SelectList(_context.Irform, "IrformId", "IrformId");
            return View();
        }

        // POST: IncidentReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Irid,IrcreaterId,IsComplete,IrrelatedDept,IrstartDate,IrcompleteDate,IrformId")] IncidentReport incidentReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incidentReport);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewData["IrcreaterId"] = new SelectList(_context.Users, "UserId", "Email", incidentReport.IrcreaterId);
            ViewData["IrformId"] = new SelectList(_context.Irform, "IrformId", "IrformId", incidentReport.IrformId);
            return View(incidentReport);
        }

        // GET: IncidentReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidentReport = await _context.IncidentReport.FindAsync(id);
            if (incidentReport == null)
            {
                return NotFound();
            }
            ViewData["IrcreaterId"] = new SelectList(_context.Users, "UserId", "Email", incidentReport.IrcreaterId);
            ViewData["IrformId"] = new SelectList(_context.Irform, "IrformId", "IrformId", incidentReport.IrformId);
            return View(incidentReport);
        }

        // POST: IncidentReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Irid,IrcreaterId,IsComplete,IrrelatedDept,IrstartDate,IrcompleteDate,IrformId")] IncidentReport incidentReport)
        {
            if (id != incidentReport.Irid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incidentReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncidentReportExists(incidentReport.Irid))
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
            ViewData["IrcreaterId"] = new SelectList(_context.Users, "UserId", "Email", incidentReport.IrcreaterId);
            ViewData["IrformId"] = new SelectList(_context.Irform, "IrformId", "IrformId", incidentReport.IrformId);
            return View(incidentReport);
        }

        // GET: IncidentReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidentReport = await _context.IncidentReport
                .Include(i => i.Ircreater)
                .Include(i => i.Irform)
                .FirstOrDefaultAsync(m => m.Irid == id);
            if (incidentReport == null)
            {
                return NotFound();
            }

            return View(incidentReport);
        }

        // POST: IncidentReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var incidentReport = await _context.IncidentReport.FindAsync(id);
            _context.IncidentReport.Remove(incidentReport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncidentReportExists(int id)
        {
            return _context.IncidentReport.Any(e => e.Irid == id);
        }
    }
}
