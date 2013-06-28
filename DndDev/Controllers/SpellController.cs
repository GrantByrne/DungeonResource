using System.Web.Mvc;
using DndDev.Service;
using DndDev.Models;

namespace DndDev.Controllers
{
    public class SpellController : Controller
    {

        private ISpellService _spellService = new SpellService();

        public ActionResult Index()
        {
            var someSpells = _spellService.ReadAllSpells();

            return View(someSpells);
        }

        public ActionResult Details(int id)
        {
            var someSpell = _spellService.ReadSpell(id);

            return View(someSpell);
        }

        public ActionResult Create(CreateSpellViewModel someSpell)
        {   
            return View(someSpell);
        }
    }
}
