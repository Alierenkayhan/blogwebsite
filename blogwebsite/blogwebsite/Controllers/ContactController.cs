using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogwebsite.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm= new ContactManager(new EFContactDal());
        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }
    }
}