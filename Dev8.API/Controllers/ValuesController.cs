﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev8.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace Dev8.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext context;

        public ValuesController(DataContext context){
            this.context = context;
        }

        // GET api/values
        [HttpGet]
        public IActionResult GetValues()
        {
            var values = this.context.Values.ToList();

            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> GetValue(int id)
        {
            var value = this.context.Values.FirstOrDefault(s => s.Id == id);

            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
