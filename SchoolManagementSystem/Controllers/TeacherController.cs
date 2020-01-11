using SchoolManagementSystem.Repositories;
using SchoolManagementSystem.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        UnitofWork unitOfWork;
        TeacherRepository teacherRepository;

        public TeacherController()
        {
            unitOfWork = new UnitofWork();
            teacherRepository = new TeacherRepository(unitOfWork.context);
        }
        // GET: Teacher
        public ActionResult Index()
        {
            var teachers = teacherRepository.Get();
            return View(teachers);
        }

        // GET: Teacher/Details/5
        public ActionResult Details(int id)
        {
            var teacher = teacherRepository.GetByID(id);
            return View(teacher);
        }

        // GET: Teacher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teacher/Create
        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            try
            {
                teacherRepository.Insert(teacher);
                unitOfWork.Save();
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
            return View("Edit",teacherRepository.GetByID(id));
        }

        // POST: Teacher/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Teacher teacher)
        {
            try
            {
                // TODO: Add update logic here

                teacherRepository.Update(teacher);
                unitOfWork.Save();
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

            teacherRepository.Delete(id);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        // POST: Teacher/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Teacher teacher)
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
