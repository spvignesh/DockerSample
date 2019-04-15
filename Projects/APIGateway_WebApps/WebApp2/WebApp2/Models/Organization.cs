using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Founder { get; set; }

        public static List<Company> GetCompanies()
        {
            var companies = new List<Company> {
            new Company{ ID=1, Name = "Toyota", Founder ="Kiichiro Toyoda"},
            new Company { ID=2, Name ="Rakuten", Founder ="Hiroshi Mikitani"},
            new Company { ID=3, Name="Berkshire Hathaway", Founder ="Oliver Chace"},
            new Company { ID=4, Name = "Walmart", Founder ="Sam Walton"},
            new Company { ID=5, Name = "Amazon", Founder ="Jeff Bezos"} };

            return companies;
        }
    }
}