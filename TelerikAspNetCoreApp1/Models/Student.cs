using Npgsql;

namespace TelerikAspNetCoreApp1.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string  course { get; set; }
        public string  bracnh { get; set; }

        public static List<Student> getstudent()
        {
            List<Student> students = new List<Student>();
            NpgsqlConnection con = new NpgsqlConnection(connection());
            con.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select * from student", con);
            NpgsqlDataReader dr =cm.ExecuteReader();    
                while(dr.Read()) {
                Student st = new Student();
                st.id = dr.GetInt32(0);
                st.name = dr.GetString(1);
                st.course = dr.GetString(2);
                st.bracnh = dr.GetString(3);
                students.Add(st);
            }


            return students;
        {

        }
        }













        private static string connection()
        {
            return "user id=postgres;password=amit8888;host=localhost;port=5432;database=Test; ";
        }

    }
}
