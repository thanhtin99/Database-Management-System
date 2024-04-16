using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        private string idCus;
        private string nameCus;
        private string identityCus;
        private string phoneCus;

        public CustomerDTO()
        {
        }

        public CustomerDTO(string idCus, string nameCus, string identityCus, string phoneCus)
        {
            IdCus = idCus;
            NameCus = nameCus;
            IdentityCus = identityCus;
            PhoneCus = phoneCus;
        }

        public string IdCus { get => idCus; set => idCus = value; }
        public string NameCus { get => nameCus; set => nameCus = value; }
        public string IdentityCus { get => identityCus; set => identityCus = value; }
        public string PhoneCus { get => phoneCus; set => phoneCus = value; }
    }
}
