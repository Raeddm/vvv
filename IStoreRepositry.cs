using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.Entites;
namespace InventoryBusniessLogic.SpiceificRepositiry
{
  public  interface IStoreRepositry
    {
        void Insert(storeEntity obj);
        List<storeEntity> LoadAll();
        void delete(int id);
        storeEntity load(int ID);

        void update(storeEntity obj);




    }
}
