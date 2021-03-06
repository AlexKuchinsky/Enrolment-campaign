﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntrantsManagementSystem.Models;
using System.Web.Script.Serialization;
using System.Reflection;
using System.Collections;
using EntrantsManagementSystem.ObjectParser;
namespace EntrantsManagementSystem.Controllers
{
    public class TestController : Controller
    {

        static EntrantsDatabaseEntities db = new EntrantsDatabaseEntities();
        public class Root
        {

            public EntrantsDatabaseEntities edb = new EntrantsDatabaseEntities();

            public IEnumerable Universities => db.Universities.ToList();
        }
        public Root root = new Root();


        public ActionResult Dropdowns()
        {
            return View();
        }
        public ActionResult Tree()
        {
            return View();
        }

        #region Dropdowns
        public JsonResult GetUniversities()
        {
            return Json(db.Universities.Select(u=>new { UniversityID = u.UniversityID, FullName = u.FullName, Abbreviation  = u.Abbreviation }),JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetFaculties(string ID)
        {
            int.TryParse(ID, out int UniversityID);
            return Json(db.Universities.Find(UniversityID).Faculties.Select(f =>new { FacultyID = f.FacultyID, Title = f.Title }), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetSpecialities(string ID)
        {
            int.TryParse(ID, out int SpecialityID);
            return Json(db.Faculties.Find(SpecialityID).Specialities.Select(s=>new { SpecialityID = s.SpecialityID, Title = s.Title, FacultyTitle = s.Faculty.Title, UniversityTitle = s.Faculty.University.FullName }), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Tree
        public JsonResult GetChildren(string route)
        {
            List<int> r = (List<int>)new JavaScriptSerializer().Deserialize(route, typeof(List<int>));
            // Get children
            JsonResult result = Json(ObjectWalker.GetChildrenRecursion(root, r, r.ToList(),typeof(Entrant)), JsonRequestBehavior.AllowGet);
            return result; 
        }
        public JsonResult GetSelectedItems(string data)
        {
            
            // Get result
            List<object> result = ObjectWalker.GetSelectedItems<Entrant,object>(root, data, typeof(Entrant),(e)=> new { data = e.Name+" "+e.Surname + " (id "+e.EntrantID+")" });

            return Json(result,JsonRequestBehavior.AllowGet);
        }
        #endregion

    }
}