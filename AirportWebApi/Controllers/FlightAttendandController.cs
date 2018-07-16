using AirportWebApi.BL.Services;
using AirportWebApi.DAL.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;
using System;

namespace AirportWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/flightAttendants")]
    public class FlightAttendantsController : Controller
    {
        private readonly IMapper mapper;
        private readonly BaseService service;

        public FlightAttendantsController(IMapper mapper, BaseService service)
        {
            this.mapper = mapper;
            this.service = service;
        }

        // GET api/v1/flightAttendants
        [HttpGet]
        public IActionResult Get()
        {
            var items = service.GetAll<FlightAttendant>();
            if (items != null) return Ok(items);
            return NoContent();
        }

        // GET api/v1/flightAttendants/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                var item = service.GetById<FlightAttendant>(id);
                if (item != null) return Ok(item);
            }
            return NotFound();
        }


        // POST api/v1/flightAttendants
        [HttpPost]
        public IActionResult Post([FromBody]FlightAttendantDto value)
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

        // PUT api/v1/flightAttendants/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]FlightAttendantDto value)
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

        // DELETE: /api/v1/flightAttendants/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Remove<FlightAttendant>(id);
                }
                catch (Exception) { return NoContent(); }
                return Ok();
            }
            return NotFound();
        }
    }
}