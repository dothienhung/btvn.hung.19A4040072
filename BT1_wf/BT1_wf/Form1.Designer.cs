namespace BT1_wf
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
            this.components = new System.ComponentModel.Container();
            this.inputA = new System.Windows.Forms.Label();
            this.inputB = new System.Windows.Forms.Label();
            this.IpA = new System.Windows.Forms.TextBox();
            this.IpB = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Button();
            this.repeat = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.kq1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // inputA
            // 
            this.inputA.AutoSize = true;
            this.inputA.Location = new System.Drawing.Point(71, 90);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(56, 13);
            this.inputA.TabIndex = 0;
            this.inputA.Text = "Nhập số a";
            // 
            // inputB
            // 
            this.inputB.AutoSize = true;
            this.inputB.Location = new System.Drawing.Point(71, 134);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(56, 13);
            this.inputB.TabIndex = 1;
            this.inputB.Text = "Nhập số b";
            // 
            // IpA
            // 
            this.IpA.Location = new System.Drawing.Point(130, 87);
            this.IpA.Name = "IpA";
            this.IpA.Size = new System.Drawing.Size(156, 20);
            this.IpA.TabIndex = 2;
            this.toolTip1.SetToolTip(this.IpA, "Nhập số nguyên");
            // 
            // IpB
            // 
            this.IpB.Location = new System.Drawing.Point(130, 134);
            this.IpB.Name = "IpB";
            this.IpB.Size = new System.Drawing.Size(156, 20);
            this.IpB.TabIndex = 3;
            this.toolTip2.SetToolTip(this.IpB, "Nhập số b");
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(74, 213);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(75, 23);
            this.Sum.TabIndex = 4;
            this.Sum.Text = "Tổng ";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // repeat
            // 
            this.repeat.Location = new System.Drawing.Point(173, 213);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(75, 23);
            this.repeat.TabIndex = 5;
            this.repeat.Text = "Làm lại";
            this.repeat.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(284, 213);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(130, 178);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(156, 20);
            this.txtkq.TabIndex = 7;
            this.toolTip3.SetToolTip(this.txtkq, "Tổng từ a đến b là");
            // 
            // kq1
            // 
            this.kq1.AutoSize = true;
            this.kq1.Location = new System.Drawing.Point(68, 181);
            this.kq1.Name = "kq1";
            this.kq1.Size = new System.Drawing.Size(44, 13);
            this.kq1.TabIndex = 8;
            this.kq1.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kq1);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.IpB);
            this.Controls.Add(this.IpA);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputA;
        private System.Windows.Forms.Label inputB;
        private System.Windows.Forms.TextBox IpA;
        private System.Windows.Forms.TextBox IpB;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button repeat;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label kq1;
        public System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}

