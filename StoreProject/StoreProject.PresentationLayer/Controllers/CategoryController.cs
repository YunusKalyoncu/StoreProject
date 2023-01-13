using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StoreProject.BusinessLayer.Abstract;
using StoreProject.DataAccessLayer.EntityFramework;
using StoreProject.DTOLayer.CategoryDtos;
using StoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
           _categoryService.TInsert(category);
            return RedirectToAction("Index");

        }
        public IActionResult DeleteCategory(int id)
        {
            var values = _categoryService.TGetByID(id);
            _categoryService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = _categoryService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult AddCategory2()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult AddCategory2(CreateCategoryDto createCategoryDto)
        {
            if (ModelState.IsValid)
            {
                _categoryService.TInsert(new Category()
                {
                    CategoryName = createCategoryDto.CategoryName,
                    CategoryDescription = createCategoryDto.CategoryDescription

                });
                return RedirectToAction("Index");
            }

            return View(createCategoryDto);

        }
    }
}
