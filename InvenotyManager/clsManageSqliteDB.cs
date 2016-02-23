using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Data.SQLite;

namespace InvenotyManager
{
    class clsManageSqliteDB
    {

        public string   GetConnectionString() 
        {            
            string base_path = AppDomain.CurrentDomain.BaseDirectory;
            string full_path = Path.Combine(base_path, "inventory_database.s3db");
            string connString = "data source=" + full_path + "; Version=3;";


            return connString;
        }
        
        public DataTable GetDataTable(string query) 
        {
            
            string connString = this.GetConnectionString();
            SQLiteDataAdapter  dAdapter = new SQLiteDataAdapter(query, connString);            
            DataTable dTable = new DataTable();

            dAdapter.Fill(dTable);

            dAdapter.Dispose(); 
            return dTable;
        
        }


        public string  GetScalarValue(string query) 
        {
            string connString = this.GetConnectionString();
            SQLiteConnection cnn = new SQLiteConnection(connString);
            SQLiteCommand command = new SQLiteCommand();

            command.Connection = cnn;
            cnn.Open();
            command.CommandText = query;
            
            string result =   command.ExecuteScalar().ToString();
            
            cnn.Dispose();
            command.Dispose();

            return result; 
        
        }

        
        public int ExecuteQuery(string query) 
        {
            string connString = this.GetConnectionString();

            SQLiteConnection  cnn = new SQLiteConnection(connString);            
            SQLiteCommand  command = new SQLiteCommand();
            
            command.Connection = cnn;
            command.CommandText = query;

            cnn.Open();
            int result = command.ExecuteNonQuery();
            
            cnn.Dispose();
            command.Dispose();

            return result;

        }

    }
}
