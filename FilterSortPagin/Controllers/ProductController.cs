using FilterSortPagin.DbContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sieve.Models;
using Sieve.Services;
using FilterSortPagin.DbContext;

namespace FilterSortPagin.Controllers
{
    
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductDB _productDB;
        private readonly SieveProcessor _sieveProcessor;

        public ProductController(ProductDB productDB, SieveProcessor sieveProcessor)
        {
            _productDB = productDB;
            _sieveProcessor = sieveProcessor;
        }

        [Route("GetProducts")]
        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] SieveModel model)
        {
            var products = _productDB.ProductDataContext.AsQueryable();
            products = _sieveProcessor.Apply(model, products);
            return Ok();
        }

    }
}
