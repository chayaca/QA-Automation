using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class CreditCard
    {
        public CreditCard(long cardNum, string validityMonth, string validityYear, string cvv, long id)
        {
            this.CardNum = cardNum;
            this.ValidityMonth = validityMonth;
            this.ValidityYear = validityYear;
            this.Cvv = cvv;
            this.Id = id;
        }

        public long CardNum { get; set; }
        public string ValidityMonth { get; set; }
        public string ValidityYear { get; set; }
        public string Cvv { get; set; }
        public long Id { get; set; }
    }
}
