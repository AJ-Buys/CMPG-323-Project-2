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
            var z = _context.Cmpg323Project2Dataset.Select(z => z.JobRole).Distinct().ToList();
            var list = new List<int>();

            foreach (var item in z)
            {
                list.Add(_context.Cmpg323Project2Dataset.Where(z => z.JobRole == item).Count());
            }
            ViewBag.label = JsonConvert.SerializeObject(z);
            ViewBag.value = JsonConvert.SerializeObject(list);
            #endregion


            return View();

        }

    }
}
