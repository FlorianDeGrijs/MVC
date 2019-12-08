using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Form.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    public class StudentenAdministratieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ZoekStudenten(string id)
        {
            if (id == null)
            {
                return View("Index");
            }

            ViewData["CharacterSearched"] = id;

            List<Student> students = new List<Student>() {
            new Student() {Name = "John", Age = 19, Hobby = "Play WoW"},
            new Student() {Name = "Jamie", Age = 21, Hobby = "Play Minecraft"},
            new Student() {Name = "Phillip", Age = 18, Hobby = "Play Fortnite"},
            new Student() {Name = "Flo", Age = 25, Hobby = "Play LoL"},
            };

            List<Student> searchStudents = students
                .Where(s => s.Name.ToLower().StartsWith(id.ToLower()))
                .OrderBy(s => s.Name)
                .ToList();

            if (!searchStudents.Any())
            {
                return NotFound();
            }

            return View(searchStudents);
        }

    }
}