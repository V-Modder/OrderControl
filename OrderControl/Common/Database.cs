using MySql.Data.MySqlClient;
using OrderControl.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrderControl.Common
{
    public class Database
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int rowsEffected;
        private int rowCount;
        private string lastSQL;


        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// </summary>
        public Database(string Username, string Password)
        {

            server = "192.168.178.44";
            database = "OrderControl";
            uid = Username;
            password = Password;
            connection = new MySqlConnection(string.Format("Server={0};Database={1};Uid={2};Pwd={3}", server, database, uid, password));
        }

        /// <summary>
        /// Gets the rows effected.
        /// </summary>
        /// <value>The rows effected.</value>
        public int RowsEffected
        {
            get { return rowsEffected; }
        }

        /// <summary>
        /// Gets the row count.
        /// </summary>
        /// <value>The row count.</value>
        public int RowCount
        {
            get { return rowCount; }
        }

        /// <summary>
        /// Open Connection
        /// </summary>
        /// <returns></returns>
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                throw new DatabaseLoginException(this.uid, this.server + "/" + this.server, e.Message);
            }
        }

        /// <summary>
        /// Closes the connection.
        /// </summary>
        /// <returns>true if connection is closed, false otherwise.</returns>
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Inserts the specified SQL.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        public void Insert(string sql)
        {
            ExecuteNonQuery(sql, true);
        }

        /// <summary>
        /// Updates the specified SQL.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        public void Update(string sql)
        {
            ExecuteNonQuery(sql, false);
        }

        /// <summary>
        /// Deletes the specified SQL.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        public void Delete(string sql)
        {
            ExecuteNonQuery(sql, false);
        }

        
        private int ExecuteNonQuery(string sql, bool returnValue, params object[] parameter)
        {
            string[] paramName = null;
            MySqlParameter[] param = null;
            if (paramName.Length > 0)
            {
                if (parameter.Length > 0)
                {
                    paramName = getAllParameterNames(sql);
                    param = getParameter(parameter, paramName);
                }
                else
                {
                    throw new Exception("{0} parameter set, {0} defined\n"); 
                }
            }

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.AddRange(param.ToArray());

                string query = sql;
                if (returnValue)
                {
                    query += " SET @ID = SCOPE_IDENTITY();";
                    cmd.Parameters.Add("@ID", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                }

                cmd.CommandText = query;
                    //Execute command
                    rowsEffected = cmd.ExecuteNonQuery();
                

                //close connection
                this.CloseConnection();
                if (returnValue)
                {
                    return (int)cmd.Parameters["@ID"].Value;
                }
            }
            return 0;
        }

        /// <summary>
        /// Selects the specified SQL.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <param name="parameter">The parameter.</param>
        /// <returns>DataTable.</returns>
        public DataTable Select(string sql, params object[] parameter)
        {
            string query = sql;
            string[] paramName = null;
            MySqlParameter[] param = null;
            if (parameter.Length > 0)
            {
                paramName = getAllParameterNames(sql);
                if (paramName.Length > 0)
                {
                    param = getParameter(parameter, paramName);
                }
                else
                {
                    throw new Exception("{0} parameter set, {0} defined\n");
                }
            }

            //Open connection
            if (this.OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddRange(param.ToArray());
                //Create a data reader and Execute the command
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(cmd);

                //Read the data and store them in the list
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);

                //close Connection
                CloseConnection();

                //return list to be displayed
                return dt;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Skalars the specified SQL.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <param name="parameter">The parameter.</param>
        /// <returns>System.Object.</returns>
        public object Skalar(string sql, params object[] parameter)
        {
            string query = sql;
            string[] paramName = null;
            MySqlParameter[] param = null;
            if (parameter.Length > 0)
            {
                paramName = getAllParameterNames(sql);
                if (paramName.Length > 0) {
                    param = getParameter(parameter, paramName);
                }
                else
                {
                    throw new Exception("{0} parameter set, {0} defined\n");
                }
            }

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                //Create a data reader and Execute the command
                object ret = null;
                try
                {
                    ret = cmd.ExecuteScalar();
                }
                catch (Exception e)
                {
                    int x = 0;
                }
              
                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return ret;
            }
            else
            {
                return null;
            }
        }

        private static string[] getAllParameterNames(string sqlQuery)
        {
            MatchCollection coll = Regex.Matches(sqlQuery,   @"(?<Parameter>@\w*)");
            string[] ret = new string[coll.Count];
            for (int i = 0; i < coll.Count; i++)
            {
                if (coll[i].Success)
                {
                    ret[i] = coll[i].Value;
                }
            }

            return ret;
        }

        private static MySqlParameter[] getParameter(object[] paramList, string[] paramName)
        {
            MySqlParameter[] commList = new MySqlParameter[paramList.Length];
            for (int i = 0; i < paramList.Length; i++)
            {
                commList[i] = new MySqlParameter(paramName[i], paramList[i]);
            }

            return commList;
        }
    }
}
