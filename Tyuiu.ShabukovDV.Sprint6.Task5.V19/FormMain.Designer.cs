﻿
namespace Tyuiu.ShabukovDV.Sprint6.Task5.V19
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_KDG = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_KDG = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KDG = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_KDG = new System.Windows.Forms.DataGridView();
            this.buttonDone_KDG = new System.Windows.Forms.Button();
            this.buttonOpenFile_KDG = new System.Windows.Forms.Button();
            this.panelTask_KDG = new System.Windows.Forms.Panel();
            this.buttonHelp_KDG = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition_KDG.SuspendLayout();
            this.groupBoxResult_KDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KDG)).BeginInit();
            this.panelTask_KDG.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_KDG
            // 
            this.groupBoxCondition_KDG.Controls.Add(this.textBoxCondition_KDG);
            this.groupBoxCondition_KDG.Location = new System.Drawing.Point(11, 11);
            this.groupBoxCondition_KDG.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCondition_KDG.Name = "groupBoxCondition_KDG";
            this.groupBoxCondition_KDG.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCondition_KDG.Size = new System.Drawing.Size(359, 70);
            this.groupBoxCondition_KDG.TabIndex = 1;
            this.groupBoxCondition_KDG.TabStop = false;
            this.groupBoxCondition_KDG.Text = "Условие:";
            // 
            // textBoxCondition_KDG
            // 
            this.textBoxCondition_KDG.Location = new System.Drawing.Point(1, 18);
            this.textBoxCondition_KDG.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCondition_KDG.Multiline = true;
            this.textBoxCondition_KDG.Name = "textBoxCondition_KDG";
            this.textBoxCondition_KDG.ReadOnly = true;
            this.textBoxCondition_KDG.Size = new System.Drawing.Size(355, 48);
            this.textBoxCondition_KDG.TabIndex = 0;
            this.textBoxCondition_KDG.Text = "Прочитать данные из файла InPutFileTask5V19.txt. Вывести в dataGridView. \r\nВывест" +
    "и все целые числа. Построить диаграмму по этим значениям.";
            // 
            // groupBoxResult_KDG
            // 
            this.groupBoxResult_KDG.Controls.Add(this.dataGridViewResult_KDG);
            this.groupBoxResult_KDG.Location = new System.Drawing.Point(12, 81);
            this.groupBoxResult_KDG.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_KDG.Name = "groupBoxResult_KDG";
            this.groupBoxResult_KDG.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_KDG.Size = new System.Drawing.Size(137, 360);
            this.groupBoxResult_KDG.TabIndex = 3;
            this.groupBoxResult_KDG.TabStop = false;
            this.groupBoxResult_KDG.Text = "Вывод:";
            // 
            // dataGridViewResult_KDG
            // 
            this.dataGridViewResult_KDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KDG.ColumnHeadersVisible = false;
            this.dataGridViewResult_KDG.Location = new System.Drawing.Point(-1, 17);
            this.dataGridViewResult_KDG.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewResult_KDG.Name = "dataGridViewResult_KDG";
            this.dataGridViewResult_KDG.RowHeadersVisible = false;
            this.dataGridViewResult_KDG.RowHeadersWidth = 51;
            this.dataGridViewResult_KDG.RowTemplate.Height = 24;
            this.dataGridViewResult_KDG.Size = new System.Drawing.Size(134, 338);
            this.dataGridViewResult_KDG.TabIndex = 0;
            // 
            // buttonDone_KDG
            // 
            this.buttonDone_KDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_KDG.ForeColor = System.Drawing.Color.Black;
            this.buttonDone_KDG.Location = new System.Drawing.Point(371, 20);
            this.buttonDone_KDG.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_KDG.Name = "buttonDone_KDG";
            this.buttonDone_KDG.Size = new System.Drawing.Size(74, 61);
            this.buttonDone_KDG.TabIndex = 4;
            this.buttonDone_KDG.Text = "Выполнить";
            this.buttonDone_KDG.UseVisualStyleBackColor = false;
            // 
            // buttonOpenFile_KDG
            // 
            this.buttonOpenFile_KDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOpenFile_KDG.Location = new System.Drawing.Point(449, 20);
            this.buttonOpenFile_KDG.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFile_KDG.Name = "buttonOpenFile_KDG";
            this.buttonOpenFile_KDG.Size = new System.Drawing.Size(71, 61);
            this.buttonOpenFile_KDG.TabIndex = 5;
            this.buttonOpenFile_KDG.Text = "Открыть файл";
            this.buttonOpenFile_KDG.UseVisualStyleBackColor = false;
            // 
            // panelTask_KDG
            // 
            this.panelTask_KDG.Controls.Add(this.buttonHelp_KDG);
            this.panelTask_KDG.Controls.Add(this.button1);
            this.panelTask_KDG.Controls.Add(this.button2);
            this.panelTask_KDG.Controls.Add(this.groupBox1);
            this.panelTask_KDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_KDG.Location = new System.Drawing.Point(0, 0);
            this.panelTask_KDG.Margin = new System.Windows.Forms.Padding(2);
            this.panelTask_KDG.Name = "panelTask_KDG";
            this.panelTask_KDG.Padding = new System.Windows.Forms.Padding(4);
            this.panelTask_KDG.Size = new System.Drawing.Size(598, 81);
            this.panelTask_KDG.TabIndex = 6;
            // 
            // buttonHelp_KDG
            // 
            this.buttonHelp_KDG.BackColor = System.Drawing.Color.Teal;
            this.buttonHelp_KDG.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp_KDG.Location = new System.Drawing.Point(523, 4);
            this.buttonHelp_KDG.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_KDG.Name = "buttonHelp_KDG";
            this.buttonHelp_KDG.Size = new System.Drawing.Size(71, 73);
            this.buttonHelp_KDG.TabIndex = 1;
            this.buttonHelp_KDG.Text = "Справка";
            this.buttonHelp_KDG.UseVisualStyleBackColor = false;
            this.buttonHelp_KDG.Click += new System.EventHandler(this.buttonHelp_KDG_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(449, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть файл";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(370, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(359, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(355, 48);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V19.txt. Вывести в dataGridView. \r\nВывест" +
    "и все целые числа. Построить диаграмму по этим значениям.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(166, 86);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(420, 355);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panelTask_KDG);
            this.Controls.Add(this.buttonOpenFile_KDG);
            this.Controls.Add(this.buttonDone_KDG);
            this.Controls.Add(this.groupBoxResult_KDG);
            this.Controls.Add(this.groupBoxCondition_KDG);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxCondition_KDG.ResumeLayout(false);
            this.groupBoxCondition_KDG.PerformLayout();
            this.groupBoxResult_KDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KDG)).EndInit();
            this.panelTask_KDG.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_KDG;
        private System.Windows.Forms.TextBox textBoxCondition_KDG;
        private System.Windows.Forms.GroupBox groupBoxResult_KDG;
        private System.Windows.Forms.DataGridView dataGridViewResult_KDG;
        private System.Windows.Forms.Button buttonDone_KDG;
        private System.Windows.Forms.Button buttonOpenFile_KDG;
        private System.Windows.Forms.Panel panelTask_KDG;
        private System.Windows.Forms.Button buttonHelp_KDG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

