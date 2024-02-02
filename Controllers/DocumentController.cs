using Microsoft.AspNetCore.Mvc;
using WordService.Infrastructure;

namespace WordService.Controllers; 

public class DocumentController : BaseController {
    private Database database;

    public DocumentController(Database database) {
        this.database = database;
    }

    /// <summary>
    /// Retrieves the Document by Id
    /// </summary>
    /// <param name="docIds"></param>
    /// <returns></returns>
    [HttpGet("GetByDocIds")]
    public async Task<List<string>> GetByDocIds([FromQuery] List<int> docIds)
    {
        return await database.GetDocDetails(docIds);
    }
    
    /// <summary>
    /// Retrieves the words by Id
    /// </summary>
    /// <param name="wordIds"></param>
    /// <returns></returns>
    [HttpGet("GetByWordIds")]
    public async Task<Dictionary<int, int>> GetByWordIds([FromQuery] List<int> wordIds)
    {
        return await database.GetDocuments(wordIds);
    }

    /// <summary>
    /// Inserts a document
    /// </summary>
    /// <param name="id"></param>
    /// <param name="url"></param>
    [HttpPost]
    public async Task Post(int id, string url)
    {
        await database.InsertDocument(id, url);
    }
}
