using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ArsenalFanPage.Controllers
{
	public class HistoryListController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		public HistoryListController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public IActionResult Index()
		{
			IEnumerable<History> historyList = _unitOfWork.History.GetAll();
			return View(historyList);
		}
	}
}
