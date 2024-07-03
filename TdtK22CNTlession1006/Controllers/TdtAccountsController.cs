using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TdtK22CNTlession1006.Models;

namespace TdtK22CNTlession1006.Controllers
{
    public class TdtAccountsController : Controller
    {
        private TdtK22CNT3lession1006Entities db = new TdtK22CNT3lession1006Entities();

        // GET: TdtAccounts
        public ActionResult Index()
        {
            return View(db.TdtAccount.ToList());
        }

        // GET: TdtAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtAccount tdtAccount = db.TdtAccount.Find(id);
            if (tdtAccount == null)
            {
                return HttpNotFound();
            }
            return View(tdtAccount);
        }

        // GET: TdtAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TdtAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TdtID,TdtUserName,TdtPassword,TdtFullName,TdtEmail,TdtPhone,TdtActive")] TdtAccount tdtAccount)
        {
            if (ModelState.IsValid)
            {
                db.TdtAccount.Add(tdtAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tdtAccount);
        }

        // GET: TdtAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtAccount tdtAccount = db.TdtAccount.Find(id);
            if (tdtAccount == null)
            {
                return HttpNotFound();
            }
            return View(tdtAccount);
        }

        // POST: TdtAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TdtID,TdtUserName,TdtPassword,TdtFullName,TdtEmail,TdtPhone,TdtActive")] TdtAccount tdtAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tdtAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tdtAccount);
        }

        // GET: TdtAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtAccount tdtAccount = db.TdtAccount.Find(id);
            if (tdtAccount == null)
            {
                return HttpNotFound();
            }
            return View(tdtAccount);
        }

        // POST: TdtAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TdtAccount tdtAccount = db.TdtAccount.Find(id);
            db.TdtAccount.Remove(tdtAccount);
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
        public ActionResult TdtLogin ()
        {
            var tdtModel = new TdtAccount();
            return View(tdtModel);
        }
        [HttpPost]
        public ActionResult TdtLogin(TdtAccount tdtAccount)
        {
            var tdtCheck = db.TdtAccount.Where(x =>x.TdtUserName.Equals(tdtAccount.TdtUserName) && x.TdtPassword.Equals(tdtAccount.TdtPassword)).FirstOrDefault();
            if (tdtCheck != null)
            {
                Session["TdtAccount"] = tdtCheck;
                return Redirect("/");
            }
            return View(tdtAccount);
        }
    }
}
