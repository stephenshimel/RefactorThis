using System;
using Microsoft.AspNetCore.Mvc;
using RefactorThis.Models;
using RefactorThis.Business;

using System.Threading.Tasks;


namespace RefactorThis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public Products Get()
        {
            return BusinessHandler.loadProducts("");
        }

        [HttpGet("{id}")]
        public Product Get(Guid id)
        {
            return BusinessHandler.loadProduct(id);
        }

        [HttpPost]
        public void Post(Product product)
        {
            BusinessHandler.addNewProduct(product);
        }

        [HttpPut("{id}")]
        public void Update(Guid id, Product product)
        {
            BusinessHandler.editProduct(id, product);

        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            BusinessHandler.deleteProduct(id);

        }

        [HttpGet("{productId}/options")]
        public void GetOptions(Guid productId)
        {
            BusinessHandler.getProductOptions(productId);
        }

        [HttpGet("{productId}/options/{id}")]
        public void GetOption(Guid productId, Guid id)
        {
            BusinessHandler.getOption(id);
        }

        [HttpPost("{productId}/options")]
        public void CreateOption(Guid productId, ProductOption option)
        {
            BusinessHandler.createOptionForProduct(productId, option);
        }

        [HttpPut("{productId}/options/{id}")]
        public void UpdateOption(Guid productId, Guid id)
        {
            BusinessHandler.updateOptionForProduct(productId, id);

        }

        [HttpDelete("{productId}/options/{id}")]
        public void DeleteOption(Guid productId, Guid id)
        {
            BusinessHandler.deleteOptionForProduct(productId, id);
        }
    }
}