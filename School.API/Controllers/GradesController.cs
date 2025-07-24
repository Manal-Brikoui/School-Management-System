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
    public class GradesController : ControllerBase
    {
        private readonly IGradeService _service;
        public GradesController(IGradeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<GradeDto>>> GetAll()
        {
            var grades = await _service.GetAllAsync();
            return Ok(grades);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GradeDto>> GetById(Guid id)
        {
            var grade = await _service.GetByIdAsync(id);
            if (grade == null) return NotFound();
            return Ok(grade);
        }

        [HttpPost]
        public async Task<ActionResult<GradeDto>> Create(GradeDto dto)
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
