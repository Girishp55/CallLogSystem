using CallLogSystem.DataContext;
using CallLogSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace CallLogSystem.Controllers
{
    public class CallLogController : Controller
    {
        DatabaseContext _databaseContext;
        public CallLogController(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        //Display the List of all call Logs of the System from Database
        public IActionResult Index()
        {
            var calllogslist = _databaseContext.CallLogs.ToList();
            return View(calllogslist);
        }

        //These method is used to display the individual Problem Detail
        [HttpGet]
        public IActionResult ViewProblemDetails(int id)
        {
            var calllogsDetail = _databaseContext.CallLogs.Where(x => x.Id == id).FirstOrDefault();
            return View(calllogsDetail);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(CallLog callLog)
        {
            if (ModelState.IsValid)
                try
                {
                    _databaseContext.CallLogs.Add(callLog);
                    _databaseContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {

                    throw;
                }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var getData = _databaseContext.CallLogs.Where(x => x.Id == id).FirstOrDefault();

            return View(getData);
        }

        [HttpPost]
        public IActionResult Edit(int id,CallLog callLog)
        {
            if (ModelState.IsValid)
                try
                {
                    _databaseContext.CallLogs.Update(callLog);
                    _databaseContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {

                    throw;
                }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var getData = _databaseContext.CallLogs.Where(x => x.Id == id).FirstOrDefault();

            return View(getData);
        }

        [HttpPost]
        public IActionResult Delete(CallLog callLog)
        {
            if (callLog.Id != null)
                try
                {
                    _databaseContext.CallLogs.Remove(callLog);
                    _databaseContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {

                    throw;
                }
            return View();
        }
    }

}

