using Microsoft.AspNetCore.Mvc;
using LMS.Services;

namespace LMS.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TeachersController : ControllerBase
{
    private readonly TeacherService _service;

    public TeachersController()
    {
        _service = new TeacherService();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _service.GetTeachersForDisplayAsync();
        return Ok(result);
    }
}