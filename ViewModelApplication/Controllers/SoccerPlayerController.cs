using Microsoft.AspNetCore.Mvc;
using ViewModelApplication.Models;
using ViewModelApplication.Models.ViewModel;

namespace ViewModelApplication.Controllers
{
    public class SoccerPlayerController : Controller
    {
        List<Team> teams = new List<Team>()
        {
            new Team {ID=1,Name = "Galatasaray"},
            new Team {ID=2,Name = "Fenerbahçe"},
            new Team {ID=3,Name = "Beşiktaş"},
            new Team {ID=4,Name = "Ankara Gücü"},
            new Team {ID=5,Name = "Trabzon Spor"},
            new Team {ID=6,Name = "Bursa Spor"},
        };
        List<Position> positions = new List<Position>()
        {
            new Position {ID=1, Name="GK"},
            new Position {ID=1, Name="DEF"},
            new Position {ID=1, Name="CM"},
            new Position {ID=1, Name="ST"},
        };
        public IActionResult Index(SoccerPlayer soccerPlayer)
        {
            return View(soccerPlayer);
        }
        public IActionResult Create()
        {
            SoccerPlayerAddVM soccerPlayerVM = new SoccerPlayerAddVM();
            soccerPlayerVM.SoccerPlayer = new SoccerPlayer();
            soccerPlayerVM.Teams = teams;
            soccerPlayerVM.Positions = positions;
            return View(soccerPlayerVM);
        }
        [HttpPost]
        public IActionResult Create(SoccerPlayerAddVM soccerPlayerVM)
        {
            soccerPlayerVM.SoccerPlayer.Team = teams.FirstOrDefault(t => t.ID == soccerPlayerVM.SoccerPlayer.TeamID);
            soccerPlayerVM.SoccerPlayer.Position = positions.FirstOrDefault(t => t.ID == soccerPlayerVM.SoccerPlayer.PositionID);

            return View("Index", soccerPlayerVM.SoccerPlayer);
        }
    }
}
