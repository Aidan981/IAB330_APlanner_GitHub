using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;
using APlanner_MDP.Data;
using APlanner_MDP.Droid.Data;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;

[assembly: Dependency( typeof(SQLite_Android))]

namespace APlanner_MDP.Droid.Data
{
    public class SQLite_Android
    {
        public SQLite_Android(){}
        public SQLite.SQLiteConnection GetConnection()
    {
        var sqliteFileName = "database.db3";
        string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        var path = Path.Combine(documentsPath, sqliteFileName);
        var connection = new SQLite.SQLiteConnection(path);

        return connection;
    }
        

    }
}