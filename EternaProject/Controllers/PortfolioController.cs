using EternaProject.Data;
using EternaProject.Models;
using EternaProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaProject.Controllers
{
    public class PortfolioController(EternaContext eternaContext) : Controller
    {
        public IActionResult Index()
        {
            PortfolioVm portfolioVm = new()
            {
                Categories = eternaContext.Categories.ToList(),
                Projects = eternaContext.Projects
                .Include(x => x.Category)
                .Include(x => x.ProjectImages)
                .ToList()
            };
            return View(portfolioVm);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Project? project = eternaContext.Projects
                .Include(p => p.ProjectImages)
                .Include(p => p.Category)
                .FirstOrDefault(p=>p.Id == id);

            if (project == null) 
            {
                return NotFound();
            }
            return View(project);
        }
    }
}
