using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ArsenalFanPage.Controllers
{
	public class MatchListController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		public MatchListController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public IActionResult Index()
		{
			IEnumerable<Match> matchList = _unitOfWork.Match.GetAll();
			return View(matchList);
		}
	}
}
