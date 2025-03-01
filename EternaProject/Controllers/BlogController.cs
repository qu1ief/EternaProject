using EternaProject.Data;
using EternaProject.Models;
using EternaProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EternaProject.Controllers
{
    public class BlogController(EternaContext eternaContext) : Controller
    {
        public ActionResult Index()
        {
            BlogVm blogVm = new BlogVm()
            {
                Blogs = eternaContext.Blogs.ToList(),
                Categories = eternaContext.Categories.ToList(),
                BlogsRecents = eternaContext.Blogs.OrderByDescending(x=>x.Id).Take(2).ToList()
            };
            return View(blogVm);
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog blog = eternaContext.Blogs.FirstOrDefault(x => x.Id == id);
            if (blog == null) 
            {
                return NotFound();
            }

            BlogDetailVm blogDetailVm = new BlogDetailVm()
            {
                Blog = blog,
                BlogsRecents = eternaContext.Blogs.OrderByDescending(x => x.Id).Take(4).ToList(),
                Categories = eternaContext.Categories.ToList(),


            };
            return View(blogDetailVm);
        }

    }
}
