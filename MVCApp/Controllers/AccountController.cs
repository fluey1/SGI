using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.AccountProcessor;

namespace MVCApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewAccount()
        {
            ViewBag.Message = "New Account";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewAccount(AccountModel model)
        {
            if(ModelState.IsValid)
            {
                int recordsCreated = CreateAccount(model.AccountId,
                    model.AccountName,
                    model.Street,
                    model.City,
                    model.StateProvince,
                    model.Country);
                return RedirectToAction("ViewAccounts");

            }

            return View();
        }

        public ActionResult ViewAccounts()
        {
            ViewBag.Message = "Accounts List";

            var data = LoadAccounts();

            List<AccountModel> accounts = new List<AccountModel>();

            foreach(var row in data)
            {
                accounts.Add(new AccountModel
                {
                    AccountId = row.AccountId,
                    AccountName = row.Name,
                    Street = row.Street,
                    City = row.City,
                    StateProvince = row.StateProvince,
                    Country = row.Country
                });
                
            }
            return View(accounts);
        }

    }
}