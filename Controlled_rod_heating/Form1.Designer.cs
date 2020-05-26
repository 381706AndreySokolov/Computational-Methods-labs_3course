namespace VM_lab_4
{
    partial class Form1
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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.labelT = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelTau = new System.Windows.Forms.Label();
            this.textBoxTau = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.labelFii = new System.Windows.Forms.Label();
            this.labelBi = new System.Windows.Forms.Label();
            this.labeli = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFi1 = new System.Windows.Forms.TextBox();
            this.textBoxB0 = new System.Windows.Forms.TextBox();
            this.textBoxB1 = new System.Windows.Forms.TextBox();
            this.textBoxFi2 = new System.Windows.Forms.TextBox();
            this.textBoxB2 = new System.Windows.Forms.TextBox();
            this.labelWorkTime = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(861, 543);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(989, 79);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(46, 20);
            this.textBoxT.TabIndex = 1;
            this.textBoxT.Text = "1";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelT.Location = new System.Drawing.Point(952, 80);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(30, 16);
            this.labelT.TabIndex = 2;
            this.labelT.Text = "T = ";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL.Location = new System.Drawing.Point(958, 118);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(24, 16);
            this.labelL.TabIndex = 3;
            this.labelL.Text = "l = ";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelH.Location = new System.Drawing.Point(949, 187);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(33, 18);
            this.labelH.TabIndex = 5;
            this.labelH.Text = "h = ";
            // 
            // labelTau
            // 
            this.labelTau.AutoSize = true;
            this.labelTau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTau.Location = new System.Drawing.Point(944, 154);
            this.labelTau.Name = "labelTau";
            this.labelTau.Size = new System.Drawing.Size(39, 16);
            this.labelTau.TabIndex = 6;
            this.labelTau.Text = "tau = ";
            // 
            // textBoxTau
            // 
            this.textBoxTau.Location = new System.Drawing.Point(989, 153);
            this.textBoxTau.Name = "textBoxTau";
            this.textBoxTau.Size = new System.Drawing.Size(46, 20);
            this.textBoxTau.TabIndex = 8;
            this.textBoxTau.Text = "0.1";
            // 
            // Run
            // 
            this.Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Run.Location = new System.Drawing.Point(882, 413);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(195, 32);
            this.Run.TabIndex = 9;
            this.Run.Text = "Посчитать";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(882, 451);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(195, 32);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(989, 117);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(46, 20);
            this.textBoxL.TabIndex = 11;
            this.textBoxL.Text = "7";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(989, 188);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(46, 20);
            this.textBoxH.TabIndex = 12;
            this.textBoxH.Text = "0.1";
            // 
            // labelFii
            // 
            this.labelFii.AutoSize = true;
            this.labelFii.Location = new System.Drawing.Point(890, 328);
            this.labelFii.Name = "labelFii";
            this.labelFii.Size = new System.Drawing.Size(29, 13);
            this.labelFii.TabIndex = 14;
            this.labelFii.Text = "fi [ i ]";
            // 
            // labelBi
            // 
            this.labelBi.AutoSize = true;
            this.labelBi.Location = new System.Drawing.Point(889, 363);
            this.labelBi.Name = "labelBi";
            this.labelBi.Size = new System.Drawing.Size(30, 13);
            this.labelBi.TabIndex = 15;
            this.labelBi.Text = "b [ i ]";
            // 
            // labeli
            // 
            this.labeli.AutoSize = true;
            this.labeli.Location = new System.Drawing.Point(904, 295);
            this.labeli.Name = "labeli";
            this.labeli.Size = new System.Drawing.Size(9, 13);
            this.labeli.TabIndex = 16;
            this.labeli.Text = "i";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(954, 295);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(13, 13);
            this.label0.TabIndex = 17;
            this.label0.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1007, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1054, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "2";
            // 
            // textBoxFi1
            // 
            this.textBoxFi1.Location = new System.Drawing.Point(989, 325);
            this.textBoxFi1.Name = "textBoxFi1";
            this.textBoxFi1.Size = new System.Drawing.Size(31, 20);
            this.textBoxFi1.TabIndex = 20;
            this.textBoxFi1.Text = "0";
            // 
            // textBoxB0
            // 
            this.textBoxB0.Location = new System.Drawing.Point(934, 360);
            this.textBoxB0.Name = "textBoxB0";
            this.textBoxB0.Size = new System.Drawing.Size(33, 20);
            this.textBoxB0.TabIndex = 21;
            this.textBoxB0.Text = "0";
            // 
            // textBoxB1
            // 
            this.textBoxB1.Location = new System.Drawing.Point(989, 360);
            this.textBoxB1.Name = "textBoxB1";
            this.textBoxB1.Size = new System.Drawing.Size(31, 20);
            this.textBoxB1.TabIndex = 22;
            this.textBoxB1.Text = "0.3";
            // 
            // textBoxFi2
            // 
            this.textBoxFi2.Location = new System.Drawing.Point(1035, 325);
            this.textBoxFi2.Name = "textBoxFi2";
            this.textBoxFi2.Size = new System.Drawing.Size(32, 20);
            this.textBoxFi2.TabIndex = 23;
            this.textBoxFi2.Text = "0";
            // 
            // textBoxB2
            // 
            this.textBoxB2.Location = new System.Drawing.Point(1035, 360);
            this.textBoxB2.Name = "textBoxB2";
            this.textBoxB2.Size = new System.Drawing.Size(32, 20);
            this.textBoxB2.TabIndex = 24;
            this.textBoxB2.Text = "0";
            // 
            // labelWorkTime
            // 
            this.labelWorkTime.AutoSize = true;
            this.labelWorkTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkTime.Location = new System.Drawing.Point(889, 502);
            this.labelWorkTime.Name = "labelWorkTime";
            this.labelWorkTime.Size = new System.Drawing.Size(117, 18);
            this.labelWorkTime.TabIndex = 25;
            this.labelWorkTime.Text = "Время работы: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(873, 532);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(204, 23);
            this.progressBar1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(916, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Соколов Андрей 381706-1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(892, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Для вывода зеленого графика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(966, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "нажмите пробел";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(889, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "tau - шаг по времени";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(889, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "h - шаг по стержню";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(942, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "1/ l";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(889, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "l - длина стержня";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(889, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "T - время воздействия";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 567);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelWorkTime);
            this.Controls.Add(this.textBoxB2);
            this.Controls.Add(this.textBoxFi2);
            this.Controls.Add(this.textBoxB1);
            this.Controls.Add(this.textBoxB0);
            this.Controls.Add(this.textBoxFi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.labeli);
            this.Controls.Add(this.labelBi);
            this.Controls.Add(this.labelFii);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.textBoxTau);
            this.Controls.Add(this.labelTau);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Sokolov Andrey 381706-1 LAB_4";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;

        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Clear;

        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.TextBox textBoxT;

        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.TextBox textBoxL;

        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.TextBox textBoxH;

        private System.Windows.Forms.Label labelTau;
        private System.Windows.Forms.TextBox textBoxTau;

        private System.Windows.Forms.Label labelFii;
        private System.Windows.Forms.Label labelBi;
        private System.Windows.Forms.Label labeli;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFi1;
        private System.Windows.Forms.TextBox textBoxFi2;
        private System.Windows.Forms.TextBox textBoxB0;
        private System.Windows.Forms.TextBox textBoxB1;
        private System.Windows.Forms.TextBox textBoxB2;
        private System.Windows.Forms.Label labelWorkTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

