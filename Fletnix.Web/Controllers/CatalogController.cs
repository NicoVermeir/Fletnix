using Fletnix.Model;
using Fletnix.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fletnix.Web.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICatalogService _catalogService;

        public CatalogController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        // GET: Catalog
        public ActionResult Index()
        {
            var catalogItems = _catalogService.GetMovies();

            return View(catalogItems);
        }

        // GET: Catalog/Details/5
        public ActionResult Details(int id)
        {
            CatalogItem item = _catalogService.GetById(id);
            return View(item);
        }

        // GET: Catalog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catalog/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CatalogItem item)
        {
            try
            {
                _catalogService.SaveCatalogItem(item);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalog/Edit/5
        public ActionResult Edit(int id)
        {
            CatalogItem item = _catalogService.GetById(id);

            return View(item);
        }

        // POST: Catalog/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CatalogItem item)
        {
            try
            {
                _catalogService.UpdateCatalogItem(item);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalog/Delete/5
        public ActionResult Delete(int id)
        {
            CatalogItem item = _catalogService.GetById(id);
            return View(item);
        }

        // POST: Catalog/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}