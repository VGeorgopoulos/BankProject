namespace BankProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txt_Processes = new System.Windows.Forms.TextBox();
            this.lbl_UnSafe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(64, 246);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Press to Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Processes
            // 
            this.txt_Processes.Location = new System.Drawing.Point(12, 12);
            this.txt_Processes.Multiline = true;
            this.txt_Processes.Name = "txt_Processes";
            this.txt_Processes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Processes.Size = new System.Drawing.Size(195, 173);
            this.txt_Processes.TabIndex = 2;
            this.txt_Processes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_UnSafe
            // 
            this.lbl_UnSafe.AutoSize = true;
            this.lbl_UnSafe.Location = new System.Drawing.Point(13, 188);
            this.lbl_UnSafe.Name = "lbl_UnSafe";
            this.lbl_UnSafe.Size = new System.Drawing.Size(0, 13);
            this.lbl_UnSafe.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 281);
            this.Controls.Add(this.lbl_UnSafe);
            this.Controls.Add(this.txt_Processes);
            this.Controls.Add(this.btn_Exit);
            this.Name = "MainForm";
            this.Text = "Bank Assets and Safety";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_Processes;
        private System.Windows.Forms.Label lbl_UnSafe;

    }
}

