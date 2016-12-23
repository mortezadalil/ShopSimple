using System.Collections.Generic;
using System.Web.Http;
using Shop.Repository;

namespace Shop.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public ValuesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET api/values // Authorization : bearer access_token
        public IEnumerable<string> Get()
        {
            var d = _unitOfWork.ProductRepository.GetTopProductsByCost(1);
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
