using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.Entites;
using InventoryDataAccess.Genaric;

namespace InventoryBusniessLogic.SpiceificRepositiry
{
    public class OrderRepositry : IorderRepostry
    {
        public void Insert(OrderEntity obj)
        {
          

            Igenaric<OrderEntity> brandobj = new Genaric<OrderEntity>();
            brandobj.Insert(obj);


        }

        public List<OrderEntity> LoadAll()
        {


            Igenaric<OrderEntity> Catobj = new Genaric<OrderEntity>();
            return Catobj.LoadAll();


        }


    }
}
