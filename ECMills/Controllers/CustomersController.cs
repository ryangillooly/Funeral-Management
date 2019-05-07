﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECMills.Models;
using System.Web.Mvc.Html;
using System.Data.SqlClient;

namespace ECMills.Controllers
{
    public class CustomersController : Controller
    {
        private ECMills_DBModel_Connection DBContext;
        public CustomersController()
        {
            DBContext = new ECMills_DBModel_Connection();
        }
        protected override void Dispose(bool disposing)
        {
            DBContext.Dispose();
        }

        public ViewResult Index(string surname)
        {
            if (!String.IsNullOrEmpty(surname))
            {
                string sqlquery = "SELECT * FROM Client WHERE C_NAME LIKE '%" + surname + "%' ORDER BY C_ID ASC";

                List<Client> Clients = DBContext.Clients.SqlQuery(sqlquery).ToList();

                return View(Clients);
            }
            else
            {
                return View("NoCustomers");
            }
        }
        /*
                public ActionResult Details(int id)
                {
                    var customer = GetCustomers(id);

                    if (customer == null)
                        return HttpNotFound();

                    return View(customer);
                }

                private List<sp_GetClientFile_Result> GetCustomers(int id)
                {
                    var courses = DBContext.sp_GetClientFile(id).ToList();
                    return courses;
                }

                public ViewResult User()
                {
                    return View();
                }

                public ActionResult New()
                {
                    var Churches = DBContext.sp_GetCommitalls().ToList();

                    var viewModel = new NewCustomerViewModel
                    {
                       Churches = Churches
                    };

                    return View(viewModel);
                }

            */

    }
}