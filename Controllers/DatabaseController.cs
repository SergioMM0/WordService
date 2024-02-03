using Microsoft.AspNetCore.Mvc;
using WordService.Infrastructure;

namespace WordService.Controllers; 

public class DatabaseController : BaseController {
    private readonly Database _database = Database.Instance;

    [HttpDelete]
    public void Delete()
    {
        _database.DeleteDatabase();
    }

    [HttpPost]
    public void Post()
    {
        _database.RecreateDatabase();
    }
}
