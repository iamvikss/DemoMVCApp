using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DemoMVCApp;

namespace DemoMVCApp.Controllers
{
    public class MyHomeController : Controller
    {
        private DemoMVCAppContext db = new DemoMVCAppContext();

        public ActionResult Home()
        {
            return View();
        }

        // GET: /MyHome/
        public ActionResult Index()
        {
            return View(db.MyApplications.ToList());
        }

        // GET: /MyHome/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyApplication myapplication = db.MyApplications.Find(id);
            if (myapplication == null)
            {
                return HttpNotFound();
            }
            return View(myapplication);
        }

        // GET: /MyHome/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /MyHome/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="MyApplicationID,MyApplicationName,LastModifiedDateTime")] MyApplication myapplication)
        {
            if (ModelState.IsValid)
            {
                db.MyApplications.Add(myapplication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myapplication);
        }

        // GET: /MyHome/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyApplication myapplication = db.MyApplications.Find(id);
            if (myapplication == null)
            {
                return HttpNotFound();
            }
            return View(myapplication);
        }

        // POST: /MyHome/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="MyApplicationID,MyApplicationName,LastModifiedDateTime")] MyApplication myapplication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myapplication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myapplication);
        }

        // GET: /MyHome/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyApplication myapplication = db.MyApplications.Find(id);
            if (myapplication == null)
            {
                return HttpNotFound();
            }
            return View(myapplication);
        }

        // POST: /MyHome/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyApplication myapplication = db.MyApplications.Find(id);
            db.MyApplications.Remove(myapplication);
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
    }
}
