using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EO.Internal;
using System.Linq.Dynamic;
using MVC_CRUD_DiplomadoUASDCodeFirst.Model.DAL;
using MVC_CRUD_DiplomadoUASDCodeFirst.Model.Models;
using ClosedXML.Excel;
using System.IO;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Data.Entity.Core.Common.CommandTrees;

namespace MVC_CRUD_DiplomadoAUSDCodeFirst.Web.Controllers
{
    public class EmpleadoesController : Controller
    {


     
        public FileResult ExportarEmpleadosCSV()
        {
            /*-------------------FileResult---------------------*/
            /*Se crea el Objeto ObjEmpleado de tipo EmpleadoContext*/
            EmpleadoContext ObjEmpleado = new EmpleadoContext();
            /*Indicamos las colummas que tendra el archivo genereado por la accion fileResult*/
            DataTable dt = new DataTable("Grid");
            dt.Columns.AddRange(new DataColumn[4]{ new DataColumn("Codigo"),
                                                new DataColumn("Nombre"),
                                                new DataColumn("Apellido"),
                                                new DataColumn("Fecha_Ingreso")
                                                });
            var empleados_A = from Empleado in ObjEmpleado.Empleados
                              where Empleado.Apellidos.Contains("A")
                              select Empleado;

            foreach (var Empleado in empleados_A)
            {
                dt.Rows.Add(Empleado.EmpleadoID,Empleado.Nombre, Empleado.Apellidos, Empleado.Fecha_Ingreso);

            }
            using (XLWorkbook wb= new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using(System.IO.MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","grd.xlsx");
                }
            
            }
             
        }

        private EmpleadoContext db = new EmpleadoContext();

        // GET: Empleadoes
        public ActionResult Index()
        {
            return View(db.Empleados.ToList());
        }

        // GET: Empleadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = db.Empleados.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        // GET: Empleadoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpleadoID,Nombre,Apellidos,Fecha_Ingreso")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.Empleados.Add(empleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empleado);
        }

        // GET: Empleadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = db.Empleados.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        // POST: Empleadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpleadoID,Nombre,Apellidos,Fecha_Ingreso")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }

        // GET: Empleadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = db.Empleados.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        // POST: Empleadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = db.Empleados.Find(id);
            db.Empleados.Remove(empleado);
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
