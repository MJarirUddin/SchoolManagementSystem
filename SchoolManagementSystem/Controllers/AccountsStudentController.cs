using SchoolManagementSystem.Repositories;
using SchoolManagementSystem.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class AccountsStudentController : Controller
    {
        // GET: AccountsStudent
        public ActionResult Index()
        {
            UnitofWork unitOfWork = new UnitofWork();

            AccountStudentRepository accountsstudentRepository = new AccountStudentRepository(new SchoolDBContext());
            var accountsstudent = accountsstudentRepository.Get();

            return View(accountsstudent);
        }

        // GET: AccountsStudent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountsStudent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountsStudent/Create
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

        // GET: AccountsStudent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountsStudent/Edit/5
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

        // GET: AccountsStudent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountsStudent/Delete/5
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
