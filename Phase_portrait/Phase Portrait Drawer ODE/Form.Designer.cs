namespace Phase_Portrait_Drawer_ODE
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxFormula1 = new System.Windows.Forms.TextBox();
            this.labelFormula = new System.Windows.Forms.Label();
            this.pictureBoxLaTeX1 = new System.Windows.Forms.PictureBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxt0 = new System.Windows.Forms.TextBox();
            this.textBoxt1 = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelt0 = new System.Windows.Forms.Label();
            this.labelt1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxLaTeX2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFormula2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxXmin = new System.Windows.Forms.TextBox();
            this.textBoxXmax = new System.Windows.Forms.TextBox();
            this.textBoxYmin = new System.Windows.Forms.TextBox();
            this.textBoxYmax = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaTeX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaTeX2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFormula1
            // 
            this.textBoxFormula1.Location = new System.Drawing.Point(599, 3);
            this.textBoxFormula1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFormula1.Name = "textBoxFormula1";
            this.textBoxFormula1.Size = new System.Drawing.Size(108, 23);
            this.textBoxFormula1.TabIndex = 0;
            this.textBoxFormula1.Text = "y";
            this.textBoxFormula1.Visible = false;
            // 
            // labelFormula
            // 
            this.labelFormula.AutoSize = true;
            this.labelFormula.Location = new System.Drawing.Point(21, 25);
            this.labelFormula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormula.Name = "labelFormula";
            this.labelFormula.Size = new System.Drawing.Size(60, 17);
            this.labelFormula.TabIndex = 1;
            this.labelFormula.Text = "x\'(x,y)  =";
            // 
            // pictureBoxLaTeX1
            // 
            this.pictureBoxLaTeX1.Location = new System.Drawing.Point(216, 5);
            this.pictureBoxLaTeX1.Name = "pictureBoxLaTeX1";
            this.pictureBoxLaTeX1.Size = new System.Drawing.Size(20, 10);
            this.pictureBoxLaTeX1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLaTeX1.TabIndex = 2;
            this.pictureBoxLaTeX1.TabStop = false;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 109);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1344, 657);
            this.chart.TabIndex = 3;
            this.chart.Text = "chart";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(599, 33);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(196, 60);
            this.buttonDraw.TabIndex = 4;
            this.buttonDraw.Text = "Построить";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.ButtonDraw_Click);
            // 
            // textBoxt0
            // 
            this.textBoxt0.Location = new System.Drawing.Point(405, 19);
            this.textBoxt0.Name = "textBoxt0";
            this.textBoxt0.Size = new System.Drawing.Size(38, 23);
            this.textBoxt0.TabIndex = 5;
            this.textBoxt0.Text = "0";
            // 
            // textBoxt1
            // 
            this.textBoxt1.Location = new System.Drawing.Point(405, 50);
            this.textBoxt1.Name = "textBoxt1";
            this.textBoxt1.Size = new System.Drawing.Size(38, 23);
            this.textBoxt1.TabIndex = 6;
            this.textBoxt1.Text = "1";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(512, 19);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(34, 23);
            this.textBoxX.TabIndex = 7;
            this.textBoxX.Text = "0";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(512, 50);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(34, 23);
            this.textBoxY.TabIndex = 8;
            this.textBoxY.Text = "1";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(458, 22);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(48, 17);
            this.labelX.TabIndex = 9;
            this.labelX.Text = "x(t0) =";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(457, 53);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(49, 17);
            this.labelY.TabIndex = 10;
            this.labelY.Text = "y(t0) =";
            // 
            // labelt0
            // 
            this.labelt0.AutoSize = true;
            this.labelt0.Location = new System.Drawing.Point(367, 22);
            this.labelt0.Name = "labelt0";
            this.labelt0.Size = new System.Drawing.Size(32, 17);
            this.labelt0.TabIndex = 11;
            this.labelt0.Text = "t0 =";
            // 
            // labelt1
            // 
            this.labelt1.AutoSize = true;
            this.labelt1.Location = new System.Drawing.Point(367, 53);
            this.labelt1.Name = "labelt1";
            this.labelt1.Size = new System.Drawing.Size(32, 17);
            this.labelt1.TabIndex = 12;
            this.labelt1.Text = "t1 =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "h =";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(405, 80);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(38, 23);
            this.textBoxH.TabIndex = 14;
            this.textBoxH.Text = "0.1";
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(854, 33);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(182, 60);
            this.buttonClean.TabIndex = 15;
            this.buttonClean.Text = "Очистить";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1086, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 60);
            this.button1.TabIndex = 16;
            this.button1.Text = "Построить фазовый портрет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBoxLaTeX2
            // 
            this.pictureBoxLaTeX2.Location = new System.Drawing.Point(299, 5);
            this.pictureBoxLaTeX2.Name = "pictureBoxLaTeX2";
            this.pictureBoxLaTeX2.Size = new System.Drawing.Size(19, 10);
            this.pictureBoxLaTeX2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLaTeX2.TabIndex = 19;
            this.pictureBoxLaTeX2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "y\'(x,y) =";
            // 
            // textBoxFormula2
            // 
            this.textBoxFormula2.Location = new System.Drawing.Point(715, 3);
            this.textBoxFormula2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFormula2.Name = "textBoxFormula2";
            this.textBoxFormula2.Size = new System.Drawing.Size(108, 23);
            this.textBoxFormula2.TabIndex = 17;
            this.textBoxFormula2.Text = "-1*y+sin(x)";
            this.textBoxFormula2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label4.Location = new System.Drawing.Point(1093, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Может занять немного времени";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "ε =";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(512, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 23);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "0.01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "уравнение маятника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "c диссипацией";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "- δ * y - sin(x)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "δ =";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(251, 70);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(53, 23);
            this.textBoxDelta.TabIndex = 29;
            this.textBoxDelta.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1274, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "X min";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1274, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "X max";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1274, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Y min";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1274, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Y max";
            // 
            // textBoxXmin
            // 
            this.textBoxXmin.Location = new System.Drawing.Point(1323, 3);
            this.textBoxXmin.Name = "textBoxXmin";
            this.textBoxXmin.Size = new System.Drawing.Size(42, 23);
            this.textBoxXmin.TabIndex = 34;
            this.textBoxXmin.Text = "-20";
            // 
            // textBoxXmax
            // 
            this.textBoxXmax.Location = new System.Drawing.Point(1323, 28);
            this.textBoxXmax.Name = "textBoxXmax";
            this.textBoxXmax.Size = new System.Drawing.Size(42, 23);
            this.textBoxXmax.TabIndex = 35;
            this.textBoxXmax.Text = "20";
            // 
            // textBoxYmin
            // 
            this.textBoxYmin.Location = new System.Drawing.Point(1323, 56);
            this.textBoxYmin.Name = "textBoxYmin";
            this.textBoxYmin.Size = new System.Drawing.Size(42, 23);
            this.textBoxYmin.TabIndex = 36;
            this.textBoxYmin.Text = "-20";
            // 
            // textBoxYmax
            // 
            this.textBoxYmax.Location = new System.Drawing.Point(1323, 82);
            this.textBoxYmax.Name = "textBoxYmax";
            this.textBoxYmax.Size = new System.Drawing.Size(42, 23);
            this.textBoxYmax.TabIndex = 37;
            this.textBoxYmax.Text = "20";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label14.Location = new System.Drawing.Point(1100, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Строить только в этой области->";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 778);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxYmax);
            this.Controls.Add(this.textBoxYmin);
            this.Controls.Add(this.textBoxXmax);
            this.Controls.Add(this.textBoxXmin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxLaTeX2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFormula2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelt1);
            this.Controls.Add(this.labelt0);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxt1);
            this.Controls.Add(this.textBoxt0);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.pictureBoxLaTeX1);
            this.Controls.Add(this.labelFormula);
            this.Controls.Add(this.textBoxFormula1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaTeX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaTeX2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFormula1;
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.PictureBox pictureBoxLaTeX1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxt0;
        private System.Windows.Forms.TextBox textBoxt1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelt0;
        private System.Windows.Forms.Label labelt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxLaTeX2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFormula2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxXmin;
        private System.Windows.Forms.TextBox textBoxXmax;
        private System.Windows.Forms.TextBox textBoxYmin;
        private System.Windows.Forms.TextBox textBoxYmax;
        private System.Windows.Forms.Label label14;
    }
}

