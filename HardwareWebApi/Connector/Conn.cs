using System;
using System.Collections.Generic;
using HardwareWebApi.Model;
using Pomelo.Data.MySql;

namespace HardwareWebApi.Connector
{
    public class Conn
    {
        private string connstring;
        public Conn()
        {
			//connstring = @"server=sql12.freemysqlhosting.net;userid=;password=;database=sql12174637";
			connstring = @"server=localhost;userid=root;password=;database=vbislife";
        }

        public List<User> UserList(){

            List<User> allUser = new List<User>();


            using (MySqlConnection connMysql = new MySqlConnection(connstring)){

                using (MySqlCommand cmdd = connMysql.CreateCommand()){


                    cmdd.CommandText = "Select * from userlist";
                    cmdd.CommandType = System.Data.CommandType.Text;

                    cmdd.Connection = connMysql;

                    connMysql.Open();

                    using(MySqlDataReader reader = cmdd.ExecuteReader() ){

                        while (reader.Read())
                        {
                            allUser.Add(new User{                       id=reader.GetInt32(reader.GetOrdinal("id"))
                                                                        ,name=reader.GetString(reader.GetOrdinal("name"))
                                                                       ,password=reader.GetString(reader.GetOrdinal("password"))});
                        }
                    }
                }

                connMysql.Close();
            }



            return allUser;

        }


    }
}
