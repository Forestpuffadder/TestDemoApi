using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testapi.Models;


namespace testapi.Controllers{

    [Route("api/[controller]")]
    [ApiController]

    public class TodoController:ControllerBase{

            private readonly TodoContext _context;

            //this is the constructor
            public TodoController(TodoContext context){
                _context = context;
                if(_context.Todolist.Count()==0){
                        _context.Todolist.Add(new todoitem{name="Item1"});
                        _context.SaveChanges();

                }
            }
            //get/api/todo
            [HttpGet]
            public ActionResult<List<todoitem>>Getall(){
                return _context.Todolist.ToList();
            }

            // GET /api/todo/{id}
            [HttpGet("{id}",Name="Gettodo")]
            public ActionResult<todoitem> Getbyid(long id){

                var item = _context.Todolist.Find(id);
                if(item==null){
                    return NotFound();
                }
                return item;

            }














    }
        
}