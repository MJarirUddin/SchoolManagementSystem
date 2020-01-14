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
        AccountsTeacherRepository accountsTeacherRepository;
        UnitofWork unitOfWork;
       
        public AccountsTeacherController()
        {
            unitOfWork = new UnitofWork();
            accountsTeacherRepository = new AccountsTeacherRepository(unitOfWork.context);            
        }
        
        // GET: AccountsTeacher
        public ActionResult Index()
        {
            var allrecords = accountsTeacherRepository.Get();
            return View(allrecords);
        }

        // GET: AccountsTeacher/Details/5
        public ActionResult Details(int id)
        {
            var record = accountsTeacherRepository.GetByID(id);
            return View(record);
        }

        // GET: AccountsTeacher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountsTeacher/Create
        [HttpPost]
        public ActionResult Create(AccountsTeacher record)
        {
            try
            {
                accountsTeacherRepository.Insert(record);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: AccountsTeacher/Edit/5
        public ActionResult Edit(int id)
        {
            var record = accountsTeacherRepository.GetByID(id);
            return View(record);
        }

        // POST: AccountsTeacher/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AccountsTeacher accounts)
        {
            try
            {
                accountsTeacherRepository.Update(accounts);
                unitOfWork.Save();
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
            accountsTeacherRepository.Delete(id);
            unitOfWork.Save();
            return RedirectToAction("Index");
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
