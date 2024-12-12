﻿
using Harmic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Harmic.Controllers
{
    public class ContactController : Controller
    {
        private readonly HarmicContext _context;
        public ContactController(HarmicContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string name, string phone, string email, string message, string CreatedDate)
        {
            try
            {
                TbContact contact = new TbContact();
                contact.Name = name; 
                contact.Phone = phone;
                contact.Email = email;
                contact.Message = message;
                contact.CreatedDate = DateTime.Now;
                _context.Add(contact);
                _context.SaveChangesAsync();
                return Json(new { status = true });
            }
            catch
            {
                return Json(new { status= false });
            }
        }
    }

}
