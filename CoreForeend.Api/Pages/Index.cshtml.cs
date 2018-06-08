using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBackend.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using RestSharp;

namespace CoreForeend.Api.Pages
{
    public class IndexModel : PageModel
    {
        CoreBackend.Api.Models.Connection conn ;
        public IndexModel(IOptions<Connection> option)
        {
            conn = option.Value;
        }
        public void OnGet()
        {
            string url = string.Format("{0}/GetProducts", conn.WebApiConnection);
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
        }
    }
}
