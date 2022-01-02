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
    public class sub_qualificationController : ControllerBase
    {
        public const string conn = "Server=tcp:businessio.database.windows.net,1433;Initial Catalog=mentor;Persist Security Info=False;User ID=rania;Password=Rannout345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        // GET: <sub_qualificationController>
        [HttpGet]
        public IEnumerable<sub_qualification> Get()
        {
            var sub_qualificationList = new List<sub_qualification>();

            string selectall = "select * from sub_qualification";

            using (SqlConnection databaseConnection = new SqlConnection(conn))
            {
                using (SqlCommand selectCommand = new SqlCommand(selectall, databaseConnection))
                {
                    databaseConnection.Open();

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int sub_qualification_Id = reader.GetInt32(0);
                            string sub_qualification_name = reader.GetString(1);
                            int qualification_Id = reader.GetInt32(2);

                            sub_qualificationList.Add(new sub_qualification(sub_qualification_Id, qualification_Id, sub_qualification_name));

                        }
                    }
                }
            }
            return sub_qualificationList;

        }

        // GET <sub_qualificationController>/5
        [HttpGet("{id}")]
        public IEnumerable<sub_qualification> GetSubBusiness(int id)
        {
            List<sub_qualification> sub_qualificationList = new List<sub_qualification>();

            var selectByID = "select * from sub_qualification WHERE qualification_Id =@id";

            using (SqlConnection databaseConnection = new SqlConnection(conn))
            {
                using (SqlCommand selectCommand = new SqlCommand(selectByID, databaseConnection))
                {
                    selectCommand.Parameters.AddWithValue("@id", id);
                    databaseConnection.Open();
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int sub_qualification_Id = reader.GetInt32(0);
                            string sub_qualification_name = reader.GetString(1);
                            int Id = reader.GetInt32(2);
                           sub_qualificationList.Add(new sub_qualification(sub_qualification_Id, Id, sub_qualification_name));
                        }
                    }
                }
            }
            return sub_qualificationList ;

        }

        // POST api/<sub_qualificationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<sub_qualificationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<sub_qualificationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
