using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderControl.Common.Exceptions
{
    class DatabaseLoginException : Exception
    {
        public DatabaseLoginException(string Username, string Database, string Message) : base(Message)
        {
            this.Username = Username;
            this.Database = Database;
        }

        public string Username
        {
            get;
            set;
        }

        public string Database
        {
            get;
            set;
        }
    }
}
