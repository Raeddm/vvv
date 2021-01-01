using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccess.Entites;
using InventoryDataAccess.DTO;

namespace InventoryBusniessLogic.SpiceificRepositiry
{
 public   interface IcompanyRepostry
    {
        void Insert(CompanyEntity obj);
        List<CountryEntity> LoadCnt();
        List<Curenccy_Entity> LoadCur();

        //List<VMCompany> LoadData();

        CompanyEntity  load(int id);


    }




}
