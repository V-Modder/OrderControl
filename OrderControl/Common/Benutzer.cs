using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderControl.Common
{
    public class Benutzer
    {
        private int iD;
        private int rechtegruppe;
        private string username;
        private string name;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public int Rechtegruppe
        {
            get { return rechtegruppe; }
            set { rechtegruppe = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
