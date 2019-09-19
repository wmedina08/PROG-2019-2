using System;
using Microsoft.AspNetCore.Mvc;
using student_app.models;
using System.Linq;
namespace student_app.Controllers
{
    public class HomeController:Controller
    {
        private readonly DatabaseContext _context;
        public HomeController(DatabaseContext context){
            _context=context;
        }
    }
}