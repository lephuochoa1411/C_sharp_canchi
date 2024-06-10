namespace C_sharp_canchi
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
            this.btn4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnam1 = new System.Windows.Forms.TextBox();
            this.txtnam2 = new System.Windows.Forms.TextBox();
            this.lbsdanhsach3 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(356, 241);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "Tính";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kết Qủa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm";
            // 
            // txtnam1
            // 
            this.txtnam1.Location = new System.Drawing.Point(50, 221);
            this.txtnam1.Multiline = true;
            this.txtnam1.Name = "txtnam1";
            this.txtnam1.Size = new System.Drawing.Size(100, 43);
            this.txtnam1.TabIndex = 2;
            // 
            // txtnam2
            // 
            this.txtnam2.Location = new System.Drawing.Point(220, 221);
            this.txtnam2.Multiline = true;
            this.txtnam2.Name = "txtnam2";
            this.txtnam2.Size = new System.Drawing.Size(100, 43);
            this.txtnam2.TabIndex = 2;
            // 
            // lbsdanhsach3
            // 
            this.lbsdanhsach3.FormattingEnabled = true;
            this.lbsdanhsach3.Location = new System.Drawing.Point(50, 287);
            this.lbsdanhsach3.Name = "lbsdanhsach3";
            this.lbsdanhsach3.Size = new System.Drawing.Size(270, 160);
            this.lbsdanhsach3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 55);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tính Can Chi  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbsdanhsach3);
            this.Controls.Add(this.txtnam2);
            this.Controls.Add(this.txtnam1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnam1;
        private System.Windows.Forms.TextBox txtnam2;
        private System.Windows.Forms.ListBox lbsdanhsach3;
        private System.Windows.Forms.Label label3;
    }
}

