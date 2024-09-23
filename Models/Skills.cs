namespace DEPI_MVC.Models
{
    public class Skills
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        List<Skills> skills { get; set; }
    }
}
