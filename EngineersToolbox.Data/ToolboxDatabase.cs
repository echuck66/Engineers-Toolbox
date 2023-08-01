using EngineersToolbox.Models.Entities;
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

            Database = new SQLiteAsyncConnection(DBConstants.DatabasePath, DBConstants.Flags);

            //var createDefaultUnitsTable = await Database.CreateTableAsync<ConverterDefaultUnits>();
        }
    }
}
