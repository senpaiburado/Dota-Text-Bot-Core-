using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DotaTextGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string connection = "Server=localhost;Uid=root;pwd=xjkfr2017";
            User.con = new MySql.Data.MySqlClient.MySqlConnection(connection);

            MySql.Data.MySqlClient.MySqlCommand com = new MySql.Data.MySqlClient.MySqlCommand("", User.con);
            User.con.Open();
            com.CommandText = "CREATE DATABASE IF NOT EXISTS User;";
            com.ExecuteNonQuery();
            com.CommandText = "USE User;";
            com.ExecuteNonQuery();
            com.CommandText = "CREATE TABLE IF NOT EXISTS user (id BIGINT, name VARCHAR(30), language VARCHAR(25), wins INT, loses INT, rating BIGINT);";
            com.ExecuteNonQuery();
            User.con.Close();
            com = null;
            Main main = new Main();
            main.bw_DoWork("347404910:AAHBQ4as_Z05pDctUYD5go0rtbXM78Fk92E").Wait();
        }
    }
}
