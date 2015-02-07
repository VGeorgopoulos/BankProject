using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class CheckSafety
    {
        public Entity entity { get; set; }

        public CheckSafety(Entity entity)
        {
            this.entity = entity;
        }

        public void Check()
        {
            for (int i = 0; i < this.entity.Banks.Count; i++)
            {

                Bank bank = entity.Banks[i];

                if (bank.Balance < entity.LowerBalanceLimit)
                {
                    bank.IsSafe = false;

                    for (int j = 0; j < this.entity.Banks.Count; j++)
                    {
                        Bank innerBank = this.entity.Banks[j];

                        for (int y = 0; y < innerBank.Transactions.Count; y++)
                        {
                            LoanTransaction t = innerBank.Transactions[y];
                            if (t.LoanerId == bank.BankId)
                                innerBank.Balance -= t.BorrowedMoney;
                        }
                    }
                }
            }

            for (int i = 0; i < this.entity.Banks.Count; i++)
            {
                if (this.entity.Banks[i].Balance < this.entity.LowerBalanceLimit)
                {
                    this.entity.Banks[i].IsSafe = false;
                }
            }
        }

        public void BalanceSum()
        {
            for (int i = 0; i < this.entity.Banks.Count; i++)
            {
                Bank bank = entity.Banks[i];
                bank.Balance = bank.Transactions.Aggregate(bank.Balance, (a, t) => a += t.BorrowedMoney);
            }
        }
    }
}
