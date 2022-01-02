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
    public class fieldController : ControllerBase
    {
        public const string conn = "Server=tcp:businessio.database.windows.net,1433;Initial Catalog=mentor;Persist Security Info=False;User ID=rania;Password=Rannout345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        // GET: api/<fieldController>
        [HttpGet]
        public IEnumerable<field> Get()
        {
            var fieldList = new List<field>();

            string selectall = "select * from field";

            using (SqlConnection databaseConnection = new SqlConnection(conn))
            {
                using (SqlCommand selectCommand = new SqlCommand(selectall, databaseConnection))
                {
                    databaseConnection.Open();

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int field_Id = reader.GetInt32(0);
                            string field_name = reader.GetString(1);

                            fieldList.Add(new field(field_Id, field_name));
                        }
                    }
                }
            }
            return fieldList;
        }

        // GET api/<fieldController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<fieldController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<fieldController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<fieldController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
