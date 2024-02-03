using Microsoft.AspNetCore.Mvc;
using WordService.Infrastructure;

namespace WordService.Controllers; 

public class DocumentController : BaseController {
    private Database _database = Database.Instance;

    [HttpGet("GetByDocIds")]
    public List<string> GetByDocIds([FromQuery] List<int> docIds)
    {
        return _database.GetDocDetails(docIds);
    }
    
    [HttpGet("GetByWordIds")]
    public Dictionary<int, int> GetByWordIds([FromQuery] List<int> wordIds)
    {
        return _database.GetDocuments(wordIds);
    }
    
    [HttpPost]
    public void Post(int id, string url)
    {
         _database.InsertDocument(id, url);
    }
}
