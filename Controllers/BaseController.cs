using Microsoft.AspNetCore.Mvc;

namespace WordService.Controllers; 

/// <summary>
/// Base controller for all controllers.
/// </summary>
[ApiController]
[Route("[controller]")]
public abstract class BaseController : ControllerBase {

}
