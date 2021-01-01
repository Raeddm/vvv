using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.DTO;
using InventoryDataAccess.Entites;
namespace InventoryBusniessLogic.SpiceificRepositiry
{
   public interface IAttripueteReposetry
    {
        List<VmAttriebute> LoadData();

        void Insert(attrebuteEntity obj);


        void delete(int id);

        attrebuteEntity load(int ID);
        void update(attrebuteEntity obj);

       List<attrebuteValueEntity> LoadAllv(int Id);
    }
}
