using ERIL.Data;
using ERIL.Models;
using Microsoft.AspNetCore.Mvc;

namespace ERIL.Controllers;

public class LibraryController : Controller
{
    private readonly ApplicationDBContext _db;

    public LibraryController(ApplicationDBContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        IEnumerable <Papers> objPaperList = _db.Papers; 
        return View(objPaperList);
    }
    //GET
    public IActionResult PaperUpload()
    {
        return View();
    }

    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult PaperUpload(Papers obj)
    {
        if (ModelState.IsValid)
        {
            _db.Papers.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(obj);
    }

}
