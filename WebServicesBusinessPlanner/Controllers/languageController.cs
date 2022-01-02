using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebServicesBusinessPlanner.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebServicesBusinessPlanner.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class languageController : ControllerBase
    {
        public const string conn = "Server=tcp:businessio.database.windows.net,1433;Initial Catalog=mentor;Persist Security Info=False;User ID=rania;Password=Rannout345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        // GET: <languageController>
        [HttpGet]
        public IEnumerable<language> Get()
        {
            var languageList = new List<language>();

            string selectall = "select * from language";

            using (SqlConnection databaseConnection = new SqlConnection(conn))
            {
                using (SqlCommand selectCommand = new SqlCommand(selectall, databaseConnection))
                {
                    databaseConnection.Open();

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int language_Id = reader.GetInt32(0);
                            string language_name = reader.GetString(1);

                            languageList.Add(new language(language_Id, language_name));
                        }
                    }
                }
            }
            return languageList;
        }

        // GET api/<languageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<languageController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<languageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<languageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
