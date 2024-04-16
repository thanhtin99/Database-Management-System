using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AirportDAO
    {
        private static AirportDAO instance;
        public static AirportDAO Instance
        {
            get { if (instance == null) instance = new AirportDAO(); return AirportDAO.instance; }
            private set { AirportDAO.instance = value; }
        }

        private AirportDAO()
        { }

        public DataTable GetForDisplay()
        {
            string query = "SELECT * FROM dbo.Airports";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public bool InsertAirport(AirportDTO dto)
        {
            try
            {
                string query = String.Format("INSERT dbo.Airports(idAirport, nameAirport, cityAirport) VALUES ((SELECT dbo.UF_CreateIdAirport()), N'{0}', N'{1}')", dto.NameAirport, dto.CityAirport);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateAirport(AirportDTO dto)
        {
            try
            {
                string query = String.Format("UPDATE dbo.Airports SET nameAirport = N'{0}', cityAirport = N'{1}' WHERE idAirport = '{2}'", dto.NameAirport, dto.CityAirport, dto.IdAirport);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteAirport(string maSanBay)
        {
            try
            {
                string query = String.Format("DELETE dbo.Airports WHERE idAirport = '{0}'", maSanBay);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public DataTable SearchByName(string nameAirport)
        {
            string query = String.Format("SELECT * FROM dbo.Airports WHERE nameAirport LIKE '%'+N'{0}'+'%' ORDER BY idAirport", nameAirport);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
