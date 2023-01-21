using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Calendar.Utility
{
    class DataManagement
    {
        // This method open the connection on Sqlite
        public void OpenConnection()
        {
            GlobalInfo.SQLiteConnection = new SQLiteConnection("Data Source=Calendar_Database;Version=3;");
            GlobalInfo.SQLiteConnection.Open();
            string tableSql = "create table if not exists Events(id integer PRIMARY KEY AUTOINCREMENT, " +
                                                                "Name text NOT NULL," +
                                                                "Start real NOT NULL," +
                                                                "End real NOT NULL ," +
                                                                "Date text NOT NULL ," +
                                                                "Iterable integer(0, 1));";
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
            using (SQLiteCommand command = new SQLiteCommand())
            {
                command.Connection = GlobalInfo.SQLiteConnection;
                command.CommandType = System.Data.CommandType.Text;
                string insertSql = "INSERT into Events(Name, Start, End, Date, Iterable) values (@name, @start, @end, @date, @iterable)";
                command.CommandText = insertSql;

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@start", start);
                command.Parameters.AddWithValue("@end", end);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@iterable", iterable);

                command.ExecuteNonQuery();
            }
        }

        /* This method select * from Events when Date is a param
        * @Param {string date}
        * @Return events List<string>
        */
        public List<string> ShowEvent(string date) 
        {
            List<string> events = new List<string>();
            string sql = "SELECT Name,Start,End,Iterable FROM Events WHERE Date=@date";
            using (SQLiteCommand command = new SQLiteCommand())
            {
                command.Connection = GlobalInfo.SQLiteConnection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = sql;

                command.Parameters.AddWithValue("@date", date);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Event event1 = new Event
                        {
                            Name = reader["Name"].ToString(),
                            Start = float.Parse(reader["Start"].ToString()),
                            End = float.Parse(reader["End"].ToString())
                        };

                        events.Add(event1.Name /*+ " " + event1.Start + " " + event1.End*/);
                    }
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
            using (SQLiteCommand command = new SQLiteCommand())        
            {
                command.Connection = GlobalInfo.SQLiteConnection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = sql;

                command.Parameters.AddWithValue("@date", date);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Event event1 = new Event();
                        event1.Id = int.Parse(reader["id"].ToString());
                        event1.Name = reader["Name"].ToString();
                        event1.Start = float.Parse(reader["Start"].ToString());
                        event1.End = float.Parse(reader["End"].ToString());
                        event1.Iterable = int.Parse(reader["Iterable"].ToString());
                        event1.Date = DateTime.Parse(reader["Date"].ToString());

                        events.Add(event1);
                    }
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
            using (SQLiteCommand command = new SQLiteCommand())
            {
                command.Connection = GlobalInfo.SQLiteConnection;
                command.CommandType = System.Data.CommandType.Text;
                string sqlUpdate = "UPDATE Events SET Name=@name, Start=@start, End=@end, Iterable=@iterable WHERE id=@id";
                command.CommandText = sqlUpdate;

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@start", start);
                command.Parameters.AddWithValue("@end", end);
                command.Parameters.AddWithValue("@iterable", iterable);

                command.ExecuteNonQuery();
            }
        }

        /* This method DELETE From Events when id is a param
         * @Param {int id}
         * return VOID
         */
        public void DeleteEvent(int id)
        {
            using (SQLiteCommand command = new SQLiteCommand())
            {
                command.Connection = GlobalInfo.SQLiteConnection;
                command.CommandType = System.Data.CommandType.Text;
                string sqlDelete = "DELETE FROM Events WHERE id=@id";
                command.CommandText = sqlDelete;

                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }
    }
}
