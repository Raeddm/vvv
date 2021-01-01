using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.Entites;

namespace InventoryBusniessLogic.SpiceificRepositiry
{
   public interface IBrandRepositiry
    {
         void Insert(bandEntity obj );
        List<bandEntity> LoadAll();

        void delete(int id);

        bandEntity load(int ID);
        void update(bandEntity obj);

    }
}
