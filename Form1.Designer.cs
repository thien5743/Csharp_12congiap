namespace Csharp_12congiap
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
            this.btntim = new System.Windows.Forms.Button();
            this.lblnam = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtduong = new System.Windows.Forms.TextBox();
            this.txtamlich = new System.Windows.Forms.TextBox();
            this.lblketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntim
            // 
            this.btntim.AllowDrop = true;
            this.btntim.Location = new System.Drawing.Point(211, 322);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(87, 54);
            this.btntim.TabIndex = 0;
            this.btntim.Text = "tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Location = new System.Drawing.Point(145, 89);
            this.lblnam.Name = "lblnam";
            this.lblnam.Size = new System.Drawing.Size(27, 13);
            this.lblnam.TabIndex = 1;
            this.lblnam.Text = "năm";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(410, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 355);
            this.listBox1.TabIndex = 2;
            // 
            // txtduong
            // 
            this.txtduong.Location = new System.Drawing.Point(211, 89);
            this.txtduong.Name = "txtduong";
            this.txtduong.Size = new System.Drawing.Size(100, 20);
            this.txtduong.TabIndex = 3;
            // 
            // txtamlich
            // 
            this.txtamlich.Location = new System.Drawing.Point(211, 163);
            this.txtamlich.Name = "txtamlich";
            this.txtamlich.Size = new System.Drawing.Size(100, 20);
            this.txtamlich.TabIndex = 5;
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(145, 170);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(43, 13);
            this.lblketqua.TabIndex = 4;
            this.lblketqua.Text = "kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtamlich);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.txtduong);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblnam);
            this.Controls.Add(this.btntim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Label lblnam;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtduong;
        private System.Windows.Forms.TextBox txtamlich;
        private System.Windows.Forms.Label lblketqua;
    }
}

