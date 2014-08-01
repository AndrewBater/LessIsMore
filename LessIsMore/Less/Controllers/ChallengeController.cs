using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Less.Models;

namespace Less.Controllers
{
    public class ChallengeController : Controller
    {
        public ActionResult List()
        {
            var challengeList = GetChallengesFor();
            return View(challengeList);
        }

        public ActionResult Suggest()
        {
            return View();
        }

        private List<ChallengeModel> GetChallengesFor()
        {
            List<ChallengeModel> challenges = new List<ChallengeModel>();
            challenges.Add(createChallengeModel("Recycle Batteries", "Do this with batteries"));
            challenges.Add(createChallengeModel("Cook a local meal", "Try creating a meal with entirely locally sourced products."));
            return challenges;
        }

        private ChallengeModel createChallengeModel(string title, string description)
        {
            ChallengeModel challenge = new ChallengeModel();
            challenge.Title = title;
            challenge.Description = description;
            return challenge;
        }
    }
}