using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffDTO
    {
        private string idStaff;
        private string nameStaff;
        private string addressStaff;
        private string phoneStaff;
        private string userAcc;
        private int type;

        public StaffDTO()
        {
        }

        public StaffDTO(string idStaff, string nameStaff, string addressStaff, string phoneStaff, string userAcc, int type)
        {
            IdStaff = idStaff;
            NameStaff = nameStaff;
            AddressStaff = addressStaff;
            PhoneStaff = phoneStaff;
            UserAcc = userAcc;
            Type = type;
        }

        public string IdStaff { get => idStaff; set => idStaff = value; }
        public string NameStaff { get => nameStaff; set => nameStaff = value; }
        public string AddressStaff { get => addressStaff; set => addressStaff = value; }
        public string PhoneStaff { get => phoneStaff; set => phoneStaff = value; }
        public string UserAcc { get => userAcc; set => userAcc = value; }
        public int Type { get => type; set => type = value; }

        
    }
}
