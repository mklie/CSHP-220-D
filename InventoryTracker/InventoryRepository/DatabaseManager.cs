using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDB;

namespace InventoryRepository
{
    public class DatabaseManager
    {
        private static readonly InventoryTrackerEntities entities;

        // Initialize and open the database connection
        static DatabaseManager()
        {
            entities = new InventoryTrackerEntities();
            entities.Database.Connection.Open();
        }
        // Provide an accessor to the database
        public static InventoryTrackerEntities Instance
        {
            get
            {
                return entities;
            }
        }

    }
}
