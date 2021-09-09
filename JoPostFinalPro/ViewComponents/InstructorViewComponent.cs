using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JoPostFinalPro.Data;

namespace JoPostFinalPro.ViewComponents
{
    public class InstructorViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext db;
        public InstructorViewComponent(ApplicationDbContext _db )
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Instructors.OrderByDescending(m=>m.Id).Take(10));
        }

    }
}
