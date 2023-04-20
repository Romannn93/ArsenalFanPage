using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ArsenalFanPage.Controllers
{
	public class DetailsNewsController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IWebHostEnvironment _hostEnvironment;

		public DetailsNewsController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
		{
			_unitOfWork = unitOfWork;
			_hostEnvironment = hostEnvironment;
		}
		public IActionResult Index(int newsId)
		{
			DetailsNews detailsObj = new()
			{
				NewsId = newsId,
				News = _unitOfWork.News.GetFirstOrDefault(u => u.Id == newsId),
			};
			return View(detailsObj);
		}
	}
}
