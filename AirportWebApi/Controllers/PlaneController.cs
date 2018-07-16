using AirportWebApi.BL.Services;
using AirportWebApi.DAL.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;
using System;
namespace AirportWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/planes")]
    public class PlanesController : Controller
    {
        private readonly IMapper mapper;
        private readonly BaseService service;

        public PlanesController(IMapper mapper, BaseService service)
        {
            this.mapper = mapper;
            this.service = service;
        }

        // GET api/v1/planes
        [HttpGet]
        public IActionResult Get()
        {
            var items = service.GetAll<Plane>();
            if (items != null) return Ok(items);
            return NoContent();
        }

        // GET api/v1/planes/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                var item = service.GetById<Plane>(id);
                if (item != null) return Ok(item);
            }
            return NotFound();
        }


        // POST api/v1/planes
        [HttpPost]
        public IActionResult Post([FromBody]PlaneDto value)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Add(value);
                }
                catch (Exception) { return BadRequest(); }
                return Ok();
            }
            return BadRequest();
        }

        // PUT api/v1/planes/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]PlaneDto value)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Update(value);
                }
                catch (Exception) { return BadRequest(); }
                return Ok();
            }
            return BadRequest();
        }

        // DELETE: /api/v1/planes/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Remove<Plane>(id);
                }
                catch (Exception) { return NoContent(); }
                return Ok();
            }
            return NotFound();
        }
    }
}