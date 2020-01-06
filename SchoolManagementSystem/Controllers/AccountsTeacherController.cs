using SchoolManagementSystem.Repositories;
using SchoolManagementSystem.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class AccountsTeacherController : Controller
    {
        // GET: AccountsTeacher
        public ActionResult Index()
        {
            UnitofWork unitOfWork = new UnitofWork();

            AccountStudentRepository accountsteacherRepository = new AccountStudentRepository(new SchoolDBContext());
            var accountsteacher = accountsteacherRepository.Get();

            return View(accountsteacher);
        }

        // GET: AccountsTeacher/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountsTeacher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountsTeacher/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountsTeacher/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountsTeacher/Edit/5
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

        // GET: AccountsTeacher/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountsTeacher/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
