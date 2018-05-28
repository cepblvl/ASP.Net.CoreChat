using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TelegramBE.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TelegramBE.Controllers
{
    [Route("api/[controller]")]
    public class MessegesController : Controller
    {

        private MessegeContext db;
        public MessegesController(MessegeContext context)
        {
            db = context;
           
        }


        //public async Task<IActionResult> Index()
        //{
        //    return View(await db.Phones.ToListAsync());
        //}
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Create(Phone phone)
        //{
        //    db.Phones.Add(phone);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}




       // GET: api/<controller>
        [HttpGet]
        public void Get()
        {
            
        }

        // GET api/<controller>/5/4
        [HttpGet("{id1}/{id2}")]
        public IEnumerable<Messege> Get(string id1, string id2)
        {
            List<Messege> messeges = new List<Messege>();
            messeges = db.Messen.Where(i => (i.id1 == id1 && i.id2 == id2) || (i.id2 == id1 && i.id1 == id2)).ToList();



            return messeges;
        }

        // POST api/<controller>
        [HttpPost]
        public Messege Post([FromBody]Messege messege)
        {


            db.Messen.Add(messege);
            db.SaveChanges();
            return messege;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
