using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.DAL;

namespace WebStore.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        private DataContext db = new DataContext();
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        [HttpGet]
        public ActionResult Create()
        {
            //ProductsViewModel model = new ProductsViewModel();
            //model.
            return View();

        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ProductsViewModel model = new ProductsViewModel();

            return View();

        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {

                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            
            return View();
        }
        public List<SelectListItem> getCategories()
        {
            List<SelectListItem> categories = new List<SelectListItem>();
            categories.Add(new SelectListItem() { Value = "", Text = " - Choose category -" });
            db.Categories.ToList().ForEach((x) =>
            {
                categories.Add(new SelectListItem() { Value = x.ID.ToString(), Text = x.name });

            });
            return categories;
        }
    }
}
