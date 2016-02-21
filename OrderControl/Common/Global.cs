using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderControl.Common
{
    public class Global
    {
        private Database dataBase;
        private Benutzer benutzer;

        public Benutzer Benutzer
        {
            get { return benutzer; }
            //set { benutzer = value; }
        }

        public Database DataBase
        {
            get { return dataBase; }
            //set { dataBase = value; }
        }


        public bool Login(string username, string password)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT ID,");
                sql.Append(" cLieferant,");
                sql.Append(" tRechte_ID");
                sql.Append(" FROM");
                sql.Append(" tBenutzer");
                sql.Append(" WHERE cLogin=@cLogin");
                //List<MySqlParameter> param = new List<MySqlParameter>();
                //MySqlParameter login = new MySqlParameter("@cLogin", MySqlDbType.VarChar);
                //login.Value = username;
                //param.Add(login);
                Benutzer benutz = new Benutzer();
                Database db = new Database(username, password);
                DataTable dt = db.Select(sql.ToString(), username);
                benutz.ID = dt.Rows[0].Field<int>("ID");
                benutz.Name = dt.Rows[0].Field<string>("cLieferant");
                benutz.Username = username;
                benutz.Rechtegruppe = dt.Rows[0].Field<int>("tRechte_ID");
                dataBase = db;
                benutzer = benutz;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
