using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Entity
    {
        public int NumberOfBanks { get; set; }
        public decimal LowerBalanceLimit { get; set; }
        public List<Bank> Banks { get; set; }
        public Entity()
        {
            this.Banks = new List<Bank>();
        }
        public Entity(int NumberOfBanks, decimal LowerBalanceLimit)
            : this()
        {
            this.NumberOfBanks = NumberOfBanks;
            this.LowerBalanceLimit = LowerBalanceLimit;
        }
        public void AddBank(Bank bank)
        {
            this.Banks.Add(bank);
        }
        public void AddBank(int BankId, decimal Balance)
        {
            this.Banks.Add(new Bank(BankId, Balance));
        }
    }
}
