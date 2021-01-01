using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.Entites;
using InventoryDataAccess.Genaric;
using InventoryDataAccess.Context;
namespace InventoryBusniessLogic.SpiceificRepositiry
{
     public class PrudactRepositry: IpruductRepostry
    {

        public void Insert(PruductEntity obj)
        {

            Igenaric<PruductEntity> Catobj = new Genaric<PruductEntity>();
            Catobj.Insert(obj);

        }

        public List<PruductEntity> LoadAll()
        {

            Igenaric<PruductEntity> prodObj = new Genaric<PruductEntity>();
            return prodObj.LoadAll();
        }


        public PruductEntity  load(int id)
        {
            Igenaric<PruductEntity> prodObj = new Genaric<PruductEntity>();
            return prodObj.load(id);
        }


        public void update(PruductEntity obj)
        {
            Igenaric<PruductEntity> prodObj = new Genaric<PruductEntity>();
            prodObj.update(obj);
        }

    }
}
