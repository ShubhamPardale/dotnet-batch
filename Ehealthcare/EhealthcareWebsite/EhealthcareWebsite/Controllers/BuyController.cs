using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace EhealthcareWebsite.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;

        public BuyController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        [HttpGet]
        public JsonResult Get(string id)
        {
            string query = @"
                            select * from dbo.Medicines
                             where med_id=@med_id
                           ";

            DataTable dt = new DataTable();
            string datasource = _configuration.GetConnectionString("Ehealthcon");
            SqlDataReader reader;
            using (SqlConnection con = new SqlConnection(datasource))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@med_id", id);
                    reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    con.Close();
                }
            }
            return new JsonResult(dt);
        }

    }
}
