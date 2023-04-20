using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ArsenalFanPage.Controllers
{
	public class NewsListController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		public NewsListController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public IActionResult Index()
		{
			IEnumerable<News> newsList = _unitOfWork.News.GetAll();
			return View(newsList);
		}
	}
}
