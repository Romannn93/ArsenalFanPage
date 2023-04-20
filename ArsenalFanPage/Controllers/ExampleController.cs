using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ArsenalFanPage.Controllers
{
	public class ExampleController : Controller
	{
		private readonly ILogger<ExampleController> _logger;
		private readonly IUnitOfWork _unitOfWork;
		public ExampleController(ILogger<ExampleController> logger, IUnitOfWork unitOfWork)
		{
			_logger = logger;
			_unitOfWork = unitOfWork;
		}
		public IActionResult Indexxx()
		{
			IEnumerable<News> newsList = _unitOfWork.News.GetAll();
			return View(newsList);
		}
	}
}
