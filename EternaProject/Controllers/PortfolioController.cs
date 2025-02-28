using EternaProject.Data;
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
    }
}
