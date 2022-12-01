using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace learning_asp_net_mvc_core.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }
        
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}