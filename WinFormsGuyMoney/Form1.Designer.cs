namespace WinFormsGuyMoney
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Give = new System.Windows.Forms.Button();
            this.Receive = new System.Windows.Forms.Button();
            this.JoesCash = new System.Windows.Forms.Label();
            this.BobsCash = new System.Windows.Forms.Label();
            this.BanksCash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Give
            // 
            this.Give.Location = new System.Drawing.Point(141, 258);
            this.Give.Name = "Give";
            this.Give.Size = new System.Drawing.Size(147, 29);
            this.Give.TabIndex = 3;
            this.Give.Text = "Give $10 to Joe";
            this.Give.UseVisualStyleBackColor = true;
            this.Give.Click += new System.EventHandler(this.Give_Click);
            // 
            // Receive
            // 
            this.Receive.Location = new System.Drawing.Point(332, 258);
            this.Receive.Name = "Receive";
            this.Receive.Size = new System.Drawing.Size(165, 29);
            this.Receive.TabIndex = 4;
            this.Receive.Text = "Receive $5 from Bob";
            this.Receive.UseVisualStyleBackColor = true;
            this.Receive.Click += new System.EventHandler(this.Receive_Click);
            // 
            // JoesCash
            // 
            this.JoesCash.AutoSize = true;
            this.JoesCash.Location = new System.Drawing.Point(278, 52);
            this.JoesCash.Name = "JoesCash";
            this.JoesCash.Size = new System.Drawing.Size(50, 20);
            this.JoesCash.TabIndex = 5;
            this.JoesCash.Text = "label4";
            // 
            // BobsCash
            // 
            this.BobsCash.AutoSize = true;
            this.BobsCash.Location = new System.Drawing.Point(278, 108);
            this.BobsCash.Name = "BobsCash";
            this.BobsCash.Size = new System.Drawing.Size(50, 20);
            this.BobsCash.TabIndex = 6;
            this.BobsCash.Text = "label5";
            // 
            // BanksCash
            // 
            this.BanksCash.AutoSize = true;
            this.BanksCash.Location = new System.Drawing.Point(278, 170);
            this.BanksCash.Name = "BanksCash";
            this.BanksCash.Size = new System.Drawing.Size(50, 20);
            this.BanksCash.TabIndex = 7;
            this.BanksCash.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BanksCash);
            this.Controls.Add(this.BobsCash);
            this.Controls.Add(this.JoesCash);
            this.Controls.Add(this.Receive);
            this.Controls.Add(this.Give);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Give;
        private Button Receive;
        private Label JoesCash;
        private Label BobsCash;
        private Label BanksCash;
    }
}