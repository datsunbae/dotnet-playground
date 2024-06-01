namespace CRUD_ElasticSearch.Services
{
    public interface IElastichsearchServices<T>
    {
        Task<T> GetDocumentAsync(string id);
        Task<IEnumerable<T>> GetAllDocumentsAsync();
        Task<string> CreateDocumentAsync(T document);
        Task<string> UpdateDocumentAsync(T document);
        Task<string> DeleteDocumentAsync(string id);
    }
}
