using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KrzysztofJopekLab6ZadanieDomowe.Models;

namespace KrzysztofJopekLab6ZadanieDomowe.Controllers
{
    public class HomeController : Controller
    {
        List<BallerViewModel> ballers;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            // Lista koszykarzy
            ballers = new List<BallerViewModel>();

            // Dodanie koszykarzy
            ballers.Add(new BallerViewModel("LeBron", "James", "30 Grudzień 1984", "Los Angeles Lakers","Niski skrzydłowy - SF", "~/Content/Images/LeBron.jpg"));
            ballers.Add(new BallerViewModel("Stephen", "Curry", "14 Marzec 1988", "Golden State Warriors", "Rozgrywający - PG", "~/Content/Images/Curry.jpg"));
            ballers.Add(new BallerViewModel("Michael", "Jordan", "17 Luty 1963", "Washington Wizards", "Rzucający obrońca - SG", "~/Content/Images/Jordan.jpg"));
            ballers.Add(new BallerViewModel("Larry", "Bird", "7 Grudzień 1956", "Boston Celtics", "Silny skrzydłowy - PF", "~/Content/Images/Bird.jpg"));
        }

        public IActionResult Index()
        {
            return View();
        }
        // Widok pokazujący wszystkich koszykarzy
        public IActionResult GetAllBallers()
        {
            return View(ballers);
        }
        // Widok pierwszego pytania
        [HttpGet]
        public IActionResult QuizFirstQuestion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult QuizFirstQuestionPost(QuizViewModel quizViewModel)
        {
            quizViewModel.CorrectAnswers = 0;
            return RedirectToAction("QuizSecondQuestion", quizViewModel);
        }
        // Widok drugiego pytania
        [HttpGet]
        public IActionResult QuizSecondQuestion(QuizViewModel quizViewModel)
        {
           if(quizViewModel.Answer == "Toronto Raptors")
            {
                quizViewModel.CorrectAnswers++;
            }
            return View(quizViewModel);
        }
        [HttpPost]
        public IActionResult QuizSecondQuestionPost(QuizViewModel quizViewmodel)
        {
        
            return RedirectToAction("QuizThirdQuestion", quizViewmodel);
        }
        // Widok trzeciego pytania
        [HttpGet]
        public IActionResult QuizThirdQuestion(QuizViewModel quizViewModel)
        {
            if (quizViewModel.Answer == "Boston Celtics")
            {
                quizViewModel.CorrectAnswers++;
            }
            string y = quizViewModel.Answer;
            int z = quizViewModel.CorrectAnswers;
            return View(quizViewModel);
        }
        [HttpPost]
        public IActionResult QuizThirdQuestionPost(QuizViewModel quizViewModel)
        {

            return RedirectToAction("Summary", quizViewModel);
        }
        // Widok podsumowania
        [HttpGet]
        public IActionResult Summary(QuizViewModel quizViewModel)
        {
            if (quizViewModel.Answer == "Stephen Curry")
            {
                quizViewModel.CorrectAnswers++;
            }
            return View(quizViewModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
