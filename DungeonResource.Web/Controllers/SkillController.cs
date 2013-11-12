using DungeonResource.Components.Domain.Skill;
using DungeonResource.Components.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DungeonResource.Web.Controllers
{
    public class SkillController : Controller
    {
        private readonly IGenericRepository<Skill> _genericRepository;

        /// <summary>
        ///     ctor
        /// </summary>
        public SkillController(IGenericRepository<Skill> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        //
        // GET: /Skill/
        public ActionResult Index()
        {
            var skills = _genericRepository.Read();

            return View(skills);
        }
	}
}