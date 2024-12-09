using CIS236FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CIS236FinalProject.Areas.Battle.Controllers
{
    [Area("Battle")]
    public class BattleController : Controller
    {
        private readonly GameDBContext _context;

        public BattleController(GameDBContext context)
        {
            _context = context;
        }
        public IActionResult Index(int team1Id, int team2Id)
        {
            var team1 = _context.Teams.Include(t => t.Characters).FirstOrDefault(t => t.Id == team1Id);
            var team2 = _context.Teams.Include(t => t.Characters).FirstOrDefault(t => t.Id == team2Id);

            if (team1 == null || team2 == null)
            {
                return NotFound();
            }

            string winner = team1.Characters.Average(c => c.Attack + c.Defense + c.Speed)
                           > team2.Characters.Average(c => c.Attack + c.Defense + c.Speed)
                           ? team1.Name
                           : team2.Name;

            var viewModel = new TeamBattleView
            {
                Team1Name = team1.Name,
                Team2Name = team2.Name,
                Winner = winner
            };

            TempData["Message"] = $"The winner is {winner}!";

            return View(viewModel);
        }
    }
}
