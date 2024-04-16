using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PlaneBUS
    {
        public DataTable GetForDisplay()
        { 
            return PlaneDAO.Instance.GetForDisplay();
        }
        public bool DeletePlane(string idPlane)
        {
            return PlaneDAO.Instance.DeletePlane(idPlane);
        }

        public bool InsertPlane(PlaneDTO dto)
        {
            return PlaneDAO.Instance.InsertPlane(dto);
        }

        public bool UpdatePlane(PlaneDTO dto)
        {
            return PlaneDAO.Instance.UpdatePlane(dto);
        }

        public DataTable SearchByName(string namePlane)
        {
            return PlaneDAO.Instance.SearchByName(namePlane);
        }
    }
}
