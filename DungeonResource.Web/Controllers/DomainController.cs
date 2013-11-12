using DungeonResource.Components.Domain.Domain;
using DungeonResource.Components.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DungeonResource.Web.Controllers
{
    public class DomainController : Controller
    {

        private readonly IGenericRepository<Domain> _genericRepository;

        /// <summary>
        ///     ctor
        /// </summary>
        public DomainController(IGenericRepository<Domain> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        //
        // GET: /Domain/
        public ActionResult Index()
        {
            var domains = _genericRepository.Read();

            return View(domains);
        }
	}
}