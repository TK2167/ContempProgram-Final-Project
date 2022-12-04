using FinalProject.Data;
using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers;

[ApiController]
[Route("[controller]")]
public class HobbiesController : ControllerBase
{
    

    private readonly ILogger<HobbiesController> _logger;
    private readonly IHobbiesContextDAO _context;

    public HobbiesController(ILogger<HobbiesController> logger, HobbiesContextDAO context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
      return Ok(_context.GetHobbies());
    }

    [HttpGet("User_Id")]
    public IActionResult GetByUser_Id(int User_Id)
    {
      var Hobby = _context.GetHobbies(User_Id);
      if (Hobby == null)
          return NotFound(User_Id);
      return Ok(Hobby);
    }
    
    [HttpDelete]
    public IActionResult Delete(int User_Id)
    {
      var result = _context.RemoveMemberByUser_Id(User_Id);
      if (result == null)
          return NotFound(User_Id);
      if(result == 0)
        return StatusCode(500, "Error");
       
      return Ok();
    }

    [HttpPut]
    public IActionResult Put(Hobby Member)
    {
      var result = _context.UpdateMember(Member);
      
      if (result == null)
          return NotFound(Member.User_Id);
      if(result == 0)
        return StatusCode(500, "Error");
       
      return Ok();
    }

    [HttpPost]
    public IActionResult Post(Hobby Member)
    {
      var result = _context.Add(Member);

      if(result == null)
          return StatusCode(500, "Member Already exists");
      
      if(result == 0)
          return StatusCode(500, "Error");

      return Ok();
    }
}
