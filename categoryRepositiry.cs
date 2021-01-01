using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.Entites;
using InventoryDataAccess.Genaric;
namespace InventoryBusniessLogic.SpiceificRepositiry
{
  public  class categoryRepositiry : ICategoryRepositry
    {
        public void Insert(catogeryEntity obj)
        {
        
            Igenaric<catogeryEntity> Catobj = new Genaric<catogeryEntity>();
            Catobj.Insert(obj);

        }
        public List<catogeryEntity> LoadAll()
        {


            Igenaric<catogeryEntity> Catobj = new Genaric<catogeryEntity>();
            return Catobj.LoadAll();


        }

        public void delete(int id)
        {
            Igenaric<catogeryEntity> CatObj = new Genaric<catogeryEntity>();
            CatObj.delete(id);
        }


        public catogeryEntity load(int ID)
        {
            Igenaric<catogeryEntity> CatObj = new Genaric<catogeryEntity>();
            return CatObj.load(ID);
        }

        public void update(catogeryEntity obj)
        {
            Igenaric<catogeryEntity> CatObj = new Genaric<catogeryEntity>();
            CatObj.update(obj);
        }

    }
}
