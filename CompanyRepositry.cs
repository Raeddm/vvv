using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.Entites;
using InventoryDataAccess.Genaric;
using InventoryDataAccess.DTO;
using InventoryDataAccess.Context;

namespace InventoryBusniessLogic.SpiceificRepositiry
{
    public class CompanyRepositry : IcompanyRepostry 
    {

        public void Insert(CompanyEntity obj)
        {

            Igenaric<CompanyEntity> Catobj = new Genaric<CompanyEntity>();
            Catobj.Insert(obj);

        }


        //public List<VMCompany> LoadData()
        //{


        //    inventoryContext context = new inventoryContext();
        //    List<VMCompany> li = new List<VMCompany>();

        //    var Count = from d in context.Countres
        //                from g in context.Curency
        //                select new
        //                { ID =  d.ID, Country_name= d.Country_name, IDx = g.ID, CrName = g.Curenccy_name };

        //    foreach (var item in Count )

        //    {
        //        VMCompany obj = new VMCompany();
        //        obj.cntVM.ID = item.ID;
        //        obj.cntVM.Country_name = item.Country_name;
        //        obj.curVM.ID = item.IDx;
        //        obj.curVM.Curenccy_name = item.CrName;

        //        li.Add(obj);
        //    }


        //    return li;






        //}






        public List<CountryEntity> LoadCnt()
        {


            Igenaric<CountryEntity> brandobj = new Genaric<CountryEntity>();
            return brandobj.LoadAll();


        }

        public List<Curenccy_Entity> LoadCur()
        {


            Igenaric<Curenccy_Entity> objbrad = new Genaric<Curenccy_Entity>();
            return objbrad.LoadAll();


        }


        public CompanyEntity load(int id)
        {
            Igenaric<CompanyEntity> prodObj = new Genaric<CompanyEntity>();
            return prodObj.load(id);
        }

    }
}
