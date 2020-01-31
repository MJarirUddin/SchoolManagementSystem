
using SchoolManagementSystem.Adapter;
using SchoolManagementSystem.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class TeacherController : Controller
    {

        TeacherAdapter teacherAdapter;
        public TeacherController()
        {
            teacherAdapter = new TeacherAdapter();
        }
        // GET: Teacher
        public ActionResult Index()
        {
            var teachers = teacherAdapter.GetAllTeachers();
            return View(teachers);
        }

        // GET: Teacher/Details/5
        public ActionResult Details(int id)
        {
            var teacher = teacherAdapter.GetTeacherById(id);
            return View(teacher);
        }

        // GET: Teacher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teacher/Create
        [HttpPost]
        public ActionResult Create(TeacherViewModel teacher)
        {
            try
            {
                teacherAdapter.Create(teacher);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Teacher/Edit/5
        public ActionResult Edit(int id)
        {
            return View("Edit",teacherAdapter.GetTeacherById(id));
        }

        // POST: Teacher/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TeacherViewModel teacher)
        {
            try
            {
                // TODO: Add update logic here

                teacherAdapter.Update(teacher);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Teacher/Delete/5
        public ActionResult Delete(int id)
        {

            teacherAdapter.Delete(id);
            
            return RedirectToAction("Index");
        }

        // POST: Teacher/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, TeacherViewModel teacher)
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
