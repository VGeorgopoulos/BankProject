using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankProject
{
    public class FileReader
    {
        public string FilePath { get; private set; }
        public List<string> data { get; private set; }

        private FileReader()
        {
            this.data = new List<string>();
        }

        public FileReader(string FilePath)
            : this()
        {
            this.FilePath = FilePath;
        }

        public List<string> Read()
        {
            using (StreamReader sr = new StreamReader(this.FilePath))
            {
                while (!sr.EndOfStream)
                {
                    this.data.Add(sr.ReadLine());
                }
            }
            return this.data;
        }
    }
}
