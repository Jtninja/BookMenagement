//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace BookMenagement.Api.Controllers
//{
//    [Produces("application/json")]
//    [Route("api/Currency")]
//    public class CurrencyController : Controller
//    {
//        // GET: api/Currency
//        [HttpGet]
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET: api/Currency/5
//        [HttpGet("{id}", Name = "Get")]
//        public string Get(int id)
//        {
//            return "value";
//        }
        
//        // POST: api/Currency
//        [HttpPost]
//        public void Post([FromBody]string value)
//        {
//        }
        
//        // PUT: api/Currency/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody]string value)
//        {
//        }
        
//        // DELETE: api/ApiWithActions/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
