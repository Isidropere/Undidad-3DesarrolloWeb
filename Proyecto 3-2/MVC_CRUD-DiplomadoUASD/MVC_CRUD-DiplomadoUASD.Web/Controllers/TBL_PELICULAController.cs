﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_CRUP_DiplomadoUASD.Models;

namespace MVC_CRUD_DiplomadoUASD.Web.Controllers
{
    public class TBL_PELICULAController : Controller
    {
        private PeliculasDBEntitiesUNO db = new PeliculasDBEntitiesUNO();

        // GET: TBL_PELICULA
        public ActionResult Index()
        {
            return View(db.TBL_PELICULA.ToList());
        }

        public ActionResult ListPeliculas()
        {
            var lista = db.TBL_PELICULA.ToList();
            return View(lista);
        }

        public JsonResult GetListJsonPeliculas()
        {
            var lista = db.TBL_PELICULA.ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        // GET: TBL_PELICULA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PELICULA tBL_PELICULA = db.TBL_PELICULA.Find(id);
            if (tBL_PELICULA == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PELICULA);
        }

        // GET: TBL_PELICULA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TBL_PELICULA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,Titulo,Director,AutorPrincipal,No_Autor,Duracion,Estreno")] TBL_PELICULA tBL_PELICULA)
        {
            if (ModelState.IsValid)
            {
                db.TBL_PELICULA.Add(tBL_PELICULA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tBL_PELICULA);
        }

        // GET: TBL_PELICULA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PELICULA tBL_PELICULA = db.TBL_PELICULA.Find(id);
            if (tBL_PELICULA == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PELICULA);
        }

        // POST: TBL_PELICULA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo,Titulo,Director,AutorPrincipal,No_Autor,Duracion,Estreno")] TBL_PELICULA tBL_PELICULA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_PELICULA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tBL_PELICULA);
        }

        // GET: TBL_PELICULA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PELICULA tBL_PELICULA = db.TBL_PELICULA.Find(id);
            if (tBL_PELICULA == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PELICULA);
        }

        // POST: TBL_PELICULA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TBL_PELICULA tBL_PELICULA = db.TBL_PELICULA.Find(id);
            db.TBL_PELICULA.Remove(tBL_PELICULA);
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
