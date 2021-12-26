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
    public class qualificationController : ControllerBase
    {
        public const string conn = "Server=tcp:businessio.database.windows.net,1433;Initial Catalog=mentor;Persist Security Info=False;User ID=rania;Password=Rannout345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        // GET: api/<qualification>
        [HttpGet]
        public IEnumerable<qualification> Get()
        {

            var qualificationList = new List<qualification>();

            string selectall = "select * from qualification";

            using (SqlConnection databaseConnection = new SqlConnection(conn))
            {
                using (SqlCommand selectCommand = new SqlCommand(selectall, databaseConnection))
                {
                    databaseConnection.Open();

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int qualification_Id = reader.GetInt32(0);
                            string qualification_name = reader.GetString(1);

                            qualificationList.Add(new qualification(qualification_Id, qualification_name));
                        }
                    }
                }
            }
            return qualificationList;

        }

        // GET api/<qualificationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            return "value";
        }

        // POST api/<qualificationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<qualificationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<qualificationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
