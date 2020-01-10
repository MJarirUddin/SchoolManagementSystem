using SchoolManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagementSystem.UnitOfWork;

namespace SchoolManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        UnitofWork unitOfWork;
        StudentRepository studentRepository;
        public StudentController()
        {
            unitOfWork = new UnitofWork();
            studentRepository = new StudentRepository(unitOfWork.context);

        }
        // GET: Student
        public ActionResult Index()
        {
            var students = studentRepository.Get();
            return View(students);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            var student= studentRepository.GetByID(id);
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                studentRepository.Insert(student);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View("Edit",studentRepository.GetByID(id));
        }
        
        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                // TODO: Add update logic here

                studentRepository.Update(student);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            studentRepository.Delete(id);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        // POST: Student/Delete/5
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
