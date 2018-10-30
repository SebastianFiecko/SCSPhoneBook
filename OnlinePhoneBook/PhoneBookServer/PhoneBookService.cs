using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hik.Communication.ScsServices.Service;
using PhoneBookCommonLib;

namespace PhoneBookServer
{
    class PhoneBookService : ScsService, IPhoneBookService
    {
        private readonly SortedList<string, PhoneBookRecord> _records;
        public PhoneBookService() => _records = new SortedList<string, PhoneBookRecord>();

        public void AddPerson(PhoneBookRecord recordToAdd)
        {
            if (recordToAdd == null)
                throw new ArgumentNullException("recordToAdd");
            _records[recordToAdd.Name] = recordToAdd;
        }

        public bool DeletePerson(string name)
        {
            if (!_records.ContainsKey(name))
                return false;

            _records.Remove(name);
            return true;
        }



        static void Main(string[] args)
        {
        }
    }
}
