using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class UtilisateurController : Controller
    {
        static IList<Utilisateur> utilisateurList = new List<Utilisateur>{
                new Utilisateur() { UtilisateurId = 1, UtilisateurName = "hasnae", Age = 18 ,document="Relevé de note" } ,
                new Utilisateur() { UtilisateurId = 2, UtilisateurName = "ahlam",  Age = 21 ,document="Relevé de note"} ,
                new Utilisateur() { UtilisateurId = 3, UtilisateurName = "tohami",  Age = 25 ,document="Relevé de note"} ,
                new Utilisateur() { UtilisateurId = 4, UtilisateurName = "chekkouri" , Age = 20 ,document="Relevé de note"} ,
                new Utilisateur() { UtilisateurId = 5, UtilisateurName = "alachhab" , Age = 31 ,document="Relevé de note"} ,
                new Utilisateur() { UtilisateurId = 4, UtilisateurName = "besri" , Age = 17 ,document="Relevé de note"} ,
                new Utilisateur() { UtilisateurId = 4, UtilisateurName = "el younssi" , Age = 19 ,document="Relevé de note"}
            };
        // GET: Student
        public ActionResult Index()
        {
            //fetch students from the DB using Entity Framework here

            return View(utilisateurList);
        }

        [HttpPost]
        public ActionResult PostAction() // handles POST requests by default
        {
            return View("Index");
        }

        public ActionResult Edit(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var std = utilisateurList.Where(s => s.UtilisateurId == Id).FirstOrDefault();

            return View(std);
        }


        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Utilisateur std)
        {

            utilisateurList.Add(std);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Utilisateur std)
        {
            
            var student = utilisateurList.Where(s => s.UtilisateurId == std.UtilisateurId).FirstOrDefault();
            utilisateurList.Remove(student);
            utilisateurList.Add(std);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var std = utilisateurList.Where(s => s.UtilisateurId == Id).FirstOrDefault();
            utilisateurList.Remove(std);

            return RedirectToAction("Index");
            
        }

        [HttpDelete]
        public ActionResult DeleteAction() // handles DELETE requests by default
        {
            return View("Index");
        }
        [HttpHead]
        public ActionResult HeadAction() // handles HEAD requests by default
        {
            return View("Index");
        }
        [HttpOptions]
        public ActionResult OptionsAction() // handles OPTION requests by default
        {
            return View("Index");
        }
        [HttpPatch]
        public ActionResult PatchAction() // handles PATCH requests by default
        {
            return View("Index");
        }
    }
}