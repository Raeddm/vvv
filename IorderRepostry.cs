using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.DTO;
using InventoryDataAccess.Entites;

namespace InventoryBusniessLogic.SpiceificRepositiry
{
    public interface IorderRepostry
    {

        void Insert(OrderEntity obj);

        List<OrderEntity> LoadAll();

    }
}
