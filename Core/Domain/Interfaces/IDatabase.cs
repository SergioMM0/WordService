namespace WordService.Core.Domain.Interfaces;

public interface IDatabase {
    Task<Dictionary<int, int>> GetDocuments(List<int> wordIds);
    Task InsertDocument(int id, string url);
    Task<Dictionary<string, int>> GetAllWords();
    Task<List<string>> GetDocDetails(List<int> docIds);
}
