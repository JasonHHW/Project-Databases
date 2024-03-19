using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
namespace SomerenService
{
    public class KamerService
    {
        private KamerDao kamerDao;

        public KamerService()
        {
            kamerDao = new KamerDao();
        }
        
        public List<Kamer> GetKamers()
        {
            return kamerDao.GetAllKamers();
        }
    }
}
