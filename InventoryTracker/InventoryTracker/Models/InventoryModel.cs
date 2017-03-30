using InventoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTracker.Models
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

        internal InventoryModel Clone()
        {
            return (InventoryModel)MemberwiseClone();
        }
        public InventoryRepository.InventoryModel ToRepositoryModel()
        {
            var repositoryModel = new InventoryRepository.InventoryModel
            {
                ID = ID,
                ItemN = ItemN,
                Description = Description,
                Price = Price,
                QntyOnHand = QntyOnHand,
                SelfCost = SelfCost,
                TotalValue = TotalValue
            };

            return repositoryModel;
        }
        public static InventoryModel ToModel(InventoryRepository.InventoryModel repositoryModel)
        {
            var inventoryModel = new InventoryModel
            {
                ID = repositoryModel.ID,
                ItemN = repositoryModel.ItemN,
                Description = repositoryModel.Description,
                Price = repositoryModel.Price,
                QntyOnHand = repositoryModel.QntyOnHand,
                SelfCost = repositoryModel.SelfCost,
                TotalValue = repositoryModel.TotalValue
            };
            return inventoryModel;
        }
    }
}
