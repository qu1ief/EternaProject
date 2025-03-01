using EternaProject.Models;

namespace EternaProject.ViewModels
{
    public class BlogVm
    {
        public List<Blog> Blogs { get; set; }
        public List<Blog> BlogsRecents { get; set; }
        public List<Category> Categories { get; set; }
    }
}
