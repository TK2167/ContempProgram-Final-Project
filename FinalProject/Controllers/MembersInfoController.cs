using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Interfaces;

namespace FinalProject.Controllers;

[ApiController]
[Route("[controller]")]
public class MembersInfoController : ControllerBase
{
    

    private readonly ILogger<MembersInfoController>? _logger;
    private readonly IMembersInfoContextDAO _context;

    public MembersInfoController(ILogger<MembersInfoController> logger, MembersInfoContextDAO context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.GetMembersInfo());
    }

    [HttpGet("User_Id")]
    public IActionResult GetByUser_Id(int User_Id)
    {
      var Memberinfo = _context.GetMembersInfo(User_Id);
      if (Memberinfo == null)
          return NotFound(User_Id);
      return Ok(Memberinfo);
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
    public IActionResult Put(MemberInfo Member)
    {
      var result = _context.UpdateMember(Member);
      
      if (result == null)
          return NotFound(Member.User_Id);
      if(result == 0)
        return StatusCode(500, "Error");
       
      return Ok();
    }
    [HttpPost]
    public IActionResult Post(MemberInfo Member)
    {
      var result = _context.Add(Member);

      if(result == null)
          return StatusCode(500, "Member Already exists");
      
      if(result == 0)
          return StatusCode(500, "Error");

      return Ok();
    }
}
