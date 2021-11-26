using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManagement.DBContexts;
using StudentManagement.Entities;
using StudentManagement.Models;
using StudentManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<User> userManager;
        private readonly StudentManagementContext context;
        private static User user = new User();

        public StudentController(IUserService userService,
                                 UserManager<User> userManager,
                                 StudentManagementContext context)
        {
            this.userService = userService;
            this.userManager = userManager;
            this.context = context;
        }
        public IActionResult Index(string StudentName, int? SchoolYearId, int EventId)
        {
            var stu = from m in context.Users select m;
            //var yearId = (from uy in context.UserSchoolYears
            //              from s in context.SchoolYears
            //              from u in context.Users
            //              select new Student()
            //              {
            //                  SchoolYearId = uy.SchoolYearId
            //              }).ToList();
     
            if (!string.IsNullOrEmpty(StudentName))
            {
                stu = stu.Where(s => s.UserName!.Contains(StudentName));
            }
            if (SchoolYearId != null)
            {

                stu = (IQueryable<User>)context.UserSchoolYears.Where(s => s.SchoolYearId == SchoolYearId);
            }
            ViewBag.listSkill = context.Skills.ToList();
            var users = new Student()
            {
                Users = stu.Where(s => s.StudentCode != null).OrderBy(s => s.StudentCode).Include(p => p.Events).Include(p => p.Messages).Include(p => p.UserSchoolYears).ToList()
            };
            ViewData["ListEventId"] = new SelectList(context.ListEvents, "ListEventId", "ListEventName");
            ViewData["SchoolYearId"] = new SelectList(context.SchoolYears, "SchoolYearId", "SchoolYearName");
            return View(users);
        }
    }
}
