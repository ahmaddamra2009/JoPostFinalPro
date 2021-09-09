using JoPostFinalPro.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoPostFinalPro.ViewComponents
{
    public class CourseViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext db;
        public CourseViewComponent(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            return View(db.Courses.OrderByDescending(x=>x.Id).Take(6));
        }

    }
}
