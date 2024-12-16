using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class HomeController : Controller
{
    

/*public string Index(){
    
    return "home/index";

}
public string Contect(){
    
    return "hoşgeldnız contect";
}
*/
public IActionResult Index(){
    return View(Repository.Courses);
}

public IActionResult Contact() {

    return View();
    //return View(CourseList) eğer view dosyası bu adda olsaydı döndercekti aynı ad olması lazım içi boş CourseListi çalıştırmaz
}
}
