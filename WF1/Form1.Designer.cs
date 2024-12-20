namespace WF1
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
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.kq = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.Nghiem1 = new System.Windows.Forms.Label();
            this.Nghiem2 = new System.Windows.Forms.Label();
            this.Nghiem3 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(177, 71);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 22);
            this.a.TabIndex = 1;
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(362, 132);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(75, 23);
            this.kq.TabIndex = 2;
            this.kq.Text = "Kết quả";
            this.kq.UseVisualStyleBackColor = true;
            this.kq.Click += new System.EventHandler(this.kq_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập c";
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(349, 71);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 22);
            this.b.TabIndex = 5;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(534, 71);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 22);
            this.c.TabIndex = 6;
            // 
            // Nghiem1
            // 
            this.Nghiem1.AutoSize = true;
            this.Nghiem1.Location = new System.Drawing.Point(346, 189);
            this.Nghiem1.Name = "Nghiem1";
            this.Nghiem1.Size = new System.Drawing.Size(0, 16);
            this.Nghiem1.TabIndex = 7;
            // 
            // Nghiem2
            // 
            this.Nghiem2.AutoSize = true;
            this.Nghiem2.Location = new System.Drawing.Point(346, 241);
            this.Nghiem2.Name = "Nghiem2";
            this.Nghiem2.Size = new System.Drawing.Size(0, 16);
            this.Nghiem2.TabIndex = 8;
            // 
            // Nghiem3
            // 
            this.Nghiem3.AutoSize = true;
            this.Nghiem3.Location = new System.Drawing.Point(346, 216);
            this.Nghiem3.Name = "Nghiem3";
            this.Nghiem3.Size = new System.Drawing.Size(0, 16);
            this.Nghiem3.TabIndex = 9;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(177, 132);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(547, 132);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 11;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 512);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Nghiem3);
            this.Controls.Add(this.Nghiem2);
            this.Controls.Add(this.Nghiem1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Button kq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Label Nghiem1;
        private System.Windows.Forms.Label Nghiem2;
        private System.Windows.Forms.Label Nghiem3;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Close;
    }
}

