namespace EternaProject.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descriotion { get; set; }
        public string MainImage { get; set; }
        public string HoverImage { get; set; }
        public string Client { get; set; }
        public DateTime CreateDate{ get; set; }
        public string ProjctURL{ get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProjectImage> ProjectImages { get; set; }
    }
}
