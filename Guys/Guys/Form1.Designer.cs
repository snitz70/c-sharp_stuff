namespace Guys
{
    partial class Form1
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
            this.lblJoesCash = new System.Windows.Forms.Label();
            this.lblBobsCash = new System.Windows.Forms.Label();
            this.lblBankCash = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJoesCash
            // 
            this.lblJoesCash.AutoSize = true;
            this.lblJoesCash.Location = new System.Drawing.Point(13, 13);
            this.lblJoesCash.Name = "lblJoesCash";
            this.lblJoesCash.Size = new System.Drawing.Size(30, 13);
            this.lblJoesCash.TabIndex = 0;
            this.lblJoesCash.Text = "text1";
            // 
            // lblBobsCash
            // 
            this.lblBobsCash.AutoSize = true;
            this.lblBobsCash.Location = new System.Drawing.Point(13, 30);
            this.lblBobsCash.Name = "lblBobsCash";
            this.lblBobsCash.Size = new System.Drawing.Size(30, 13);
            this.lblBobsCash.TabIndex = 1;
            this.lblBobsCash.Text = "text2";
            // 
            // lblBankCash
            // 
            this.lblBankCash.AutoSize = true;
            this.lblBankCash.Location = new System.Drawing.Point(13, 47);
            this.lblBankCash.Name = "lblBankCash";
            this.lblBankCash.Size = new System.Drawing.Size(30, 13);
            this.lblBankCash.TabIndex = 2;
            this.lblBankCash.Text = "text3";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(13, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give $10 to\r\nJoe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(94, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive $5\r\nfrom Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 142);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBankCash);
            this.Controls.Add(this.lblBobsCash);
            this.Controls.Add(this.lblJoesCash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJoesCash;
        private System.Windows.Forms.Label lblBobsCash;
        private System.Windows.Forms.Label lblBankCash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

