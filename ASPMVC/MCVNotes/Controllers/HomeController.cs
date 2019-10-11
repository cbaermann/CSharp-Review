using Microsoft.AspNetCore.Mvc;
namespace MCVNotes
{
    public class HomeController : Controller
    {
        //Requests
        //Localhost:5000
        [HttpGet("")]
        public ViewResult Index()
        {
            //Views/Home/HiThere.cshtml (if no input given in return View();)
            return View("Index");
        }

        //localhost:5000/hello
        [HttpGet("hello")]
        public RedirectToActionResult Hello()
        {
            System.Console.WriteLine("Redirect Worked");
            return RedirectToAction("HelloUser", new{username="Devon", location="Seattle"});
        }
        //localhost:5000/users/???
        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username, string location)
        {
            if(location == "Seattle")
                return $"Hello {username} from {location}. Drink Coffee";
            return $"Hello {username} from {location}";
        }
    }
}