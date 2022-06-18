using H.W12.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace H.W12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new AppDbContext())
            {
                var Blog = new Blog()
                {
                    Name = "test"

                };
                context.Blogs.Add(Blog);
                context.SaveChanges();
            }
            return View();
        }
    }
}