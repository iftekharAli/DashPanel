using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DashPanel.Models;

namespace DashPanel.Controllers
{
    public class ServiceRankingController : Controller
    {

        // GET: ServiceRanking
        public ActionResult Index()
        {
            if (Session["Uid"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            ViewData["ServiceName"] = Services.ToList();


            return View();
        }


        public ActionResult OperatoreWiseClosingBase()
        {
            if (Session["Uid"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();

        }
        public ActionResult DashPanel()
        {
            if (Session["Uid"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();

        }
        public ActionResult ShaboxTextService()
        {
            if (Session["Uid"] == null)
            {
                return  RedirectToAction("Index", "Login");
            }
            return View();

        }

        public ActionResult RawInfo()
        {
            if (Session["Uid"] == null)
            {
               return RedirectToAction("Index", "Login");
            }
            DataSet ds =
                new CDA().GetDataSet(
                    "exec Partner_Basket.dbo.sp_dashservicename", "WAPDB");
            var serviceList = ds.Tables[0]
                .AsEnumerable()
                .Select(row => new
                {
                    servicename= row.Field<string>("servicename")
                })
                .ToList();
            ViewData["ServiceName"] = serviceList.ToList();
            return View();
        }


        public List<Service> Services = new List<Service>()
        {
            new Service()
            {
                Id=1,
                ServiceName = "Top 5 Churned Service"
            },
            new Service()
            {
                Id=1,
                ServiceName = "Top 5 Growing Service"
            },
        };
    }
}