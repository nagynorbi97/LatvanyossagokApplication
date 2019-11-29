using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LatvanyossagokApplication {
    static class dbHelper {
        public static MySqlConnection Conn() {
            MySqlConnection conn = new MySqlConnection("Server=localhost; Port=3306; Database=latvanyossagokdb; Uid=root; Pwd=; Charset=utf8");
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SET CHARACTER SET 'utf8';";
            //cmd.ExecuteNonQuery();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS varosok ( 
                id INT PRIMARY KEY AUTO_INCREMENT,
	            nev VARCHAR(25) UNIQUE NOT NULL,
	            lakossag INT NOT NULL
            );";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS latvanyossagok ( 
                id INT PRIMARY KEY AUTO_INCREMENT,
	            nev VARCHAR(100) NOT NULL,
	            leiras VARCHAR(1000) NOT NULL,
                ar INT NOT NULL DEFAULT 0,
                varos_id INT NOT NULL,
	            FOREIGN KEY (varos_id) REFERENCES varosok(id)
            );";
            cmd.ExecuteNonQuery();
            return conn;
        }
    }
}
