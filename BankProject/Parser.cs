using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Parser
    {
        public string FilePath { get; set; }
        public FileReader Streamer { get; private set; }


        public Parser(string Filepath)
        {
            this.FilePath = Filepath;
            this.Streamer = new FileReader(this.FilePath);
        }
        public Entity Parse()
        {
            
            List<string> data = this.Streamer.Read();

            string[] firstLine = data[0].Split(' ');
            Entity entity = new Entity(Convert.ToInt32(firstLine[0]), Convert.ToDecimal(firstLine[1]));

            string[] line;
            int loansCounter = 0;
            for (int i = 1; i < data.Count; i++)
            {
                line = data[i].Split(' ');

                loansCounter = Convert.ToInt32(line[1]);
                int innerCounter = 1;
                Bank newBank = new Bank(i - 1, Convert.ToDecimal(line[0]));
                for (int j = 0; j < loansCounter; j++)
                {
                    newBank.AddLoan(Convert.ToInt32(line[++innerCounter]), Convert.ToDecimal(line[++innerCounter]));
                }
                entity.AddBank(newBank);
            }

            return entity;
        }
    }
}
