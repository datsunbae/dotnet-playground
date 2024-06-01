
using Nest;

namespace CRUD_ElasticSearch.Services
{
    public sealed class ElasticsearchService<T> : IElastichsearchServices<T>
        where T : class
    {
        private readonly ElasticClient _elasticsearchClient;
        public ElasticsearchService(ElasticClient elasticsearchClient)
        {
            _elasticsearchClient = elasticsearchClient;
        }
        public async Task<string> CreateDocumentAsync(T document)
        {
            var response = await _elasticsearchClient.IndexDocumentAsync(document);
            return response.IsValid ? "Document created successfully" : "Falid to create document";
        }

        public async Task<string> DeleteDocumentAsync(string id)
        {
            var response = await _elasticsearchClient.DeleteAsync(new DocumentPath<T>(id));
            return response.IsValid ? "Document deleted successfully" : "Falid to delete document";
        }

        public async Task<IEnumerable<T>> GetAllDocumentsAsync()
        {
            var response = await _elasticsearchClient.SearchAsync<T>(s => s.MatchAll());
            return response.Documents;
        }

        public async Task<T> GetDocumentAsync(string id)
        {
            var response = await _elasticsearchClient.GetAsync(new DocumentPath<T>(id));
            return response.Source;
        }

        public async Task<string> UpdateDocumentAsync(T document)
        {
            var response = await _elasticsearchClient.UpdateAsync(new DocumentPath<T>(document), u => u
                .Doc(document)
                .RetryOnConflict(3));

            return response.IsValid ? "Updated document successfully" : "Failed to update document";
        }
    }
}
