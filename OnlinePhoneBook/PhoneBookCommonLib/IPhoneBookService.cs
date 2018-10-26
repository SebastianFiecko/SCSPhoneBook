using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hik.Communication.ScsServices.Service;

namespace PhoneBookCommonLib
{
    public interface IPhoneBookService
    {
        void AddPerson(PhoneBookRecord recordToAdd);
        bool DeletePerson(string name);
        PhoneBookRecord FindPerson(string name);
    }
}
