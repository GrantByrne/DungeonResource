using DungeonResource.Components.Domain.Book;
using DungeonResource.Components.Domain.Spell;
using DungeonResource.Components.Service.Abstract;
using DungeonResource.Web.Models.User;
using SimpleCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DungeonResource.Web.Controllers
{
    public class UserController : Controller
    {

        private readonly ICryptoService _cryptoService;
        private readonly IUserService _userService;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="cryptoService"></param>
        /// <param name="userservice"></param>
        public UserController(ICryptoService cryptoService, IUserService userservice)
        {
            _cryptoService = cryptoService;
            _userService = userservice;
        }

        public ActionResult Register()
        {
            //return View();

            // Added to eliminate open registration
            return RedirectToAction("Index", "Spell");
        }

        [HttpPost]
        public ActionResult Register(RegistrationViewModel userDetails)
        {
            //if(ModelState.IsValid && !_userService.UserExists(userDetails.Username))
            //{
            //    // Generate a password hash plus the salt
            //    var hashedPassword = _cryptoService.Compute(userDetails.Password);
            //    var passwordSalt = _cryptoService.Salt;

            //    // Transfer the view Model data to a domain object
            //    var user = new User
            //    {
            //        Username = userDetails.Username,
            //        Email = userDetails.EMail,
            //        DateCreated = DateTime.Now,
            //        DateLastLogin = DateTime.Now,
            //        PasswordHash = hashedPassword,
            //        PasswordSalt = passwordSalt
            //    };

            //    // Add the user to the database
            //    _userService.CreateUser(user);

            //    // Set up a cookie verifying the user is logged in
            //    FormsAuthentication.SetAuthCookie(user.Username, true);

            //    return RedirectToAction("Index", "Spell");
            //}

            //return View(userDetails);

            // Added to eliminate open registration
            return RedirectToAction("Index", "Spell");
        }

        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LogInViewModel userDetails)
        {
            var valid = _userService.AuthenticateUser(userDetails.Username, userDetails.Password);

            if (valid)
            {
                // Set up a cookie verifying the user is logged in
                FormsAuthentication.SetAuthCookie(userDetails.Username, true);

                return RedirectToAction("Index", "Spell");
            }

            return View(userDetails);
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Spell");
        }
    }
}