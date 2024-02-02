namespace WordService.Core.Domain.Interfaces;

public interface IDatabase {
    Dictionary<int, int> GetDocuments(List<int> wordIds);
    void InsertDocument(int id, string url);
    Dictionary<string, int> GetAllWords();
    List<string> GetDocDetails(List<int> docIds);
}
