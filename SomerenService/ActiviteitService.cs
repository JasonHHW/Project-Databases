using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;
namespace SomerenService
{
    public class ActiviteitService
    {
        private ActiviteitDao activiteitDao;

        public ActiviteitService()
        {
            activiteitDao = new ActiviteitDao();
        }

        public List<Activiteit> GetActiviteiten() 
        {
            return activiteitDao.GetAllActiviteiten();
        }
    }
}
