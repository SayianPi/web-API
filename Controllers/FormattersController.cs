using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MyWebApi.Controllers
{
    public class FormattersController : ApiController
    {
         public IEnumerable<string> Get()
        {
            IList<string> formatters = new List<string>();

            foreach (var item in GlobalConfiguration.Configuration.Formatters)
            {
                formatters.Add(item.ToString());
            }

            return formatters.AsEnumerable<string>();
        } 

        /* public IEnumerable<string> Get()
        {
            IList<string> formatters = new List<string>();

            formatters.Add(GlobalConfiguration.Configuration.Formatters.JsonFormatter.GetType().FullName);
            formatters.Add(GlobalConfiguration.Configuration.Formatters.XmlFormatter.GetType().FullName);
            formatters.Add(GlobalConfiguration.Configuration.Formatters.FormUrlEncodedFormatter.GetType().FullName);

            return formatters.AsEnumerable<string>();
        } */
    }
}