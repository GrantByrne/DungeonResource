using DungeonResource.Components.Domain.Book;
using DungeonResource.Components.Domain.Spell;
using DungeonResource.Components.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DungeonResource.Web.Controllers
{
    public class SpellController : Controller
    {
        private ISpellService _spellService;

        public SpellController(ISpellService spellService)
        {
            _spellService = spellService;
        }

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

        [HttpGet]
        public ActionResult Create()
        {
            if (Request.IsAuthenticated)
            {
                var someSpell = new Spell();
                someSpell.SpellLevels = new List<SpellLevel>
                {
                    new SpellLevel { SpellClass = "Wizard", Level = 1}
                };
                someSpell.Range = SpellRange.Self;
                return View(someSpell);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Create(Spell value)
        {
            // Check if the user is logged in
            if (Request.IsAuthenticated)
            {
                // Clean up the spell input
                foreach (var someClass in value.SpellLevels)
                {
                    someClass.SpellClass = someClass.SpellClass.TrimEnd(" ".ToCharArray());
                    someClass.SpellClass = someClass.SpellClass.TrimStart(" ".ToCharArray());
                }

                // Enter in the user data who created the spell
                value.Editor = User.Identity.Name;
                value.LastEdited = DateTime.Now;

                // Add the spell to the database
                _spellService.CreateSpell(value);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            if (Request.IsAuthenticated)
            {
                var someSpell = _spellService.ReadSpell(id);
                return View(someSpell);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(Spell value)
        {
            if (Request.IsAuthenticated)
            {
                // Clean up the spell input
                foreach (var someClass in value.SpellLevels)
                {
                    someClass.SpellClass = someClass.SpellClass.TrimEnd(" ".ToCharArray());
                    someClass.SpellClass = someClass.SpellClass.TrimStart(" ".ToCharArray());
                }

                // Enter in the user data who created the spell
                value.Editor = User.Identity.Name;
                value.LastEdited = DateTime.Now;

                _spellService.UpdateSpell(value);
                return View(value);
                }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (Request.IsAuthenticated)
            {
                _spellService.DeleteSpell(id);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddReference(Spell spell)
        {
            return View(spell);
        }

        [HttpPost]
        public ActionResult AddReference(Spell spell, Reference reference)
        {
            // Check if the user is logged in
            if (Request.IsAuthenticated)
            {
                // Validate reference
                if (true)
                {
                    // Add reference to spell
                    spell.BookReferences.Add(reference);

                    // Update spell in database
                    _spellService.UpdateSpell(spell);

                    // Send the user back to the details page to see their update
                    return RedirectToAction("Details", spell.Id);
                }
                else
                {
                    // If the reference is not valid,
                    // report it to the user
                    return View();
                }
            }

            return RedirectToAction("Index");
        }
	}
}