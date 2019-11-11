using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineMarket.Models;

namespace OnlineMarket.Controllers
{
    public class TrademarksController : Controller
    {
        private MarketContext db = new MarketContext();

        // GET: Trademarks
        public ActionResult Index()
        {
            return View(db.Trademark.ToList());
        }

        // GET: Trademarks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trademark trademark = db.Trademark.Find(id);
            if (trademark == null)
            {
                return HttpNotFound();
            }
            return View(trademark);
        }

        // GET: Trademarks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trademarks/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrademarkID,Name,State")] Trademark trademark)
        {
            if (ModelState.IsValid)
            {
                db.Trademark.Add(trademark);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trademark);
        }

        // GET: Trademarks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trademark trademark = db.Trademark.Find(id);
            if (trademark == null)
            {
                return HttpNotFound();
            }
            return View(trademark);
        }

        // POST: Trademarks/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrademarkID,Name,State")] Trademark trademark)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trademark).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trademark);
        }

        // GET: Trademarks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trademark trademark = db.Trademark.Find(id);
            if (trademark == null)
            {
                return HttpNotFound();
            }
            return View(trademark);
        }

        // POST: Trademarks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trademark trademark = db.Trademark.Find(id);
            db.Trademark.Remove(trademark);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public PartialViewResult _TradeMarkTable(int page = 1, int size =20)
        {
            var query = db.Trademark.Skip((page - 1) * size).Take(size).ToList();
            return PartialView(query);
        }
    }
}
