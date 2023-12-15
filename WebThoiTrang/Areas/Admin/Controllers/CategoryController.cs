﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using WebThoiTrang.DataAccess.Repository.IRepository;
using WebThoiTrang.Models;
using WebThoiTrang.Utility;

namespace WebThoiTrang.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Category> categories = _unitOfWork.Category.GetAll().OrderBy(u => u.Id).ToList();
            return View(categories);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Tên Không Được Trùng Với Thứ Tự Hiển Thị!");
            }
            if(ModelState.IsValid)
            {
                _unitOfWork.Category.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Tạo Danh Mục Thành Công";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            Category categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);
            if(categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Tên Không Được Trùng Với Thứ Tự Hiển Thị!");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Cập Nhật Danh Mục Thành Công";
                return RedirectToAction("Index");
            }
            return View();
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Category> categories = _unitOfWork.Category.GetAll().OrderBy(u => u.Id).ToList();
            return Json(new { data = categories });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            Category obj = _unitOfWork.Category.Get(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Lổi Trong Khi Xóa!" });
            }
            _unitOfWork.Category.Remove(obj);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Xóa Thành Công" });
        }
        #endregion
    }
}
