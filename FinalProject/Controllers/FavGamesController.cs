using FinalProject.Data;
using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers;

[ApiController]
[Route("[controller]")]
public class FavGamesController : ControllerBase
{
    private readonly ILogger<FavGamesController> _logger;
    private readonly IFavGamesContextDAO _context;
    public FavGamesController(ILogger<FavGamesController> logger, FavGamesContextDAO context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
      return Ok(_context.GetFavGames());
    }
    
    [HttpGet("User_Id")]
    public IActionResult GetByUser_Id(int User_Id)
    {
      var Member = _context.GetFavGames(User_Id);
      if (Member == null)
          return NotFound(User_Id);
      return Ok(Member);
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
    public IActionResult Put(FavGame Member)
    {
      var result = _context.UpdateMember(Member);
      
      if (result == null)
          return NotFound(Member.User_Id);
      if(result == 0)
        return StatusCode(500, "Error");
       
      return Ok();
    }

    [HttpPost]
    public IActionResult Post(FavGame Member)
    {
      var result = _context.Add(Member);

      if(result == null)
          return StatusCode(500, "Member Already exists");
      
      if(result == 0)
          return StatusCode(500, "Error");

      return Ok();
    }
}
