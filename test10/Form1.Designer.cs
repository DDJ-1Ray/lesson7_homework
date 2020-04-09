namespace test10
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.hSB1 = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.per1Bar = new System.Windows.Forms.VScrollBar();
            this.per2Bar = new System.Windows.Forms.VScrollBar();
            this.th1Bar = new System.Windows.Forms.VScrollBar();
            this.th2Bar = new System.Windows.Forms.VScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.per1textBox2 = new System.Windows.Forms.TextBox();
            this.per2textBox3 = new System.Windows.Forms.TextBox();
            this.th2textBox = new System.Windows.Forms.TextBox();
            this.th1textBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(449, 342);
            this.hScrollBar1.Maximum = 15;
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(117, 26);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Value = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "深度:1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 397);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(442, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "顏色";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 67);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "藍色";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "紅色";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "黑色";
            this.radioButton1.UseMnemonic = false;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "消除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hSB1
            // 
            this.hSB1.LargeChange = 1;
            this.hSB1.Location = new System.Drawing.Point(449, 169);
            this.hSB1.Maximum = 150;
            this.hSB1.Name = "hSB1";
            this.hSB1.Size = new System.Drawing.Size(123, 26);
            this.hSB1.TabIndex = 7;
            this.hSB1.Value = 100;
            this.hSB1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSB1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(649, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "100";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "主干長度";
            // 
            // per1Bar
            // 
            this.per1Bar.LargeChange = 1;
            this.per1Bar.Location = new System.Drawing.Point(449, 210);
            this.per1Bar.Maximum = 10;
            this.per1Bar.Minimum = 1;
            this.per1Bar.Name = "per1Bar";
            this.per1Bar.Size = new System.Drawing.Size(35, 80);
            this.per1Bar.TabIndex = 10;
            this.per1Bar.Value = 6;
            this.per1Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.per1Bar_Scroll);
            // 
            // per2Bar
            // 
            this.per2Bar.LargeChange = 1;
            this.per2Bar.Location = new System.Drawing.Point(484, 210);
            this.per2Bar.Maximum = 10;
            this.per2Bar.Minimum = 1;
            this.per2Bar.Name = "per2Bar";
            this.per2Bar.Size = new System.Drawing.Size(35, 80);
            this.per2Bar.TabIndex = 11;
            this.per2Bar.Value = 7;
            this.per2Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.per2Bar_Scroll);
            // 
            // th1Bar
            // 
            this.th1Bar.Location = new System.Drawing.Point(519, 210);
            this.th1Bar.Maximum = 360;
            this.th1Bar.Name = "th1Bar";
            this.th1Bar.Size = new System.Drawing.Size(35, 80);
            this.th1Bar.TabIndex = 12;
            this.th1Bar.Value = 30;
            this.th1Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.th1Bar_Scroll);
            // 
            // th2Bar
            // 
            this.th2Bar.Location = new System.Drawing.Point(554, 210);
            this.th2Bar.Maximum = 360;
            this.th2Bar.Name = "th2Bar";
            this.th2Bar.Size = new System.Drawing.Size(35, 80);
            this.th2Bar.TabIndex = 13;
            this.th2Bar.Value = 20;
            this.th2Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.th2Bar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "左分支長度比";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "右分支長度比";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "右分支角度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "左分支角度";
            // 
            // per1textBox2
            // 
            this.per1textBox2.Location = new System.Drawing.Point(692, 216);
            this.per1textBox2.Name = "per1textBox2";
            this.per1textBox2.Size = new System.Drawing.Size(65, 22);
            this.per1textBox2.TabIndex = 18;
            this.per1textBox2.Text = "6";
            this.per1textBox2.TextChanged += new System.EventHandler(this.per1textBox2_TextChanged);
            // 
            // per2textBox3
            // 
            this.per2textBox3.Location = new System.Drawing.Point(692, 237);
            this.per2textBox3.Name = "per2textBox3";
            this.per2textBox3.Size = new System.Drawing.Size(65, 22);
            this.per2textBox3.TabIndex = 19;
            this.per2textBox3.Text = "7";
            this.per2textBox3.TextChanged += new System.EventHandler(this.per2textBox3_TextChanged);
            // 
            // th2textBox
            // 
            this.th2textBox.Location = new System.Drawing.Point(683, 301);
            this.th2textBox.Name = "th2textBox";
            this.th2textBox.Size = new System.Drawing.Size(74, 22);
            this.th2textBox.TabIndex = 20;
            this.th2textBox.Text = "20";
            this.th2textBox.TextChanged += new System.EventHandler(this.th2textBox_TextChanged);
            // 
            // th1textBox
            // 
            this.th1textBox.Location = new System.Drawing.Point(683, 275);
            this.th1textBox.Name = "th1textBox";
            this.th1textBox.Size = new System.Drawing.Size(74, 22);
            this.th1textBox.TabIndex = 21;
            this.th1textBox.Text = "30";
            this.th1textBox.TextChanged += new System.EventHandler(this.th1textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.th1textBox);
            this.Controls.Add(this.th2textBox);
            this.Controls.Add(this.per2textBox3);
            this.Controls.Add(this.per1textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.th2Bar);
            this.Controls.Add(this.th1Bar);
            this.Controls.Add(this.per2Bar);
            this.Controls.Add(this.per1Bar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hSB1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.HScrollBar hSB1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar per1Bar;
        private System.Windows.Forms.VScrollBar per2Bar;
        private System.Windows.Forms.VScrollBar th1Bar;
        private System.Windows.Forms.VScrollBar th2Bar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox per1textBox2;
        private System.Windows.Forms.TextBox per2textBox3;
        private System.Windows.Forms.TextBox th2textBox;
        private System.Windows.Forms.TextBox th1textBox;
    }
}

