using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmpController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }
        // GET: Emp
        public ActionResult Login(FormCollection form)
        {
            DataBaseConnection c = null;
            try
            {
               c = new DataBaseConnection();
                string name = Request.Form["name"];
             ViewBag.name= c.EmpLogin(Request.Form["name"]);
                
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
            return View(c);
        }
    }
}