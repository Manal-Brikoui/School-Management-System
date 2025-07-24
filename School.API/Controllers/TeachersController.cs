using Microsoft.AspNetCore.Mvc;
using Application.DTOs;
using School.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _service;
        public TeachersController(ITeacherService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<TeacherDto>>> GetAll()
        {
            var teachers = await _service.GetAllAsync();
            return Ok(teachers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherDto>> GetById(Guid id)
        {
            var teacher = await _service.GetByIdAsync(id);
            if (teacher == null) return NotFound();
            return Ok(teacher);
        }

        [HttpPost]
        public async Task<ActionResult<TeacherDto>> Create(TeacherDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
