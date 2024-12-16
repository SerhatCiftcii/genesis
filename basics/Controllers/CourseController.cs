using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController: Controller{
    public  IActionResult  Index ()
    {
      var kurs=new Course();
      kurs.Id=1;
      kurs.Title="Asp.net kursu";
      kurs.Description="Güzel bir kurs";
      kurs.Image="1.jpg";
   return View(kurs);
   }
    /*   public  IActionResult  Details (int id)
    {
      var kurs =Repository.GetById(id);
      return View(kurs);

   }*/
       public  IActionResult  Details (int? id) //2.seçenek id isteğe bağlı Repstry ve burdaki id ? koyarak bi yönlendirme yapabiliriz program cs maproute kısmındada zaten ?id var üstteki gibide olabilir böylede ama modeldeki id'yede ?koycaz
    {
      if(id==null){
       // return Redirect("/course/list");
         return RedirectToAction("List","Course"); //2.yontem  
      }
      var kurs =Repository.GetById(id);
      return View(kurs);

   } 

   public  IActionResult  List ()
   {
    /*  var kurslar=new List<Course>()
      {
         new Course () {Id=1, Title="ASPNET KURSU",Description="güzel bir kurs",Image="1.jpg"},
         new Course () {Id=2, Title="php KURSU",Description="güzel bir kurs",Image="2.jpg"},
         new Course () {Id=3, Title="django KURSU",Description="güzel bir kurs",Image="3.jpg"}
      }; 
      return View(kurslar); */ //artık buna ihtiyacımız yok Repostry.csden alcaz

      return View(Repository.Courses);

 }

}