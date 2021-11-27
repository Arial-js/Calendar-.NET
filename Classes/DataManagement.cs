using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace Calendar.Utility
{
    class DataManagement
    {
        // This method open the connection on Sqlite
        public void OpenConnection()
        {
            GlobalInfo.SQLiteConnection = new SQLiteConnection("Data Source=Calendar_Database;Version=3;");
            GlobalInfo.SQLiteConnection.Open();
            string tableSql = "create table if not exists Events(id integer PRIMARY KEY AUTOINCREMENT, Name text NOT NULL,Start real(1, 24) NOT NULL,End real(1, 24) NOT NULL ,Date text NOT NULL ,Iterable integer(0, 1));";
            SQLiteCommand command = new SQLiteCommand(tableSql, GlobalInfo.SQLiteConnection);
            command.ExecuteNonQuery();
        }

        // This method close the connection on Sqlite
        public void CloseConnection()
        {
            GlobalInfo.SQLiteConnection.Close();
        }

        /* This method is an insert on Events Table
         * @Param {string name}
         * @Param {float start}
         * @Param {float end}
         * @Param {string date}
         * @Param {int iterable}
         * @Return VOID
         */
        public void CreateEvent(string name, float start, float end, string date, int iterable)
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GlobalInfo.SQLiteConnection;
            command.CommandType = System.Data.CommandType.Text;
            string insertSql = string.Format("INSERT into Events(Name, Start, End, Date, Iterable) values ('{0}', '{1}', '{2}', '{3}', '{4}')", name, start, end, date, iterable);
            command.CommandText = insertSql;
            command.ExecuteNonQuery();
        }

        /* This method select * from Events when Date is a param
        * @Param {string date}
        * @Return events List<string>
        */
        public List<string> ShowEvent(string date) 
        {
            List<string> events = new List<string>();
            string sql = "SELECT Name,Start,End,Iterable FROM Events WHERE Date=@date";
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GlobalInfo.SQLiteConnection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;

            SQLiteParameter parDate = new SQLiteParameter();
            parDate.DbType = System.Data.DbType.String;
            parDate.ParameterName = "@date";
            parDate.Value = date;

            command.Parameters.Add(parDate);

            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Event event1 = new Event();
                    event1.Name = reader["Name"].ToString();
                    event1.Start = float.Parse(reader["Start"].ToString());
                    event1.End = float.Parse(reader["End"].ToString());
                    //event1.Iterable = int.Parse(reader["Iterable"].ToString());

                    events.Add(event1.Name /*+ " " + event1.Start + " " + event1.End*/);
                }
            }
            return events;
        }

        /* This method select * from Events when Date is a param
         * @Param {string date}
         * @Return events List<Event>
         */
        public List<Event> ShowListEvents(string date)
        {
            List<Event> events = new List<Event>();
            string sql = "SELECT * FROM Events WHERE Date=@date";
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GlobalInfo.SQLiteConnection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;

            SQLiteParameter parDate = new SQLiteParameter();
            parDate.DbType = System.Data.DbType.String;
            parDate.ParameterName = "@date";
            parDate.Value = date;

            command.Parameters.Add(parDate);

            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Event event1 = new Event();
                    event1.id = int.Parse(reader["id"].ToString());
                    event1.Name = reader["Name"].ToString();
                    event1.Start = float.Parse(reader["Start"].ToString());
                    event1.End = float.Parse(reader["End"].ToString());
                    event1.Iterable = int.Parse(reader["Iterable"].ToString());
                    event1.Date = DateTime.Parse(reader["Date"].ToString());

                    events.Add(event1);
                }
            }
            return events;
        }

        /* This method UPDATE * but id from Events when id is a param
        * @Param {int id}
        * @Param {float start}
        * @Param {float end}
        * @Param {string date}
        * @Param {int iterable}
        * @Return VOID
        */
        public void UpdateEvent(int id, string name, double start, double end, int iterable)
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GlobalInfo.SQLiteConnection;
            command.CommandType = System.Data.CommandType.Text;
            string sqlUpdate = "UPDATE Events SET Name=@name, Start=@start, End=@end, Iterable=@iterable WHERE id=@id";
            command.CommandText = sqlUpdate;

            SQLiteParameter param = new SQLiteParameter();
            param.DbType = System.Data.DbType.String;
            param.ParameterName = "@name";
            param.Value = name;

            command.Parameters.Add(param);


            param = new SQLiteParameter();
            param.DbType = System.Data.DbType.Double;
            param.ParameterName = "@start";
            param.Value = start;

            command.Parameters.Add(param);


            param = new SQLiteParameter();
            param.DbType = System.Data.DbType.Double;
            param.ParameterName = "@end";
            param.Value = end;

            command.Parameters.Add(param);

            param = new SQLiteParameter();
            param.DbType = System.Data.DbType.Int32;
            param.ParameterName = "@iterable";
            param.Value = iterable;

            command.Parameters.Add(param);

            param = new SQLiteParameter();
            param.DbType = System.Data.DbType.Int32;
            param.ParameterName = "@id";
            param.Value = id;

            command.Parameters.Add(param);

            command.ExecuteNonQuery();
        }

        /* This method UPDATE Name from Events when name is a param
         * @Param {string name}
         * @Return VOID
         */
        public void UpdateEventName(int id, string name)
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GlobalInfo.SQLiteConnection;
            command.CommandType = System.Data.CommandType.Text;
            string sqlUpdate = "UPDATE Events SET Name=@name WHERE id=@id";
            command.CommandText = sqlUpdate;

            SQLiteParameter param = new SQLiteParameter();
            param.DbType = System.Data.DbType.String;
            param.ParameterName = "@name";
            param.Value = name;

            command.Parameters.Add(param);

            param = new SQLiteParameter();
            param.DbType = System.Data.DbType.Int32;
            param.ParameterName = "@id";
            param.Value = id;

            command.Parameters.Add(param);

            command.ExecuteNonQuery();
        }

        /* This method UPDATE Start from Events when name is a param
        * @Param {int start}
        * @Return VOID
        */
        public void UpdateEventStart(int id, double start)
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GlobalInfo.SQLiteConnection;
            command.CommandType = System.Data.CommandType.Text;
            string sqlUpdate = "UPDATE Events SET Start=@start WHERE id=@id";
            command.CommandText = sqlUpdate;

            SQLiteParameter param = new SQLiteParameter();
            param.DbType = System.Data.DbType.Double;
            param.ParameterName = "@start";
            param.Value = start;

            command.Parameters.Add(param);

            param = new SQLiteParameter();
            param.DbType = System.Data.DbType.Int32;
            param.ParameterName = "@id";
            param.Value = id;

            command.Parameters.Add(param);

            command.ExecuteNonQuery();
        }

        /* This method UPDATE End from Events when end is a param
        * @Param {int end}
        * @Return VOID
        */
        public void UpdateEventEnd(int id, double end)
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GlobalInfo.SQLiteConnection;
            command.CommandType = System.Data.CommandType.Text;
            string sqlUpdate = "UPDATE Events SET End=@end WHERE id=@id";
            command.CommandText = sqlUpdate;

            SQLiteParameter param = new SQLiteParameter();
            param.DbType = System.Data.DbType.Double;
            param.ParameterName = "@end";
            param.Value = end;

            command.Parameters.Add(param);

            param = new SQLiteParameter();
            param.DbType = System.Data.DbType.Int32;
            param.ParameterName = "@id";
            param.Value = id;

            command.Parameters.Add(param);

            command.ExecuteNonQuery();
        }

        /* This method UPDATE Iterable from Events when iterable is a param
        * @Param {int iterable}
        * @Return VOID
        */
        public void UpdateEventIterable(int id, int iterable)
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GlobalInfo.SQLiteConnection;
            command.CommandType = System.Data.CommandType.Text;
            string sqlUpdate = "UPDATE Events SET Iterable=@iterable WHERE id=@id";
            command.CommandText = sqlUpdate;

            SQLiteParameter param = new SQLiteParameter();
            param.DbType = System.Data.DbType.Int32;
            param.ParameterName = "@iterable";
            param.Value = iterable;

            command.Parameters.Add(param);

            param = new SQLiteParameter();
            param.DbType = System.Data.DbType.Int32;
            param.ParameterName = "@id";
            param.Value = id;

            command.Parameters.Add(param);

            command.ExecuteNonQuery();
        }

        /* This method DELETE From Events when id is a param
         * @Param {int id}
         * return VOID
         */
        public void DeleteEvent(int id)
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GlobalInfo.SQLiteConnection;
            command.CommandType = System.Data.CommandType.Text;
            string sqlDelete = "DELETE FROM Events WHERE id=@id";
            command.CommandText = sqlDelete;

            SQLiteParameter param = new SQLiteParameter();
            param.DbType = System.Data.DbType.Int32;
            param.ParameterName = "@id";
            param.Value = id;

            command.Parameters.Add(param);
            command.ExecuteNonQuery();
        }
    }
}
