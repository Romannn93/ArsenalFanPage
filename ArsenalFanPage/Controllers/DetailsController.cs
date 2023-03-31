using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ArsenalFanPage.Controllers
{
	public class DetailsController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IWebHostEnvironment _hostEnvironment;

		public DetailsController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
		{
			_unitOfWork = unitOfWork;
			_hostEnvironment = hostEnvironment;
		}
		public IActionResult Index(int playerId)
		{
			DetailsPlayer detailsObj = new()
			{
				PlayerId = playerId,
				Player = _unitOfWork.Player.GetFirstOrDefault(u => u.Id == playerId),
			};
			return View(detailsObj);
		}
	}
}
