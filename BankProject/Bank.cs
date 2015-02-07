using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Bank
    {
        public int BankId { get; set; }
        public decimal Balance { get; set; }
        public bool IsSafe { get; set; }
        public List<LoanTransaction> Transactions { get; set; }

        public Bank()
        {
            this.Transactions = new List<LoanTransaction>();
        }
        public Bank(int BankId, decimal Balance)
            : this()
        {
            this.IsSafe = true;
            this.BankId = BankId;
            this.Balance = Balance;
        }
        public void AddLoan(LoanTransaction transaction)
        {
            this.Transactions.Add(transaction);
        }
        public void AddLoan(int LenderId, decimal BorrowedMoney)
        {
            this.Transactions.Add(new LoanTransaction(LenderId, BorrowedMoney));
        }
    }
}
