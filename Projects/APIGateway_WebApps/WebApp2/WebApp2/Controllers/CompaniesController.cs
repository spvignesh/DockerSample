using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp2.Models;

namespace WebApp2.Controllers
{
    public class CompaniesController : ApiController
    {
        public IEnumerable<Company> Get()
        {
            return Company.GetCompanies();
        }
    }
}
