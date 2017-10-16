using gymNotebook.Concrete;
using gymNotebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gymNotebook.Controllers
{
    public class HomeController : Controller
    {
        private TrainingContext db = new TrainingContext();

        public ActionResult Index()
        {
            //var training = new Training { TrainingName = "Push-Pull" };
            //var monSession = new TrainingSession { SessionName = "Poniedziałek" };
            //var wenSession = new TrainingSession { SessionName = "Środa" };

            //var podciaganie = new Exercise { ExerciseName = "Podciąganie" };
            //var plecy = new MusclePart { MuscleName = "Plecy" };


            //// plecy.Exercises.Add(plecy);
            //training.TrainingSessions.Add(monSession);
            //training.TrainingSessions.Add(wenSession);
            //monSession.Exercises.Add(podciaganie);
            //db.Trainings.Add(training);
            //db.SaveChanges();
            return View();
        }
    }
}