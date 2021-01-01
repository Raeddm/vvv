using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.Entites;
namespace InventoryBusniessLogic.SpiceificRepositiry
{
     public interface IpruductRepostry
    {
        void Insert(PruductEntity obj);
        List<PruductEntity> LoadAll();

        PruductEntity load(int id);
        void update(PruductEntity obj);


    }




}
