using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Middleware.Models;

namespace Middleware.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(HomeController));
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            _log4net.Debug("Its sa debug mesage");

            //_logger.LogWarning("Its a warning");
            //_logger.LogDebug("Its s debug message");
            //_logger.LogError("Its an error");
            int x = 10;
            int y = 0;

            try
            {
                int res = x / y;
            }
            catch (Exception ex)
            {
                _log4net.Error(ex.Message);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
