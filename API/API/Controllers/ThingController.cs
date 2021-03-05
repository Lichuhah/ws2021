using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient; //загружаем в NuGet
using Newtonsoft.Json; //загружаем в NuGet
using System.Data;

public class Thing //класс - копия таблицы (не для entity)
{
    public int id { get; set; }
    public string name { get; set; }
}

namespace API.Controllers
{
    [Route("api")]
    [ApiController]
    public class ThingController : ControllerBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7URV59U\SQLEXPRESS;Initial Catalog=bd;Integrated Security=True"); //здесь своя строка подключения (не для entity)
       
        // GET: api/
        [HttpGet]
        public List<Thing> Get()
        {
            //задача - получить заполненный List<Thing> и вернуть его
            con.Open();        
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM thing", con);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<Thing> things = new List<Thing>();
            while (reader.Read())
            {
                Thing thing = new Thing();
                thing.id = Convert.ToInt32(reader["id"]);
                thing.name = Convert.ToString(reader["name"]);
                things.Add(thing);
            }

            reader.Close();
            con.Close();
            return things;
        }

        // GET api/5
        [HttpGet("{id}")]
        public Thing Get(int id)
        {
            //задача - получить Thing и вернуть его
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM thing where id = @id", con);
            sqlCommand.Parameters.AddWithValue("id", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<Thing> things = new List<Thing>();
            reader.Read();
            Thing thing = new Thing();
            thing.id = Convert.ToInt32(reader["id"]);
            thing.name = Convert.ToString(reader["name"]);

            reader.Close();
            con.Close();
            return thing;
        }

        // POST api/
        [HttpPost]
        public void Post([FromBody] Thing value) //принимаем на вход класс!
        {
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO thing VALUES (@name)", con);
            sqlCommand.Parameters.AddWithValue("name", value.name);
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        // PUT api/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Thing value) //принимаем на вход класс!
        {
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE thing SET[name] = @name WHERE id=@id", con);
            sqlCommand.Parameters.AddWithValue("id", id);
            sqlCommand.Parameters.AddWithValue("name", value.name);
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        // DELETE api/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM thing WHERE id=@id", con);
            sqlCommand.Parameters.AddWithValue("id", id);
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
