using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace APlanner_MDP.Data
{
    public interface sql_lite
    {
        SQLiteConnection GetConnection();
    }
}
