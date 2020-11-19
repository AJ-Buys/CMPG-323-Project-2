using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Test_Database.Data;

namespace Test_Database.Controllers
{
    [Authorize]
    public class dataChartController : Controller
    {

        private readonly Project2Context _context;

        public dataChartController(Project2Context context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            #region Chart 1
                var x = _context.Cmpg323Project2Dataset.Where(x => x.Gender == "Male").Count();
                var y = _context.Cmpg323Project2Dataset.Where(y => y.Gender == "Female").Count();
            

                ViewBag.male = JsonConvert.SerializeObject(x);
                ViewBag.female = JsonConvert.SerializeObject(y);
            #endregion



            #region Chart 2
                var healthRep = _context.Cmpg323Project2Dataset.Where(healthRep => healthRep.JobRole == "Healthcare Representative").Count();
                var humanRe = _context.Cmpg323Project2Dataset.Where(humanRe => humanRe.JobRole == "Human Resources").Count();
                var labTech = _context.Cmpg323Project2Dataset.Where(labTech => labTech.JobRole == "Laboratory Technician").Count();
                var manag = _context.Cmpg323Project2Dataset.Where(manag => manag.JobRole == "Manager").Count();
                var manuDir = _context.Cmpg323Project2Dataset.Where(manuDir => manuDir.JobRole == "Manufacturing Director").Count();
                var resDir = _context.Cmpg323Project2Dataset.Where(resDir => resDir.JobRole == "Research Director").Count();
                var resSci = _context.Cmpg323Project2Dataset.Where(resSci => resSci.JobRole == "Research Scientist").Count();
                var salesEx = _context.Cmpg323Project2Dataset.Where(salesEx => salesEx.JobRole == "Sales Executive").Count();
                var salesRep = _context.Cmpg323Project2Dataset.Where(salesRep => salesRep.JobRole == "Sales Representative").Count();

                ViewBag.HealthRep = JsonConvert.SerializeObject(healthRep);
                ViewBag.HumanR = JsonConvert.SerializeObject(humanRe);
                ViewBag.LabTech = JsonConvert.SerializeObject(labTech);
                ViewBag.Mana = JsonConvert.SerializeObject(manag);
                ViewBag.ManuDir = JsonConvert.SerializeObject(manuDir);
                ViewBag.ResDir = JsonConvert.SerializeObject(resDir);
                ViewBag.ResSci = JsonConvert.SerializeObject(resSci);
                ViewBag.SalesEx = JsonConvert.SerializeObject(salesEx);
                ViewBag.SalesRep = JsonConvert.SerializeObject(salesRep);

            #endregion

            #region Chart 3
                var HumanR = _context.Cmpg323Project2Dataset.Where(HumanR => HumanR.Department == "Human Resources").Count();
                var resDev= _context.Cmpg323Project2Dataset.Where(resDev => resDev.Department == "Research & Development").Count();
                var sales = _context.Cmpg323Project2Dataset.Where(sales => sales.Department == "Sales").Count();


                ViewBag.HumanRe = JsonConvert.SerializeObject(HumanR);
                ViewBag.ResDev = JsonConvert.SerializeObject(resDev);
                ViewBag.Sales = JsonConvert.SerializeObject(sales);

            #endregion

            return View();

        }

    }
}
