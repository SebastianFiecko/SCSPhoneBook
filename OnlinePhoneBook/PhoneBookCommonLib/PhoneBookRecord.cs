using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookCommonLib
{
    [Serializable]
    public class PhoneBookRecord
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime CreationDate { get; set; }

        public PhoneBookRecord() => CreationDate = DateTime.Now;

        public override string ToString()
        {
            return string.Format($"Name={Name}, Phone={Phone}");
        }
    }
}
