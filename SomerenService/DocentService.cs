using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
namespace SomerenService
{
    public class DocentService
    {
        private DocentDao docentDao;

        public DocentService()
        {
            docentDao = new DocentDao();
        }

        public List<Docent> GetDocenten()
        {
            return docentDao.GetAllDocents();
        }
    }
}
