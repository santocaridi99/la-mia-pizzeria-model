using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;


namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            Pizza margherita = new Pizza("Pizza Margherita", "pomodoro , mozzarella campana , basilico", "./img/pizza-margherita-2-6yehdnu31vrv1puavcja7g753ipcgihq8vyh1ifv5pw.jpg",3);
            Pizza capricciosa = new Pizza("Pizza Capricciosa", "Che soddisfa ogni capriccio", "./img/salsicciaepatate.jpg", 4);
            Pizza salsicciaPatate = new Pizza("Pizza Salsiccia e Patate", "salsiccia , patate , mozzarella capana", "./img/salsicciaepatate.jpg", 5);
            Pizza marinara = new Pizza("Pizza Marinara", "Grande classico", "./img/marinara.jpg", 3);
            Pizza quattroStagioni = new Pizza("Pizza Quattro Stagioni", "La quattro Stagioni", "./img/Pizza_Quattro_Stagioni_transparent.png", 4);
            listaPizze pizze = new listaPizze();
            pizze.listaDiPizze.Add(margherita);
            pizze.listaDiPizze.Add(capricciosa);
            pizze.listaDiPizze.Add(salsicciaPatate);
            pizze.listaDiPizze.Add(marinara);
            pizze.listaDiPizze.Add(quattroStagioni);
            return View(pizze);
        }
    }
}