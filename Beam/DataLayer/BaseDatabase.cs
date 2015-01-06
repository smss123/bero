using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public abstract class BaseDatabase
    {
        public delegate void OnchangeCallBackX(string msg);
        public static event OnchangeCallBackX StatusChange;

        public static dbDataContext db = new dbDataContext();
        public static void ini()
        {
            db = new dbDataContext();
            db.Connection.StateChange += Connection_StateChange;
        }

        static void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            StatusChange(e.CurrentState.ToString());
        }
        protected static void StartConnection()
        {
            if (db.Connection.State!= System.Data.ConnectionState.Open)
            {
                db.Connection.OpenAsync();
                StatusChange(db.Connection.State.ToString());

            }
        }
        protected static void CloseConnection()
        {
            if (db.Connection.State == System.Data.ConnectionState.Open)
            {
                db.Connection.Close();
                StatusChange(db.Connection.State.ToString());
            }
        }

    }
}
