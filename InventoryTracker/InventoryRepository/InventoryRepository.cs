using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDB;

namespace InventoryRepository
{
    public class InventoryModel
    {
        public int ID { get; set; }
        public int ItemN { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int QntyOnHand { get; set; }
        public double SelfCost { get; set; }
        public double TotalValue { get; set; }
    }
    
    public class InventoryRepository
    {
        public InventoryModel Add(InventoryModel inventoryModel)
        {
            var inventoryDB = ToDbModel(inventoryModel);
            DatabaseManager.Instance.Items.Add(inventoryDB);
            DatabaseManager.Instance.SaveChanges();

            inventoryModel = new InventoryModel
            {

                ID = inventoryDB.ID,
                ItemN = inventoryDB.ItemN,
                Description = inventoryDB.Description,
                Price = inventoryDB.Price,
                QntyOnHand = inventoryDB.QntyOnHand,
                SelfCost = inventoryDB.SelfCost,
                TotalValue = inventoryDB.TotalValue,
                
            };
            return inventoryModel;
        }

        public List<InventoryModel> GetAll()
        {
            // Use .Select() to map the database InventoryTracker to InventoryModel
            var items = DatabaseManager.Instance.Items
              .Select(t => new InventoryModel
              {
                  ID = t.ID,
                  ItemN = t.ItemN,
                  Description = t.Description,
                  Price = t.Price,
                  QntyOnHand = t.QntyOnHand,
                  SelfCost = t.SelfCost,
                  TotalValue = t.TotalValue,
                  
              }).ToList();

            return items;
        }
        
        public bool Update(InventoryModel inventoryModel)
        {
            var original = DatabaseManager.Instance.Items.Find(inventoryModel.ID);

            if (original != null)
            {
                DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(ToDbModel(inventoryModel));
                DatabaseManager.Instance.SaveChanges();
            }

            return false;
        }
              
        public bool Remove(int itemId)
        {
            var items = DatabaseManager.Instance.Items
                                .Where(t => t.ItemN == itemId);

            if (items.Count() == 0)
            {
                return false;
            }

            DatabaseManager.Instance.Items.Remove(items.FirstOrDefault());
            DatabaseManager.Instance.SaveChanges();

            return true;
        }
   
        private Item ToDbModel(InventoryModel inventoryModel)
        {
            var inventoryDB = new Item
            {
                ID = inventoryModel.ID,
                ItemN = inventoryModel.ItemN,
                Description = inventoryModel.Description,
                Price = inventoryModel.Price,
                QntyOnHand = inventoryModel.QntyOnHand,
                SelfCost = inventoryModel.SelfCost,
                TotalValue= inventoryModel.TotalValue,
                
            };
        
            return inventoryDB;
        }
           
    }
}
