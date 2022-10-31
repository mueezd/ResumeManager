using Microsoft.AspNetCore.Mvc;
using ResumeManager.Data;
using ResumeManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace ResumeManager.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ResumeDbContext _context;
        public ResumeController(ResumeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Applicant> applicants;

            applicants = _context.Applicants.ToList();

            return View(applicants);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Applicant applicant = new Applicant();
            applicant.Expriences.Add(new Exprience() { ExprienceId = 1 });
            applicant.Expriences.Add(new Exprience() { ExprienceId = 2 });
            applicant.Expriences.Add(new Exprience() { ExprienceId = 3 });
            return View(applicant);
        }

        [HttpPost]
        public IActionResult Create(Applicant applicant)
        {
            _context.Add(applicant);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
