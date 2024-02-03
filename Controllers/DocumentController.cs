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
    
    /// <summary>
    /// Retrieves the words by Id
    /// </summary>
    /// <param name="wordIds"></param>
    /// <returns></returns>
    [HttpGet("GetByWordIds")]
    public Dictionary<int, int> GetByWordIds([FromQuery] List<int> wordIds)
    {
        return _database.GetDocuments(wordIds);
    }

    /// <summary>
    /// Inserts a document
    /// </summary>
    /// <param name="id"></param>
    /// <param name="url"></param>
    [HttpPost]
    public void Post(int id, string url)
    {
         _database.InsertDocument(id, url);
    }
}
