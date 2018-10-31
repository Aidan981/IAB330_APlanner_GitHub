using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using APlanner_MDP.Models;
using Xamarin.Forms;


namespace APlanner_MDP.Data
{
   public class UserDatabase
    {
        static object save = new object();

        SQLiteConnection database;


        public UserDatabase()
        {
            database = DependencyService.Get<sql_lite>().GetConnection();
            database.CreateTable<user>();

        }
        user GetUser()
        {
            lock (save)
            {
                if (database.Table<user>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<user>().First();
                }
            }
        }
        public int saveUser(user user)
        {
            lock (save)
            {
                if(user.Id != 0)
                {
                    database.Update(user);
                    return user.Id;
                }
                else
                {
                    return database.Insert(user);


                }
            }

            
        }
        public int DeleteUser(int id)
        {
            lock (save){
                return database.Delete<user>(id);
            }
        }
    }
}
