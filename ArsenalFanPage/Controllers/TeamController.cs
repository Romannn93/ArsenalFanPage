using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace ArsenalFanPage.Controllers
{
    public class TeamController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TeamController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Player> playerList = _unitOfWork.Player.GetAll();
            return View(playerList);
        }
    }
}
