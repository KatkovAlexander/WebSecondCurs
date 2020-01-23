using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]     
    [ApiController]
    public class TodoController : ControllerBase
    {
        TodoContext db;

        public TodoController(TodoContext context)
        {
            db = context;
            if (!db.TodoItems.Any())
            {
                TodoItem user1 = new TodoItem { Category = "Socks", Brand = "Armani", Amount = 26 };
                TodoItem user2 = new TodoItem { Category = "Jacket", Brand = "Tommy Hilfiger", Amount = 24};
                TodoItem user3 = new TodoItem { Category = "Pants", Brand = "Tommy Hilfiger", Amount = 25};
                TodoItem user4 = new TodoItem { Category = "Boots", Brand = "Armani", Amount = 26};
                TodoItem user5 = new TodoItem { Category = "Glases", Brand = "Gucci", Amount = 23};
                TodoItem user6 = new TodoItem { Category = "T-shirt", Brand = "Armani", Amount = 23};
                TodoItem user7 = new TodoItem { Category = "Shirt", Brand = "Gucci", Amount = 25};
                TodoItem user8 = new TodoItem { Category = "Bag", Brand = "Luis Viton", Amount = 24};
                
                db.TodoItems.AddRange(user1, user2, user3, user4, user5, user6, user7, user8);
                db.SaveChanges();
            }
        }
        [HttpGet] 
        public ActionResult<List<TodoItem>> GetAll() 
        {     
            return db.TodoItems.ToList(); 
        } 
        
        [HttpGet("{id}", Name = "GetTodo")] 
        public ActionResult<TodoItem> GetById(long id) 
        {    
            var item = db.TodoItems.Find(id);     
            if (item == null)    
            {         
                return NotFound();     
            }     
            return item; 
        }
   // POST api/users
        [HttpPost]
        public async Task<ActionResult<TodoItem>> Post(TodoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
 
            db.TodoItems.Add(item);
            await db.SaveChangesAsync();
            return Ok(item);
        }
 
        // PUT api/users/
        [HttpPut]
        public async Task<ActionResult<TodoItem>> Put(TodoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            if (!db.TodoItems.Any(x => x.Id ==item.Id))
            {
                return NotFound();
            }
 
            db.Update(item);
            await db.SaveChangesAsync();
            return Ok(item);
        }
 
        // DELETE api/users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TodoItem>> Delete(int id)
        {
            TodoItem item = db.TodoItems.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            db.TodoItems.Remove(item);
            await db.SaveChangesAsync();
            return Ok(item);
        }
    }
}