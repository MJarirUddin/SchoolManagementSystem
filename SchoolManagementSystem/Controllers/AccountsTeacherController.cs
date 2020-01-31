using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagementSystem.Adapter;
using SchoolManagementSystem.View_Models;

namespace SchoolManagementSystem.Controllers
{
    public class AccountsTeacherController : Controller
    {
        AccountsTeacherAdapter accountsTeacherAdapter;

        public AccountsTeacherController()
        {
            accountsTeacherAdapter = new AccountsTeacherAdapter();
        }
        
        // GET: AccountsTeacher
        public ActionResult Index()
        {
            var allrecords = accountsTeacherAdapter.GetAllAccountsTeacher();
            return View(allrecords);
        }

        // GET: AccountsTeacher/Details/5
        public ActionResult Details(int id)
        {
            var record = accountsTeacherAdapter.GetAccountsTeacherById(id);
            return View(record);
        }

        // GET: AccountsTeacher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountsTeacher/Create
        [HttpPost]
        public ActionResult Create(AccountsTeacherViewModel record)
        {
            if (record == null)
            {
                throw new ArgumentNullException(nameof(record));
            }

            try
            {
                accountsTeacherAdapter.Create(record);
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
            var record = accountsTeacherAdapter.GetAccountsTeacherById(id);
            return View(record);
        }

        // POST: AccountsTeacher/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AccountsTeacherViewModel accounts)
        {
            try
            {
                accountsTeacherAdapter.Update(accounts);
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
            accountsTeacherAdapter.Delete(id);
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
