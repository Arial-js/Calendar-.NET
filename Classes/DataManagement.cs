using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Calendar.Utility
{
    class DataManagement
    {
        // this method open the connection on Sqlite
        public void OpenConnection()
        {
            GlobalInfo.SQLiteConnection = new SQLiteConnection("Data Source=Calendar_Database;Version=3;");
            GlobalInfo.SQLiteConnection.Open();
            string tableSql = "create table if not exists Events(Name text NOT NULL,Start real(1,24) NOT NULL,End real(1,24) NOT NULL ,Date text NOT NULL ,Iterable integer(0, 1));";
            SQLiteCommand command = new SQLiteCommand(tableSql, GlobalInfo.SQLiteConnection);
            command.ExecuteNonQuery();
        }

        // this method close the connection on Sqlite
        public void CloseConnection()
        {
            GlobalInfo.SQLiteConnection.Close();
        }

        // this method is an insert on Events Table 
        public void CreateEvent(string name, float start, float end, string date, int iterable)
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GlobalInfo.SQLiteConnection;
            command.CommandType = System.Data.CommandType.Text;
            string insertSql = string.Format("insert into Events values ('{0}', '{1}', '{2}', '{3}', '{4}')", name, start, end, date, iterable);
            command.CommandText = insertSql;
            command.ExecuteNonQuery();
        }

        // this method select from Events when Date is a param
        public List<string> ShowEvent(string date) 
        {
            List<string> events = new List<string>();
            string sql = "select Name,Start,End,Iterable from Events where Date=@date";
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
    }
}
