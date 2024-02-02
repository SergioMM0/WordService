using Microsoft.AspNetCore.Mvc;
using WordService.Infrastructure;

namespace WordService.Controllers; 

public class WordController : BaseController {
    private readonly Database _database;

    [HttpGet]
    public Dictionary<string, int> Get()
    {
        return _database.GetAllWords();
    }

    [HttpPost]
    public void Post([FromBody]Dictionary<string, int> res)
    {
        _database.InsertAllWords(res);
    }
}
