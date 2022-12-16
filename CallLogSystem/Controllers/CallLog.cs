using CallLogSystem.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace CallLogSystem.Controllers
{
    public class CallLog : Controller
    {
        DatabaseContext _databaseContext;
          public CallLog(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public  IActionResult Index()
        {
            var calllogslist = _databaseContext.CallLogs.ToList();
            return View(calllogslist);
        }

        [HttpGet]
        public IActionResult ViewProblemDetails(int id)  
        {
            var calllogsDetail = _databaseContext.CallLogs.Where(x => x.Id == id).FirstOrDefault();
            return View(calllogsDetail);
        }
    }
}
