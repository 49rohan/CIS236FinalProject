using CIS236FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS236FinalProject.Controllers
{
    public class LeaderboardController : Controller
    {
        private readonly GameDBContext _context;

        public LeaderboardController(GameDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var leaderboard = _context.Teams.OrderByDescending(t => t.Characters.Sum(c => c.Attack))
                .Select(t => new
                {
                    TeamName = t.Name,
                    TotalAttack = t.Characters.Sum(c => c.Attack)
                }).ToList();

            ViewData["Leaderboard"] = leaderboard;

            return View();
                   
        }
    }
}
