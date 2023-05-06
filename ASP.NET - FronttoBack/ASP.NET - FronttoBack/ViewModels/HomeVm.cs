using ASP.NET___FronttoBack.Models;

namespace ASP.NET___FronttoBack.ViewModels
{
    public class HomeVm
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Feature> Features { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<Expert> Experts { get; set; }
        public IEnumerable<Client> Clients { get; set; }
    }
}
