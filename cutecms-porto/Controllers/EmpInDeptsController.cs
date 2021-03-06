﻿using cutecms_porto.Areas.Identity.Models.DBModel;
using cutecms_porto.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace cutecms_porto.Controllers
{
    [LocalizedAuthorize]
    public class EmpInDeptsController : BaseController
    {
        #region Fields
        private IdentityEntities db = new IdentityEntities();
        private List<object> DepartmentsList = new List<object>();
        #endregion Fields

        #region Methods
        // GET: Identity/EmpInDepts
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                throw new HttpException(400, "Bad Request");
            }
            var empTranslationId = db.Employees.Where(e => e.TranslationId == id && e.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).FirstOrDefault()?.TranslationId;
            if (empTranslationId == null)
                throw new HttpException(602, "Page Not Translated");
            ViewBag.EmpId = id;
            var empInDepts = db.EmpInDepts.Include(e => e.Employee).Where(e => e.Department.TenantId.Equals(Tenant.TenantId) && e.Employee.TranslationId == empTranslationId);
            return View(empInDepts);
        }

        // GET: Identity/EmpInDepts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                throw new HttpException(400, "Bad Request");
            }
            EmpInDept empInDept = db.EmpInDepts.Where(e => e.Department.TenantId.Equals(Tenant.TenantId) && e.Id == id).FirstOrDefault();
            if (empInDept == null)
            {
                throw new HttpException(404, "Page Not Found");
            }
            return View(empInDept);
        }

        // GET: Identity/EmpInDepts/Create
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                throw new HttpException(400, "Bad Request");
            }
            ViewBag.OccupationId = new SelectList(TermsHelper.Occupations(), "OccupationId", "Value");
            ViewBag.EmployeeTypeId = new SelectList(TermsHelper.EmployeeTypes(), "EmployeeTypeId", "Value");
            ViewBag.DeptId = new SelectList(TermsHelper.GetDepartmentTree(Thread.CurrentThread.CurrentCulture.Name), "Id", "Name");
            EmpInDept empInDept = new EmpInDept();
            empInDept.EmpId = id.Value;
            ViewBag.TranslationId = db.Employees.Find(id).TranslationId;
            return View(empInDept);
        }

        // POST: Identity/EmpInDepts/Create To protect from overposting attacks, please enable the
        // specific properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DeptId,OccupationId,EmployeeTypeId,EmpId")] EmpInDept empInDept)
        {
            if (ModelState.IsValid)
            {
                db.EmpInDepts.Add(empInDept);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("ERROR", ex.InnerException.ToString());
                    ViewBag.OccupationId = new SelectList(TermsHelper.Occupations(), "OccupationId", "Value", empInDept.OccupationId);
                    ViewBag.EmployeeTypeId = new SelectList(TermsHelper.EmployeeTypes(), "EmployeeTypeId", "Value", empInDept.EmployeeTypeId);
                    ViewBag.DeptId = new SelectList(TermsHelper.GetDepartmentTree(Thread.CurrentThread.CurrentCulture.Name), "Id", "Name", empInDept.DeptId);
                    ViewBag.TranslationId = db.Employees.Find(empInDept.EmpId).TranslationId;
                    return View(empInDept);
                }
                return RedirectToAction("Index", new { id = db.Employees.Find(empInDept.EmpId).TranslationId });
            }
            ViewBag.OccupationId = new SelectList(TermsHelper.Occupations(), "OccupationId", "Value", empInDept.OccupationId);
            ViewBag.EmployeeTypeId = new SelectList(TermsHelper.EmployeeTypes(), "EmployeeTypeId", "Value", empInDept.EmployeeTypeId);
            ViewBag.DeptId = new SelectList(TermsHelper.GetDepartmentTree(Thread.CurrentThread.CurrentCulture.Name), "Id", "Name", empInDept.DeptId);
            ViewBag.TranslationId = db.Employees.Find(empInDept.EmpId).TranslationId;
            return View(empInDept);
        }

        // GET: Identity/EmpInDepts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                throw new HttpException(400, "Bad Request");
            }
            EmpInDept empInDept = db.EmpInDepts.Where(e => e.Department.TenantId.Equals(Tenant.TenantId) && e.Id == id).FirstOrDefault();
            if (empInDept == null)
            {
                throw new HttpException(404, "Page Not Found");
            }
            ViewBag.OccupationId = new SelectList(TermsHelper.Occupations(), "OccupationId", "Value", empInDept.OccupationId);
            ViewBag.EmployeeTypeId = new SelectList(TermsHelper.EmployeeTypes(), "EmployeeTypeId", "Value", empInDept.EmployeeTypeId);
            ViewBag.DeptId = new SelectList(TermsHelper.GetDepartmentTree(Thread.CurrentThread.CurrentCulture.Name), "Id", "Name", empInDept.DeptId);
            return View(empInDept);
        }

        // POST: Identity/EmpInDepts/Edit/5 To protect from overposting attacks, please enable the
        // specific properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EmpId,DeptId,OccupationId,EmployeeTypeId")] EmpInDept empInDept)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empInDept).State = EntityState.Modified;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    ViewBag.InnerException = ex.InnerException;
                    ModelState.AddModelError("ERROR", ex.InnerException.ToString());
                    ViewBag.OccupationId = new SelectList(TermsHelper.Occupations(), "OccupationId", "Value", empInDept.OccupationId);
                    ViewBag.EmployeeTypeId = new SelectList(TermsHelper.EmployeeTypes(), "EmployeeTypeId", "Value", empInDept.EmployeeTypeId);
                    ViewBag.DeptId = new SelectList(TermsHelper.GetDepartmentTree(Thread.CurrentThread.CurrentCulture.Name), "Id", "Name", empInDept.DeptId);
                    return View(empInDept);
                }
                return RedirectToAction("Index", new { id = db.Employees.Find(empInDept.EmpId).TranslationId });
            }
            ViewBag.OccupationId = new SelectList(TermsHelper.Occupations(), "OccupationId", "Value", empInDept.OccupationId);
            ViewBag.EmployeeTypeId = new SelectList(TermsHelper.EmployeeTypes(), "EmployeeTypeId", "Value", empInDept.EmployeeTypeId);
            ViewBag.DeptId = new SelectList(TermsHelper.GetDepartmentTree(Thread.CurrentThread.CurrentCulture.Name), "Id", "Name", empInDept.DeptId);
            return View(empInDept);
        }

        // GET: Identity/EmpInDepts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                throw new HttpException(400, "Bad Request");
            }
            EmpInDept empInDept = db.EmpInDepts.Where(e => e.Department.TenantId.Equals(Tenant.TenantId) && e.Id == id).FirstOrDefault();
            if (empInDept == null)
            {
                throw new HttpException(404, "Page Not Found");
            }
            return View(empInDept);
        }

        // POST: Identity/EmpInDepts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpInDept empInDept = db.EmpInDepts.Find(id);
            db.EmpInDepts.Remove(empInDept);
            db.SaveChanges();
            return RedirectToAction("Index", new { id = db.Employees.Find(empInDept.EmpId).TranslationId });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion Methods
    }
}