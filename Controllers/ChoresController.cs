using System.Linq.Expressions;
using Microsoft.AspNetCore.Http.HttpResults;

namespace chores.Controllers;

[ApiController]
[Route("api/chores")]

public class ChoresController : ControllerBase
{

  private readonly ChoresService choresService;
  public ChoresController(ChoresService choresService)
  {
    this.choresService = choresService;
  }

  [HttpGet]

  public ActionResult<List<Chore>> GetChores()
  {
    try
    {
      List<Chore> chores = choresService.GetChores();
      return Ok(chores);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpGet("{choreId}")]
  public ActionResult<Chore> GetChoreById(string choreId)
  {
    try
    {
      Chore chore = choresService.GetChoreById(choreId);
      return Ok(chore);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }
  [HttpPost]

  public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = choresService.CreateChore(choreData);
      return Ok(chore);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpDelete("{choreId}")]

  public ActionResult<string> RemoveChore(string choreId)
  {
    try
    {
      string message = choresService.RemoveChore(choreId);
      return Ok(message);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }
}


