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
    public class AirportBUS
    {
        public DataTable GetForDisplay()
        {
            return AirportDAO.Instance.GetForDisplay();
        }

        public bool InsertAirport(AirportDTO dto)
        {
            return AirportDAO.Instance.InsertAirport(dto);
        }

        public bool UpdateAirport(AirportDTO dto)
        {
            return AirportDAO.Instance.UpdateAirport(dto);
        }
        public bool DeleteAirport(string maSanBay)
        {
            return AirportDAO.Instance.DeleteAirport(maSanBay);
        }
        public DataTable SearchByName(string nameAirport)
        {
            return AirportDAO.Instance.SearchByName(nameAirport);
        }

    }
}
