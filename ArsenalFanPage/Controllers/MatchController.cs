using ArsenalFanPage.Data;
using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.ComponentModel;

namespace ArsenalFanPage.Controllers
{
    public class MatchController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public MatchController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            IEnumerable<Match> objMatchList = _unitOfWork.Match.GetAll();
            return View(objMatchList);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Match obj, IFormFile? file1, IFormFile? file2)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;


                if (file1 != null && file2 != null)
                {
                    string fileName1 = Guid.NewGuid().ToString();
                    var uploads1 = Path.Combine(wwwRootPath, @"images\match");
                    var extension1 = Path.GetExtension(file1.FileName);

                    using (var fileStreams1 = new FileStream(Path.Combine(uploads1, fileName1 + extension1), FileMode.Create))
                    {
                        file1.CopyTo(fileStreams1);
                    }
                    obj.LogoTeam1 = @"\images\match\" + fileName1 + extension1;


                    string fileName2 = Guid.NewGuid().ToString();
                    var uploads2 = Path.Combine(wwwRootPath, @"images\match");
                    var extension2 = Path.GetExtension(file2.FileName);

                    using (var fileStreams2 = new FileStream(Path.Combine(uploads2, fileName2 + extension2), FileMode.Create))
                    {
                        file2.CopyTo(fileStreams2);
                    }
                    obj.LogoTeam2 = @"\images\match\" + fileName2 + extension2;
                }
                _unitOfWork.Match.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Match created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var matchFromDbFirst = _unitOfWork.Match.GetFirstOrDefault(u => u.Id == id);
            if (matchFromDbFirst == null)
            {
                return NotFound();
            }
            return View(matchFromDbFirst);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Match obj, IFormFile? file1, IFormFile? file2)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                if (file1 != null && file2 != null)
                {
                    string fileName1 = Guid.NewGuid().ToString();
                    var uploads1 = Path.Combine(wwwRootPath, @"images\match");
                    var extension1 = Path.GetExtension(file1.FileName);

                    if (obj.LogoTeam1 != null)
                    {
                        var oldImagePath1 = Path.Combine(wwwRootPath, obj.LogoTeam1.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath1))
                        {
                            System.IO.File.Delete(oldImagePath1);
                        }
                    }
                    using (var fileStreams1 = new FileStream(Path.Combine(uploads1, fileName1 + extension1), FileMode.Create))
                    {
                        file1.CopyTo(fileStreams1);
                    }
                    obj.LogoTeam1 = @"\images\match\" + fileName1 + extension1;


                    string fileName2 = Guid.NewGuid().ToString();
                    var uploads2 = Path.Combine(wwwRootPath, @"images\match");
                    var extension2 = Path.GetExtension(file2.FileName);

                    if (obj.LogoTeam2 != null)
                    {
                        var oldImagePath2 = Path.Combine(wwwRootPath, obj.LogoTeam2.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath2))
                        {
                            System.IO.File.Delete(oldImagePath2);
                        }
                    }
                    using (var fileStreams2 = new FileStream(Path.Combine(uploads2, fileName2 + extension2), FileMode.Create))
                    {
                        file1.CopyTo(fileStreams2);
                    }
                    obj.LogoTeam2 = @"\images\match\" + fileName2 + extension2;
                }
                _unitOfWork.Match.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Match updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var matchFromDbFirst = _unitOfWork.Match.GetFirstOrDefault(u => u.Id == id);
            if (matchFromDbFirst == null)
            {
                return NotFound();
            }
            return View(matchFromDbFirst);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _unitOfWork.Match.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            var oldImagePath1 = Path.Combine(_hostEnvironment.WebRootPath, obj.LogoTeam1.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath1))
            {
                System.IO.File.Delete(oldImagePath1);
            }

            var oldImagePath2 = Path.Combine(_hostEnvironment.WebRootPath, obj.LogoTeam2.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath2))
            {
                System.IO.File.Delete(oldImagePath2);
            }

            _unitOfWork.Match.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Match deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
