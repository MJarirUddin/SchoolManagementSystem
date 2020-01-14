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
        AccountsStudentRepository accountsStudentRepository;
        UnitofWork unitOfWork;

        public AccountsStudentController()
        {
            unitOfWork = new UnitofWork();
            accountsStudentRepository = new AccountsStudentRepository(unitOfWork.context);
        }

        // GET: AccountsStudent
        public ActionResult Index()
        {
            var allrecords = accountsStudentRepository.Get();
            return View(allrecords);
        }

        // GET: AccountsStudent/Details/5
        public ActionResult Details(int id)
        {
            var record = accountsStudentRepository.GetByID(id);
            return View(record);
        }

        // GET: AccountsStudent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountsStudent/Create
        [HttpPost]
        public ActionResult Create(AccountsStudent record)
        {
            try
            {
                accountsStudentRepository.Insert(record);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: AccountsStudent/Edit/5
        public ActionResult Edit(int id)
        {
            var record = accountsStudentRepository.GetByID(id);
            unitOfWork.Save();
            return View(record);
        }

        // POST: AccountsStudent/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AccountsStudent accounts)
        {
            try
            {
                accountsStudentRepository.Update(accounts);
                unitOfWork.Save();
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
            accountsStudentRepository.Delete(id);
            unitOfWork.Save();
            return RedirectToAction("Index");
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
