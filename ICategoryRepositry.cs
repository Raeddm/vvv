using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.Entites;
namespace InventoryBusniessLogic.SpiceificRepositiry
{
    public interface ICategoryRepositry
    {
        void Insert(catogeryEntity obj);
        List<catogeryEntity> LoadAll();
        void delete(int id);
        catogeryEntity load(int ID);

        void update(catogeryEntity obj);
    }
}
