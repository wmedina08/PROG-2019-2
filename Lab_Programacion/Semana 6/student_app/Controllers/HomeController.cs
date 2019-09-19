using System;
using Microsoft.AspNetCore.Mvc;
using student_app.Models;
using System.Linq;


namespace student_app.Controllers
{
    public class HomeController:Controller
    {
        private readonly DatabaseContext _context;
        public HomeController(DatabaseContext context){
            _context=context;
        }
        public IActionResult Index(){
            return View(_context.students.ToList());
        }
        public IActionResult Create(){
            return View();
        }
        public IActionResult Detail(int? id){

           if (id == null)
            {
                return NotFound();
            }

            var student = _context.students
                .SingleOrDefault(m => m.id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        [HttpPost]
        public IActionResult Registro(student student){
            Console.WriteLine("Registro");

            int edad = DateTime.Now.Year - student.birth.Year;
            student.edad=edad;
            
            int creditos=0;
            int total=0;
            switch (student.curso){
                case "Matemática": creditos=4;
                                   total=400;
                                   break;
                case "Lenguaje":   creditos=5;
                                   total=500;
                                   break;
                case "Física":     creditos=6;
                                   total=600;
                                   break;
            }
            student.credito=creditos;
            student.total=total;
            
            _context.Add(student);
            _context.SaveChanges();

            return View(student);
        }
    }
}