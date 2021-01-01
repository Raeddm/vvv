using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.Entites;

using InventoryDataAccess.Genaric;
namespace InventoryBusniessLogic.SpiceificRepositiry
{
   public  class StoreRepositry:IStoreRepositry
    {
        public void Insert(storeEntity obj)
        {

            Igenaric<storeEntity> Catobj = new Genaric<storeEntity>();
            Catobj.Insert(obj);

        }
        public List<storeEntity> LoadAll()
        {


            Igenaric<storeEntity> Catobj = new Genaric<storeEntity>();
            return Catobj.LoadAll();


        }

        public void delete(int id)
        {
            Igenaric<storeEntity> CatObj = new Genaric<storeEntity>();
            CatObj.delete(id);
        }


        public storeEntity load(int ID)
        {
            Igenaric<storeEntity> CatObj = new Genaric<storeEntity>();
            return CatObj.load(ID);
        }

        public void update(storeEntity obj)
        {
            Igenaric<storeEntity> CatObj = new Genaric<storeEntity>();
            CatObj.update(obj);
        }

    }
}
