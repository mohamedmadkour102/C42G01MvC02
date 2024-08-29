using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace AppStructure.Controllers
{
    public class MovieController : Controller
    {
       // Action ==> public - Non Static Function ==> it's Route to reach it Movie/GetMovie

        public /*ContentResult*/ IActionResult GetMovie (int id) 
        {
            //ContentResult result = new ContentResult ();
            //result.Content = $"movie with id = {id}";
            //result.ContentType = "object/pdf" ;
            //result.StatusCode = 200 ;
            

            return Content($"movie with id = {id}" , "txt/html") ; //==> helper method  
        }
        // لما بروح احط 
        // Movie/GetMovie/10 
        // واعمل ديباج واروح اقف على الاي دي مش بيكون ب 10 مثلا

        public IActionResult Index()
        {
            RedirectResult redirect = new RedirectResult ("https://localhost:44310/Movie/GetMovie/10");
            return redirect ;
            //  return Redirect("https://localhost:44310/Movie/GetMovie/10") ; ==> helper method
            // return RedirectToAction(nameof(GetMovie) , new {id = 10}); 3shan maynfa3sh nstakhdem el url bel shakl da 
        }
    }
}
