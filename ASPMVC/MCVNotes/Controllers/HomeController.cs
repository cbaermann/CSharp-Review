using Microsoft.AspNetCore.Mvc;
namespace MCVNotes
{
    public class HomeController : Controller
    {
        //Requests
        //Localhost:5000
        [HttpGet("")]
        public string Index()
        {
            return "Hello From Controller";
        }

        //localhost:5000/hello
        [HttpGet("hello")]
        public string Hello()
        {
            return "Hi Again";
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