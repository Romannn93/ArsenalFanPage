using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ArsenalFanPage.Controllers
{
	public class MatchDetailsController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IWebHostEnvironment _hostEnvironment;

		public MatchDetailsController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
		{
			_unitOfWork = unitOfWork;
			_hostEnvironment = hostEnvironment;
		}
		public IActionResult Index(int matchId/*, string includeProperties*/)
		{
			DetailsMatch detailsMatchObj = new()
			{
				MatchId = matchId,
				Match = _unitOfWork.Match.GetFirstOrDefault(u => u.Id == matchId/*, includeProperties: "Match"*/)
			};
			return View(detailsMatchObj);
		}
	}
}
