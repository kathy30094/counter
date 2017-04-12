namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.countOutPut = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.countResult = new System.Windows.Forms.Button();
            this.mitiply = new System.Windows.Forms.Button();
            this.minux = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.AC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countOutPut
            // 
            this.countOutPut.AutoSize = true;
            this.countOutPut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countOutPut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countOutPut.Location = new System.Drawing.Point(18, 30);
            this.countOutPut.MinimumSize = new System.Drawing.Size(250, 30);
            this.countOutPut.Name = "countOutPut";
            this.countOutPut.Size = new System.Drawing.Size(250, 30);
            this.countOutPut.TabIndex = 0;
            this.countOutPut.Text = "0";
            this.countOutPut.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(69, 88);
            this.n1.MaximumSize = new System.Drawing.Size(40, 30);
            this.n1.MinimumSize = new System.Drawing.Size(40, 30);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(40, 30);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.numberInput);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(69, 133);
            this.n4.MaximumSize = new System.Drawing.Size(40, 30);
            this.n4.MinimumSize = new System.Drawing.Size(40, 30);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(40, 30);
            this.n4.TabIndex = 2;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.numberInput);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(69, 176);
            this.n7.MaximumSize = new System.Drawing.Size(40, 30);
            this.n7.MinimumSize = new System.Drawing.Size(40, 30);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(40, 30);
            this.n7.TabIndex = 3;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.numberInput);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(123, 88);
            this.n2.MaximumSize = new System.Drawing.Size(40, 30);
            this.n2.MinimumSize = new System.Drawing.Size(40, 30);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(40, 30);
            this.n2.TabIndex = 4;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.numberInput);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(123, 133);
            this.n5.MaximumSize = new System.Drawing.Size(40, 30);
            this.n5.MinimumSize = new System.Drawing.Size(40, 30);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(40, 30);
            this.n5.TabIndex = 5;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.numberInput);
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(123, 176);
            this.n8.MaximumSize = new System.Drawing.Size(40, 30);
            this.n8.MinimumSize = new System.Drawing.Size(40, 30);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(40, 30);
            this.n8.TabIndex = 6;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.numberInput);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(177, 88);
            this.n3.MaximumSize = new System.Drawing.Size(40, 30);
            this.n3.MinimumSize = new System.Drawing.Size(40, 30);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(40, 30);
            this.n3.TabIndex = 7;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.numberInput);
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(177, 133);
            this.n6.MaximumSize = new System.Drawing.Size(40, 30);
            this.n6.MinimumSize = new System.Drawing.Size(40, 30);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(40, 30);
            this.n6.TabIndex = 8;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.numberInput);
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(177, 176);
            this.n9.MaximumSize = new System.Drawing.Size(40, 30);
            this.n9.MinimumSize = new System.Drawing.Size(40, 30);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(40, 30);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.numberInput);
            // 
            // countResult
            // 
            this.countResult.Location = new System.Drawing.Point(177, 220);
            this.countResult.Name = "countResult";
            this.countResult.Size = new System.Drawing.Size(40, 30);
            this.countResult.TabIndex = 10;
            this.countResult.Text = "=";
            this.countResult.UseVisualStyleBackColor = true;
            this.countResult.Click += new System.EventHandler(this.countResultClick);
            // 
            // mitiply
            // 
            this.mitiply.Location = new System.Drawing.Point(232, 176);
            this.mitiply.MaximumSize = new System.Drawing.Size(40, 30);
            this.mitiply.MinimumSize = new System.Drawing.Size(40, 30);
            this.mitiply.Name = "mitiply";
            this.mitiply.Size = new System.Drawing.Size(40, 30);
            this.mitiply.TabIndex = 13;
            this.mitiply.Text = "*";
            this.mitiply.UseVisualStyleBackColor = true;
            this.mitiply.Click += new System.EventHandler(this.operatorInput);
            // 
            // minux
            // 
            this.minux.Location = new System.Drawing.Point(232, 133);
            this.minux.MaximumSize = new System.Drawing.Size(40, 30);
            this.minux.MinimumSize = new System.Drawing.Size(40, 30);
            this.minux.Name = "minux";
            this.minux.Size = new System.Drawing.Size(40, 30);
            this.minux.TabIndex = 12;
            this.minux.Text = "-";
            this.minux.UseVisualStyleBackColor = true;
            this.minux.Click += new System.EventHandler(this.operatorInput);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(232, 88);
            this.plus.MaximumSize = new System.Drawing.Size(40, 30);
            this.plus.MinimumSize = new System.Drawing.Size(40, 30);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(40, 30);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.operatorInput);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(232, 220);
            this.division.MaximumSize = new System.Drawing.Size(40, 30);
            this.division.MinimumSize = new System.Drawing.Size(40, 30);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(40, 30);
            this.division.TabIndex = 14;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.operatorInput);
            // 
            // n0
            // 
            this.n0.Location = new System.Drawing.Point(69, 220);
            this.n0.MaximumSize = new System.Drawing.Size(40, 30);
            this.n0.MinimumSize = new System.Drawing.Size(40, 30);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(40, 30);
            this.n0.TabIndex = 15;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.numberInput);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(123, 220);
            this.point.MaximumSize = new System.Drawing.Size(40, 30);
            this.point.MinimumSize = new System.Drawing.Size(40, 30);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(40, 30);
            this.point.TabIndex = 16;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.addPoint);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(12, 220);
            this.button17.MaximumSize = new System.Drawing.Size(40, 30);
            this.button17.MinimumSize = new System.Drawing.Size(40, 30);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(40, 30);
            this.button17.TabIndex = 20;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(12, 176);
            this.button18.MaximumSize = new System.Drawing.Size(40, 30);
            this.button18.MinimumSize = new System.Drawing.Size(40, 30);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(40, 30);
            this.button18.TabIndex = 19;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(12, 133);
            this.button19.MaximumSize = new System.Drawing.Size(40, 30);
            this.button19.MinimumSize = new System.Drawing.Size(40, 30);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(40, 30);
            this.button19.TabIndex = 18;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // AC
            // 
            this.AC.Location = new System.Drawing.Point(12, 88);
            this.AC.MaximumSize = new System.Drawing.Size(40, 30);
            this.AC.MinimumSize = new System.Drawing.Size(40, 30);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(40, 30);
            this.AC.TabIndex = 17;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = true;
            this.AC.Click += new System.EventHandler(this.clickAC);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.AC);
            this.Controls.Add(this.point);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.division);
            this.Controls.Add(this.mitiply);
            this.Controls.Add(this.minux);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.countResult);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.countOutPut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countOutPut;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button countResult;
        private System.Windows.Forms.Button mitiply;
        private System.Windows.Forms.Button minux;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button AC;
    }
}

