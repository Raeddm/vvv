using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.Entites;
using InventoryDataAccess.Context;
using InventoryDataAccess.Genaric;
namespace InventoryBusniessLogic.SpiceificRepositiry
{
  public  class BrandRepsoistry :IBrandRepositiry
    {
        public void Insert(bandEntity obj)
        {
            //inventoryContext context = new inventoryContext();
            //context.Brands.Add(obj);
            //context.SaveChanges();

            Igenaric<bandEntity> brandobj = new Genaric<bandEntity>();
            brandobj.Insert(obj);


        }

        public List<bandEntity>  LoadAll()
        {
           

            Igenaric<bandEntity> brandobj = new Genaric<bandEntity>();
           return brandobj.LoadAll();


        }



        public void delete(int id)
        {
            Igenaric<bandEntity> brandObj = new Genaric<bandEntity>();
            brandObj.delete(id);
        }

        public bandEntity load(int ID)
        {
            Igenaric<bandEntity> brandObj = new Genaric<bandEntity>();
            return brandObj.load(ID);
        }

        public void update(bandEntity obj)
        {
            Igenaric<bandEntity> brandObj = new Genaric<bandEntity>();
             brandObj.update(obj);
        }
    }
}
