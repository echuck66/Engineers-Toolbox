using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineersToolbox.Data
{
    public class ToolboxDatabase
    {
        SQLiteAsyncConnection Database;

        public ToolboxDatabase()
        {
        }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            //var result = await Database.CreateTableAsync<TodoItem>();
        }
    }
}
