using demoappMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace demoappMVC.Controllers
{
    public class ProductController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }
        [Route("api/product/getname")]
        [ActionName("GetName")]
        // api/<controller>/<methodname>/2
        public string GetName(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        [ActionName("Pst")]
        [Route("Pst")]
        public void Post([FromBody]string value)
        {
        }

        // eg: api/proudct/addproduct
        public List<ProductModel> PostProudct(ProductModel productModel)
        {
            List<ProductModel> productModels = new List<ProductModel>();
            ProductModel pModel = new ProductModel();
            pModel.ProductId = 2;
            pModel.Name = "Shirt";
            pModel.PurchaseDate = DateTime.Now.AddDays(-2);
            productModels.Add(pModel);
            return productModels;
        }

        public List<ProductModel> PostProudct(int id,ProductModel productModel)
        {
            List<ProductModel> productModels = new List<ProductModel>();
            ProductModel pModel = new ProductModel();
            pModel.ProductId = 2;
            pModel.Name = "Shirt";
            pModel.PurchaseDate = DateTime.Now.AddDays(-2);
            productModels.Add(pModel);
            return productModels;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }


       
    }
}