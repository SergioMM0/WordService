using Microsoft.AspNetCore.Mvc;
using WordService.Infrastructure;

namespace WordService.Controllers; 

public class OccurrenceController : BaseController {
    private readonly Database _database;
    
    public OccurrenceController(Database database) {
        _database = database;
    }

    [HttpPost]
    public void Post(int docId, [FromBody]ISet<int> wordIds)
    {
        _database.InsertAllOcc(docId, wordIds);
    }
}
