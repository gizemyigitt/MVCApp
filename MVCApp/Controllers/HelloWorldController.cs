using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>(); 
        public IActionResult Index()
        {
            //Index sayfamıza oluşturacağımız bütün dogs bilgilerini yollayacağız
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();//burada boş bir model oluşturup sayfa açılır açılmaz bu modeli create sayfamıza yolladık
            return View(dogVm);
        }
        public IActionResult CreateDog(DogViewModel dogViewModel)//formda doldurulan bilgiler başta gelen boş modele yazıldı ve createdog methoduna post edildi
        {
            dogs.Add(dogViewModel);//yeni köpeği listeye ekledik ve bu listeyi de ındex sayfasına gönderdik
            return RedirectToAction(nameof(Index));
        }
    }
}
