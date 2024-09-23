namespace DEPI_MVC.Models
{
    public class Projects
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public string link { get; set; }
        public string Image { get; set; }

        List<Projects> projects { get; set; }
    }
}
