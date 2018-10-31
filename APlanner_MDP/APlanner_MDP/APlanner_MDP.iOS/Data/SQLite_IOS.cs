using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Foundation;
using UIKit;
using APlanner_MDP.Data;
using APlanner_MDP.iOS.Data;
using Xamarin.Forms;
using SQLite;

[assembly: Dependency(typeof(SQLite_IOS))]

namespace APlanner_MDP.iOS.Data
{
    public class SQLite_IOS : sql_lite
    {
        public SQLite_IOS()
        {
        }
        public SQLite.SQLiteConnection GetConnection()
        {
            var fileName = "database.db3";
            var documentpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentpath, "..", "Libary");
            var path = Path.Combine(libraryPath, fileName);
            var connction = new SQLite.SQLiteConnection(path);
            return connction;
        }

    }
}