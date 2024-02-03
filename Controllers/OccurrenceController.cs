using Microsoft.AspNetCore.Mvc;
using WordService.Infrastructure;

namespace WordService.Controllers; 

public class OccurrenceController : BaseController {
    private readonly Database _database = Database.Instance;

    [HttpPost]
    public void Post(int docId, [FromBody]ISet<int> wordIds)
    {
        _database.InsertAllOcc(docId, wordIds);
    }
}
