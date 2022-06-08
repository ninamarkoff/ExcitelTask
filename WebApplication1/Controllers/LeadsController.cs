using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Excitel.Data;
using Excitel.Data.EFCore;
using Excitel.Models;

namespace Excitel.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LeadsController : BaseController<Lead, EFCoreLeadRepository>
    {
        //private readonly ApplicationDbContext _context;

        //public LeadsController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public LeadsController(EFCoreLeadRepository repository) : base(repository)
        {
        }

        //// GET: Leads
        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //      return _context.Leads != null ? 
        //                  View(await _context.Leads.ToListAsync()) :
        //                  Problem("Entity set 'ApplicationDbContext.Lead'  is null.");
        //}

        //// GET: Leads/Details/5
        //[HttpGet("Details/{id}")]
        //public async Task<IActionResult> Get(int? id)
        //{
        //    if (id == null || _context.Leads == null)
        //    {
        //        return NotFound();
        //    }

        //    var lead = await _context.Leads
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (lead == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(lead);
        //}

        //// GET: Leads/Create
        //[HttpGet("Create")]
        //public IActionResult Add()
        //{
        //    return View();
        //}

        //// POST: Leads/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost("Create")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Add([FromForm] Lead lead)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(lead);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(GetAll));
        //    }
        //    return View(lead);
        //}

        //// GET: Leads/Edit/5
        //[HttpGet("Edit/{id}")]
        //public async Task<IActionResult> Update(int? id)
        //{
        //    if (id == null || _context.Leads == null)
        //    {
        //        return NotFound();
        //    }

        //    var lead = await _context.Leads.FindAsync(id);
        //    if (lead == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(lead);
        //}

        //// POST: Leads/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost("Edit/{id}")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Update(int id, [FromForm] Lead lead)
        //{
        //    if (id != lead.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(lead);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!LeadExists(lead.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(GetAll));
        //    }
        //    return View(lead);
        //}

        //private bool LeadExists(int id)
        //{
        //  return (_context.Leads?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
