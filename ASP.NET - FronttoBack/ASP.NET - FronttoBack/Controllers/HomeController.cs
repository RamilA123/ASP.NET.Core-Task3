using ASP.NET___FronttoBack.Models;
using ASP.NET___FronttoBack.ViewModels;
using ASP.NET___FronttoBack.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.NET___FronttoBack.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Slider> sliders = _context.Sliders.ToList();
            IEnumerable<Feature> features = _context.Features.ToList();
            IEnumerable<Service> services = _context.Services.ToList();
            IEnumerable<Project> projects = _context.Projects.ToList();
            IEnumerable<Expert> experts = _context.Experts.ToList();
            IEnumerable<Client> clients = _context.Clients.ToList();

            HomeVm model = new()
            {   
                Sliders = sliders,
                Services = services,
                Features = features,
                Projects = projects,
                Experts = experts,
                Clients = clients
            };


            return View(model);

            //List<Service> services = GetAllServices();
            //List<Feature> features = GetAllFeatures();
            //List<Project> projects = GetAllProjects();
            //List<Expert> experts = GetAllExperts();
            //List<Client> clients = GetAllClients();


         

        }

        //private List<Service> GetAllServices()
        //{
        //    Service service1 = new()
        //    {
        //        Id = 1,
        //        Icon = "icon-5.png",
        //        Title = "Digital Marketing - title",
        //        Description = "Digital Marketing - description"
        //    };

        //    Service service2 = new()
        //    {
        //        Id = 2,
        //        Icon = "icon-6.png",
        //        Title = "Internet Marketing - title",
        //        Description = "Internet Marketing - description"
        //    };

        //    Service service3 = new()
        //    {
        //        Id = 3,
        //        Icon = "icon-7.png",
        //        Title = "Content Marketing - title",
        //        Description = "Content Marketing - description"
        //    };

        //    Service service4 = new()
        //    {
        //        Id = 4,
        //        Icon = "icon-8.png",
        //        Title = "Social Marketing - title",
        //        Description = "Social Marketing - description"
        //    };

        //    Service service5 = new()
        //    {
        //        Id = 5,
        //        Icon = "icon-9.png",
        //        Title = "B2B Marketing - title",
        //        Description = "B2B Marketing - description"
        //    };

        //    Service service6 = new()
        //    {
        //        Id = 6,
        //        Icon = "icon-10.png",
        //        Title = "E-mail Marketing - title",
        //        Description = "E-mail Marketing - description"
        //    };

        //    List<Service> services = new List<Service>() { service1, service2, service3, service4, service5, service6 };
        //    return services;
        //}
        //private List<Feature> GetAllFeatures()
        //{
        //    Feature feature1 = new()
        //    {
        //        Id = 1,
        //        Icon = "icon-1.png",
        //        Title = "Award Winning - title",
        //        Description = "Award - description"
        //    };

        //    Feature feature2 = new()
        //    {
        //        Id = 2,
        //        Icon = "icon-2.png",
        //        Title = "Professional Staff - title",
        //        Description = "Professional - description"
        //    };

        //    Feature feature3 = new()
        //    {
        //        Id = 3,
        //        Icon = "icon-3.png",
        //        Title = "Fair Prices - title",
        //        Description = "Fair Prices - description"
        //    };

        //    Feature feature4 = new()
        //    {
        //        Id = 4,
        //        Icon = "icon-4.png",
        //        Title = "24/7 Support - title",
        //        Description = "24/7 Support - description"
        //    };

        //    List<Feature> features = new List<Feature>() { feature1,feature2,feature3,feature4 };
        //    return features;
        //}
        //private List<Project> GetAllProjects()
        //{
        //    Project project1 = new()
        //    {
        //        Id = 1,
        //        Image = "project-1.jpg",
        //        Title = "Data Analytics & Insights - title",
        //        Description = "Data Analytics & Insights - description"
        //    };

        //    Project project2 = new()
        //    {
        //        Id = 2,
        //        Image = "project-2.jpg",
        //        Title = "Marketing Content Strategy - title",
        //        Description = "Marketing Content Strategy - description"
        //    };

        //    Project project3 = new()
        //    {
        //        Id = 3,
        //        Image = "project-3.jpg",
        //        Title = "Social Marketing Strategy - title",
        //        Description = "Social Marketing Strategy - description"
        //    };

        //    Project project4 = new()
        //    {
        //        Id = 4,
        //        Image = "project-4.jpg",
        //        Title = "Business Target Market - title",
        //        Description = "Business Target Market - description"
        //    };

        //    List<Project> projects = new List<Project>() { project1, project2, project3, project4, project1, project2, project3, project4, project1, project2 };
        //    return projects;
        //}
        //private List<Expert> GetAllExperts()
        //{
        //    Expert expert1 = new()
        //    {
        //        Id = 1,
        //        Image = "team-1.jpg",
        //        Name = "Alex Robin - name",
        //        Position = "Founder & CEO - position"
        //    };

        //    Expert expert2 = new()
        //    {
        //        Id = 2,
        //        Image = "team-2.jpg",
        //        Name = "Adam Crew - name",
        //        Position = "Co Founder - position"
        //    };

        //    Expert expert3 = new()
        //    {
        //        Id = 3,
        //        Image = "team-3.jpg",
        //        Name = "Boris Johnson - name",
        //        Position = "Executive Manager - position"
        //    };

        //    Expert expert4 = new()
        //    {
        //        Id = 4,
        //        Image = "team-4.jpg",
        //        Name = "Robert Jordan - name",
        //        Position = "Digital Marketer - position"
        //    };

        //    List<Expert> experts = new List<Expert>() { expert1, expert2, expert3, expert4 };
        //    return experts;
        //}
        //private List<Client> GetAllClients()
        //{
        //    Client client1 = new()
        //    {
        //        Id = 1,
        //        Image = "testimonial-1.jpg",
        //        Description = "Jessica Office Manager - description",
        //        Name = "Jessica - name",
        //        Position = "Office Manager - position"

        //    };

        //    Client client2 = new()
        //    {
        //        Id = 2,
        //        Image = "testimonial-2.jpg",
        //        Description = "Alex Sales Manager - description",
        //        Name = "Alex - name",
        //        Position = "Sales Manager - position"

        //    };

        //    Client client3 = new()
        //    {
        //        Id = 3,
        //        Image = "testimonial-3.jpg",
        //        Description = "John Public relations - description",
        //        Name = "John - name",
        //        Position = "Public relations - position"

        //    };

        //    Client client4 = new()
        //    {
        //        Id = 4,
        //        Image = "testimonial-4.jpg",
        //        Description = "Jane Finance - description",
        //        Name = "Jane - name",
        //        Position = "Finance - position"

        //    };

        //    List<Client> clients = new List<Client>() { client1, client2, client3, client4, client1, client2, client3, client4 };
        //    return clients;
        //}
    }
}