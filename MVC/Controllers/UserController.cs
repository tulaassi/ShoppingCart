
using MVC.Repository;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebMVC.Models;
 
namespace mvc.Controllers
{
    public class userController : Controller
    {
        // GET: user
        public async Task<ActionResult> Index()
        {
            List<UserViewModel> users = new List<UserViewModel>();
            var service = new ServiceRepository();
            {
                using (var response = service.GetResponse("users"))
                {
                    string apiResponse
                    = await response.Content.ReadAsStringAsync();
                    users = JsonConvert.DeserializeObject
                    <List<UserViewModel>>(apiResponse);
                }
            }
            return View(users);
            return View();
        }
    }
}

