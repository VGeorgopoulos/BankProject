using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject
{
    public partial class MainForm : Form
    {
        public OpenFileDialog Dialog { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Dialog = new OpenFileDialog();
            Dialog.ShowDialog();
            ok();
        }

        public void ok()
        {

            
            Parser p = new Parser(Dialog.FileName);

            Entity entity = p.Parse();
            CheckSafety checkSafety = new CheckSafety(entity);
            checkSafety.BalanceSum();
            

            this.txt_Processes.AppendText("Before the Process\r\n");
            foreach (var query in entity.Banks)
            {

               // this.textBox1.AppendText(query.BankId + " " + query.Balance + "\r\n");
                this.txt_Processes.AppendText(String.Format("Bank{0} - Balance: {1}",query.BankId, query.Balance + "\r\n"));
            }
            
            checkSafety.Check();

            this.txt_Processes.AppendText("\r\nAfter the Process\r\n");
            foreach (var query in checkSafety.entity.Banks)
            {
                this.txt_Processes.AppendText(String.Format("Bank{0} - Balance: {1}", query.BankId, query.Balance + "\r\n"));
            }


            this.lbl_UnSafe.Text = "Unsafe banks are ";
            foreach (var query in checkSafety.entity.Banks.Where(bank => bank.IsSafe == false))
            {
                this.lbl_UnSafe.Text += String.Format("Bank{0}, ",query.BankId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
