using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebStore.DAL;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        private DataContext db = new DataContext();
        public ActionResult Index()
        {
            ProductsViewModel blerg = new ProductsViewModel();
            blerg.db = db;
            blerg.products = db.Products.ToList();
            blerg.categories = db.Categories.ToList();
            blerg.SelectedID = 0;
            return View(blerg);
        }

        public ActionResult Category(int? id)
        {
            ProductsViewModel blerg = new ProductsViewModel();
            blerg.db = db;
            blerg.products = (from item in db.Products where item.CategoriesID == id.Value select item);
            blerg.categories = db.Categories.ToList();
            blerg.SelectedID = id.Value;
         
            return View("Index", blerg);
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }
            Products product = (from item in db.Products
                                where item.ID == id.Value
                                select item).SingleOrDefault();
            if (product == null)
            {
                return View("Notfound");
            }
            return View(product);
        }

        // GET: Products/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoriesID = new SelectList(db.Categories, "ID", "name");
            return View();
        }
        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Products products)
        {
            if(ModelState.IsValid)
            {
                db.Products.Add(products);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categoriesID = new SelectList(db.Categories, "ID", "Name", products.CategoriesID);
            return View(products);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("Notfound");
            }
            Products product = db.Products.Find(id);
            if (product == null)
            {
                return View("Notfound");
            }

            ViewBag.categoriesID = new SelectList(db.Categories, "ID", "Name", product.CategoriesID);
            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection collection)
        {
            Products product = db.Products.Find(id);
            if (ModelState.IsValid)
            {
                UpdateModel(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }
        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                Products product = db.Products.Find(id);
                db.Products.Remove(product);
                db.SaveChanges();
                
            }
            return RedirectToAction("Index");

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
        public ActionResult Notfound()
        {
            return View();
        }

    }
}
