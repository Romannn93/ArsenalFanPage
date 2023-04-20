using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ArsenalFanPage.Controllers
{
	public class DetailsHistoryController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IWebHostEnvironment _hostEnvironment;

		public DetailsHistoryController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
		{
			_unitOfWork = unitOfWork;
			_hostEnvironment = hostEnvironment;
		}
		public IActionResult Index(int historyId)
		{
			DetailsHistory detailsObj = new()
			{
				HistoryId = historyId,
				History = _unitOfWork.History.GetFirstOrDefault(u => u.Id == historyId),
			};
			return View(detailsObj);
		}
	}
}
