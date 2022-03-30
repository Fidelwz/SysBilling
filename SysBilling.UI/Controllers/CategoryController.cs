using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SysBilling.UI.Models;
using SysBilling.EL;
using SysBilling.BL;


namespace SysBilling.UI.Controllers
{
    public class CategoryController : Controller
    {








        private CategoryBL _context = new CategoryBL();
        // GET: CategoryController1
        [HttpGet]
        public ActionResult Index()
        {
            return View(_context.serchCategoryWhithoutRepeating());
        }

        // GET: CategoryController1/Details/5
        private CategoryBL _categoryBL = new CategoryBL();
        public ActionResult Details(int id)
        {



            return View(_categoryBL.SerhCategoryById(id));

        }

        // GET: CategoryController1/Create
        [HttpGet]
        public ActionResult Create(int id)
        {
            return View();
        }

        // POST: CategoryController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category, IFormFile FileUpload)
        {
            try
            {

                category.ImageURL = FileViewModel.SaveFile(FileUpload);
                if (!ModelState.IsValid)
                {


                    _categoryBL.AddSingleCategory(category);
                    return RedirectToAction(nameof(Index));

                }
                return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            try
            {

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
