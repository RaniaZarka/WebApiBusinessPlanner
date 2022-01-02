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
    public class mentorController : ControllerBase
    {
        public const string conn = "Server=tcp:businessio.database.windows.net,1433;Initial Catalog=mentor;Persist Security Info=False;User ID=rania;Password=Rannout345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        // GET: api/<mentorController>
        [HttpGet]
        public IEnumerable<mentor> Get()
        {

            var mentorList = new List<mentor>();

            string selectall = "select * from mentor";

            using (SqlConnection databaseConnection = new SqlConnection(conn))
            {
                using (SqlCommand selectCommand = new SqlCommand(selectall, databaseConnection))
                {
                    databaseConnection.Open();

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int mentor_Id = reader.GetInt32(0);
                            string mentor_name = reader.GetString(1);
                            string mentor_description = reader.GetString(2);
                           
                            string mentor_experience = reader.GetString(3);
                            string mentor_education = reader.GetString(4);
                            string mentor_pic = reader.GetString(5);
                            

                            mentorList.Add(new mentor(mentor_Id, mentor_name, mentor_description,  mentor_experience, mentor_education, mentor_pic));
                        }
                    }
                }
            }
            return mentorList;
        }


            // GET api/<mentorController>/5
            [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<mentorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<mentorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<mentorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
