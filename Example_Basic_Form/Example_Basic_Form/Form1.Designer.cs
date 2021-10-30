
namespace Example_Basic_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.labKetqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ho Ten";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(120, 28);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(141, 23);
            this.txtHoten.TabIndex = 1;
            // 
            // txtTuoi
            // 
            this.txtTuoi.AutoSize = true;
            this.txtTuoi.Location = new System.Drawing.Point(34, 67);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(30, 15);
            this.txtTuoi.TabIndex = 0;
            this.txtTuoi.Text = "Tuoi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 23);
            this.textBox2.TabIndex = 1;
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Location = new System.Drawing.Point(105, 111);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacnhan.TabIndex = 2;
            this.btnXacnhan.Text = "Xac Nhan";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // labKetqua
            // 
            this.labKetqua.AutoSize = true;
            this.labKetqua.Location = new System.Drawing.Point(34, 164);
            this.labKetqua.Name = "labKetqua";
            this.labKetqua.Size = new System.Drawing.Size(38, 15);
            this.labKetqua.TabIndex = 3;
            this.labKetqua.Text = "label3";
            this.labKetqua.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.labKetqua);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label txtTuoi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Label labKetqua;
    }
}

