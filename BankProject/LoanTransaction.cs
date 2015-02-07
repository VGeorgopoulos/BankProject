using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class LoanTransaction
    {
        public int LoanerId { get; set; }
        public decimal BorrowedMoney { get; set; }


        public LoanTransaction(int LenderId ,decimal BorrowedMoney )
        {
            this.LoanerId = LenderId;
            this.BorrowedMoney = BorrowedMoney;
        }

    }
}
