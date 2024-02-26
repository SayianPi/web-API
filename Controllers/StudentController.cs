using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApi.Controllers
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class StudentController : ApiController
    {

        //you can combine both techniques in the same project.

        //Attribute Routing
        [Route("api/student/prayer")]  //url for attribute routing
        public IEnumerable<string> Get()
        {
            return new string[] { "God is great. I believe in higher power." };
        }

      

        //convention-based routing
        //this gets executed when we use the conventional based routing url from school route in WebApiConfig file 
        [HttpGet]
        public string Value(int id) //primitive parameter
        {
            return "studentname1";
        }


        public void Post(int id, Student value) //mixed parameter (primitive + complex)
            //Post action method cannot include multiple complex type parameters because, at most,
            //one parameter is allowed to be read from the request body.
        {
            //By default: 
            // - Web api gets the value of primitive parameter from query string
            // - eg: https://localhost:44320/api/student/1 here '1' is taken from the query string itself

            // - Web api gets the value of complex parameter from request body
            // - visit https://www.tutorialsteacher.com/webapi/parameter-binding-in-web-api for clear understanding.

            // - But opposite of the default rules:
            // - Use '[FromUri]' attribute to force Web API to get the value of complex type from the query string
            // - Use '[FromBody]' attribute to get the value of primitive type from the request body
        }

      
        /*public int GetId(string name)  //-> PRIMITIVE RETURN TYPE
        {
            int id = GetStudentId(name);

            return id;
        }

        public Student GetStudent(int id) //-> COMPLEX RETURN TYPE
        {
            var student = GetStudentFromDB(id);

            return student;
        }
        
         
        public HttpResponseMessage Get(int id) //-> RETURN HttpResponseMessage TYPE
        {
            Student stud = GetStudentFromDB(id);

            if (stud == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, id);
            }

            return Request.CreateResponse(HttpStatusCode.OK, stud);
        }
        
        public IHttpActionResult Get(int id)  //-> Return IHttpActionResult Type
        {
            Student stud = GetStudentFromDB(id);

            if (stud == null)
            {
                return NotFound(); //here NotFound() and Ok() method does it all for us, 
                                   //we don't have to write much code. There are other apicontroller methods
                                   // visit https://www.tutorialsteacher.com/webapi/action-method-return-type-in-web-api
            }

            return Ok(stud);
        } */

    }
    
}
