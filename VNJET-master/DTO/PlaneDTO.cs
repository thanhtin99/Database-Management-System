using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PlaneDTO
    {
        private string idPlane;
        private string namePlane;
        private int seatsPlane;

        public PlaneDTO()
        {
        }

        public PlaneDTO(string idPlane, string namePlane, int seatsPlane)
        {
            IdPlane = idPlane;
            NamePlane = namePlane;
            SeatsPlane = seatsPlane;
        }

        public string IdPlane { get => idPlane; set => idPlane = value; }
        public string NamePlane { get => namePlane; set => namePlane = value; }
        public int SeatsPlane { get => seatsPlane; set => seatsPlane = value; }
    }
}
