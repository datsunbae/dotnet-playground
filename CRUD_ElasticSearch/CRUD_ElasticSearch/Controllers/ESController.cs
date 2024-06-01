using CRUD_ElasticSearch.Models;
using CRUD_ElasticSearch.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_ElasticSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ESController : ControllerBase
    {
        private readonly IElastichsearchServices<Product> _elasticsearchServices;
        public ESController(IElastichsearchServices<Product> elasticsearchServices)
        {
            _elasticsearchServices = elasticsearchServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _elasticsearchServices.GetAllDocumentsAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllProducts(string id)
        {
            var result = await _elasticsearchServices.GetDocumentAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            var result = await _elasticsearchServices.CreateDocumentAsync(product);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            var result = await _elasticsearchServices.UpdateDocumentAsync(product);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            var result = await _elasticsearchServices.DeleteDocumentAsync(id);
            return Ok(result);
        }
    }
}
