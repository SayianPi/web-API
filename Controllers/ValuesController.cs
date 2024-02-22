using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        //GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id) //primitive parameter
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value) //primitive parameter
        {
            //here, parameter 'value' is a primitive type so web api gets the value of primitive parameter 'value'
            //from query string by default but we can force web api to get the value of primitive parameter 'value'
            //from the request body instead of query string by using '[FromBody]'.
        }
       

        // PUT api/values/5
        public void Put(int id, [FromBody] string value) //primitive parameter
        {
        }

        // DELETE api/values/5
        public void Delete(int id) //primitive parameter AND VOID RETURN TYPE
        {
        }

        




        //[HttpGet]
        //public IEnumerable<string> Values()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //[HttpGet]
        //public string Value(int id)
        //{
        //    return "value";
        //}

        //[HttpPost]
        //public void SaveNewValue([FromBody] string value)
        //{
        //}

        //[HttpPut]
        //public void UpdateValue(int id, [FromBody] string value)
        //{
        //}

        //[HttpDelete]
        //public void RemoveValue(int id)
        //{
        //}
    }
}
