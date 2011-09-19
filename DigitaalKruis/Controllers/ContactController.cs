using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DigitaalKruis;
using DigitaalKruis.Models;

namespace DigitaalKruis.Controllers
{ 
    public class ContactController : Controller
    {
        private KaartenbakEntities db = new KaartenbakEntities();

        //
        // GET: /Contact/

        public ViewResult Index()
        {
            return View(db.Contacts.ToList());
        }

        //
        // GET: /Contact/Details/5

        public ViewResult Details(int id)
        {
            Contact contact = db.Contacts.Single(c => c.ContactID == id);
            return View(contact);
        }

        //
        // GET: /Contact/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Contact/Create

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.AddObject(contact);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(contact);
        }
        
        //
        // GET: /Contact/Edit/5
 
        public ActionResult Edit(int id)
        {
            Contact contact = db.Contacts.SingleOrDefault(c => c.ContactID == id);
            return View(contact);
        }

        //
        // POST: /Contact/Edit/5

        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Attach(contact);
                db.ObjectStateManager.ChangeObjectState(contact, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        //
        // GET: /Contact/Delete/5
 
        public ActionResult Delete(int id)
        {
            Contact contact = db.Contacts.Single(c => c.ContactID == id);
            return View(contact);
        }

        //
        // POST: /Contact/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Contact contact = db.Contacts.Single(c => c.ContactID == id);
            db.Contacts.DeleteObject(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}