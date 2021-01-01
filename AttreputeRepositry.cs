using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.DTO;
using InventoryDataAccess.Context;
using InventoryDataAccess.Entites;
using InventoryDataAccess.Genaric;

namespace InventoryBusniessLogic.SpiceificRepositiry
{
    public class AttreputeRepositry : IAttripueteReposetry
    {

        public List<VmAttriebute> LoadData()
        {
            inventoryContext context = new inventoryContext();
            List<VmAttriebute> li = new List<VmAttriebute>();
            attrebuteEntity att = new attrebuteEntity();


            var x = from D in context.Attrebutes
                    join E in context.AttrebuteValues
                    on D.ID equals E.attrebute_ID into G
                    select new
                    { D.ID, Attrebute_name = D.Attrebute_name, Status = D.Status, count = G.Count() };



            foreach (var item in x)
            {
                VmAttriebute obj = new VmAttriebute();
                obj.attVM = new attrebuteEntity();
                obj.attVM.ID = item.ID;
                obj.attVM.Attrebute_name = item.Attrebute_name;
                obj.attVM.Status = item.Status;
                obj.count = item.count;

                li.Add(obj);

            }
            return li;
        }

        public void Insert(attrebuteEntity obj)
        {

            Igenaric<attrebuteEntity> Catobj = new Genaric<attrebuteEntity>();
            Catobj.Insert(obj);

        }


        public void delete(int id)
        {
            Igenaric<attrebuteEntity> CatObj = new Genaric<attrebuteEntity>();
            CatObj.delete(id);
        }


        public attrebuteEntity load(int ID)
        {
            Igenaric<attrebuteEntity> CatObj = new Genaric<attrebuteEntity>();
            return CatObj.load(ID);
        }

        public void update(attrebuteEntity obj)
        {
            Igenaric<attrebuteEntity> CatObj = new Genaric<attrebuteEntity>();
            CatObj.update(obj);
        }


        public List<attrebuteValueEntity> LoadAllv (int Id)
        {
            inventoryContext context = new inventoryContext();
            var z = from t1 in context.Attrebutes
                    join t2 in context.AttrebuteValues
                    on t1.ID equals t2.attrebute_ID
                    where t1.ID == Id
                    select new { t2.Name, t2.ID };

            List<attrebuteValueEntity> li = new List<attrebuteValueEntity>();
            foreach ( var item in  z )
            {
                attrebuteValueEntity obj = new attrebuteValueEntity();
                obj.ID = item.ID;
                obj.Name = item.Name;
                li.Add(obj);

            }
            return li;

        }


    }
}
