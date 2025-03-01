using EternaProject.Models;

namespace EternaProject.ViewModels
{
    public class BlogDetailVm
    {
        public Blog Blog { get; set; }
        public List<Blog> BlogsRecents { get; set; }
        public List<Category> Categories { get; set; }
    }
}
