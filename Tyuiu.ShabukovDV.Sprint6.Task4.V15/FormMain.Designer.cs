
namespace Tyuiu.ShabukovDV.Sprint6.Task4.V15
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_GKU = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GKU = new System.Windows.Forms.TextBox();
            this.groupBoxInput_GKU = new System.Windows.Forms.GroupBox();
            this.labelStopStep_GKU = new System.Windows.Forms.Label();
            this.labelStartStep_GKU = new System.Windows.Forms.Label();
            this.textBoxStopStep_GKU = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_GKU = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonInfo_GKU = new System.Windows.Forms.Button();
            this.buttonDone_GKU = new System.Windows.Forms.Button();
            this.buttonSave_GKU = new System.Windows.Forms.Button();
            this.groupBoxOutPut_GKU = new System.Windows.Forms.GroupBox();
            this.chartResult_GKU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxOutPut_GKU = new System.Windows.Forms.TextBox();
            this.groupBoxTask_GKU.SuspendLayout();
            this.groupBoxInput_GKU.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxOutPut_GKU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_GKU)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_GKU
            // 
            this.groupBoxTask_GKU.Controls.Add(this.textBoxTask_GKU);
            this.groupBoxTask_GKU.Location = new System.Drawing.Point(2, 11);
            this.groupBoxTask_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_GKU.Name = "groupBoxTask_GKU";
            this.groupBoxTask_GKU.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_GKU.Size = new System.Drawing.Size(398, 67);
            this.groupBoxTask_GKU.TabIndex = 1;
            this.groupBoxTask_GKU.TabStop = false;
            this.groupBoxTask_GKU.Text = "Условие";
            // 
            // textBoxTask_GKU
            // 
            this.textBoxTask_GKU.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_GKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_GKU.Location = new System.Drawing.Point(6, 15);
            this.textBoxTask_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_GKU.Multiline = true;
            this.textBoxTask_GKU.Name = "textBoxTask_GKU";
            this.textBoxTask_GKU.Size = new System.Drawing.Size(388, 46);
            this.textBoxTask_GKU.TabIndex = 0;
            this.textBoxTask_GKU.TabStop = false;
            this.textBoxTask_GKU.Text = "Протабулировать функцию на заданном промежутке от -5 до 5.\r\nРезультат вывести в t" +
    "extBox, построить график функции и сохранить в файл OutPutFileTask.txt по нажати" +
    "ю кнопки.";
            // 
            // groupBoxInput_GKU
            // 
            this.groupBoxInput_GKU.Controls.Add(this.labelStopStep_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.labelStartStep_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.textBoxStopStep_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.textBoxStartStep_GKU);
            this.groupBoxInput_GKU.Location = new System.Drawing.Point(404, 11);
            this.groupBoxInput_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInput_GKU.Name = "groupBoxInput_GKU";
            this.groupBoxInput_GKU.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInput_GKU.Size = new System.Drawing.Size(261, 67);
            this.groupBoxInput_GKU.TabIndex = 2;
            this.groupBoxInput_GKU.TabStop = false;
            this.groupBoxInput_GKU.Text = "Ввод данных";
            // 
            // labelStopStep_GKU
            // 
            this.labelStopStep_GKU.AutoSize = true;
            this.labelStopStep_GKU.Location = new System.Drawing.Point(130, 21);
            this.labelStopStep_GKU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStopStep_GKU.Name = "labelStopStep_GKU";
            this.labelStopStep_GKU.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_GKU.TabIndex = 3;
            this.labelStopStep_GKU.Text = "Конец шага:";
            // 
            // labelStartStep_GKU
            // 
            this.labelStartStep_GKU.AutoSize = true;
            this.labelStartStep_GKU.Location = new System.Drawing.Point(4, 21);
            this.labelStartStep_GKU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartStep_GKU.Name = "labelStartStep_GKU";
            this.labelStartStep_GKU.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_GKU.TabIndex = 2;
            this.labelStartStep_GKU.Text = "Старт шага:";
            // 
            // textBoxStopStep_GKU
            // 
            this.textBoxStopStep_GKU.Location = new System.Drawing.Point(133, 37);
            this.textBoxStopStep_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStopStep_GKU.Name = "textBoxStopStep_GKU";
            this.textBoxStopStep_GKU.Size = new System.Drawing.Size(125, 20);
            this.textBoxStopStep_GKU.TabIndex = 1;
            // 
            // textBoxStartStep_GKU
            // 
            this.textBoxStartStep_GKU.Location = new System.Drawing.Point(4, 37);
            this.textBoxStartStep_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStartStep_GKU.Name = "textBoxStartStep_GKU";
            this.textBoxStartStep_GKU.Size = new System.Drawing.Size(125, 20);
            this.textBoxStartStep_GKU.TabIndex = 0;
            this.textBoxStartStep_GKU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_GKU_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.buttonInfo_GKU);
            this.panel2.Controls.Add(this.buttonDone_GKU);
            this.panel2.Controls.Add(this.buttonSave_GKU);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 81);
            this.panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(391, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 46);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Протабулировать функцию на заданном промежутке от -5 до 5.\r\nРезультат вывести в t" +
    "extBox, построить график функции и сохранить в файл OutPutFileTask.txt по нажати" +
    "ю кнопки.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(402, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(261, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод данных";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Конец шага:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Старт шага:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 37);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(4, 37);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextChanged += new System.EventHandler(this.textBoxStartStep_GKU_TextChanged);
            // 
            // buttonInfo_GKU
            // 
            this.buttonInfo_GKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GKU.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonInfo_GKU.Location = new System.Drawing.Point(834, 11);
            this.buttonInfo_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo_GKU.Name = "buttonInfo_GKU";
            this.buttonInfo_GKU.Size = new System.Drawing.Size(81, 61);
            this.buttonInfo_GKU.TabIndex = 6;
            this.buttonInfo_GKU.Text = "Справка";
            this.buttonInfo_GKU.UseVisualStyleBackColor = false;
            this.buttonInfo_GKU.Click += new System.EventHandler(this.buttonInfo_GKU_Click);
            // 
            // buttonDone_GKU
            // 
            this.buttonDone_GKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_GKU.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_GKU.Location = new System.Drawing.Point(667, 11);
            this.buttonDone_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_GKU.Name = "buttonDone_GKU";
            this.buttonDone_GKU.Size = new System.Drawing.Size(82, 59);
            this.buttonDone_GKU.TabIndex = 4;
            this.buttonDone_GKU.Text = "Выполнить";
            this.buttonDone_GKU.UseVisualStyleBackColor = false;
            this.buttonDone_GKU.Click += new System.EventHandler(this.buttonDone_GKU_Click);
            // 
            // buttonSave_GKU
            // 
            this.buttonSave_GKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_GKU.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_GKU.Location = new System.Drawing.Point(753, 11);
            this.buttonSave_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave_GKU.Name = "buttonSave_GKU";
            this.buttonSave_GKU.Size = new System.Drawing.Size(77, 59);
            this.buttonSave_GKU.TabIndex = 5;
            this.buttonSave_GKU.Text = "Сохранить";
            this.buttonSave_GKU.UseVisualStyleBackColor = false;
            this.buttonSave_GKU.Click += new System.EventHandler(this.buttonSave_GKU_Click);
            // 
            // groupBoxOutPut_GKU
            // 
            this.groupBoxOutPut_GKU.Controls.Add(this.chartResult_GKU);
            this.groupBoxOutPut_GKU.Controls.Add(this.textBoxOutPut_GKU);
            this.groupBoxOutPut_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GKU.Location = new System.Drawing.Point(0, 81);
            this.groupBoxOutPut_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOutPut_GKU.Name = "groupBoxOutPut_GKU";
            this.groupBoxOutPut_GKU.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOutPut_GKU.Size = new System.Drawing.Size(930, 420);
            this.groupBoxOutPut_GKU.TabIndex = 10;
            this.groupBoxOutPut_GKU.TabStop = false;
            this.groupBoxOutPut_GKU.Text = "Вывод:";
            this.groupBoxOutPut_GKU.Enter += new System.EventHandler(this.groupBoxOutPut_GKU_Enter);
            // 
            // chartResult_GKU
            // 
            chartArea4.Name = "ChartArea1";
            this.chartResult_GKU.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartResult_GKU.Legends.Add(legend4);
            this.chartResult_GKU.Location = new System.Drawing.Point(294, 17);
            this.chartResult_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.chartResult_GKU.Name = "chartResult_GKU";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartResult_GKU.Series.Add(series4);
            this.chartResult_GKU.Size = new System.Drawing.Size(621, 405);
            this.chartResult_GKU.TabIndex = 3;
            this.chartResult_GKU.Text = "chart1";
            this.chartResult_GKU.Click += new System.EventHandler(this.chartResult_GKU_Click);
            // 
            // textBoxOutPut_GKU
            // 
            this.textBoxOutPut_GKU.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxOutPut_GKU.Location = new System.Drawing.Point(2, 15);
            this.textBoxOutPut_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOutPut_GKU.Multiline = true;
            this.textBoxOutPut_GKU.Name = "textBoxOutPut_GKU";
            this.textBoxOutPut_GKU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_GKU.Size = new System.Drawing.Size(288, 403);
            this.textBoxOutPut_GKU.TabIndex = 0;
            this.textBoxOutPut_GKU.TextChanged += new System.EventHandler(this.textBoxOutPut_GKU_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 501);
            this.Controls.Add(this.groupBoxOutPut_GKU);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBoxInput_GKU);
            this.Controls.Add(this.groupBoxTask_GKU);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxTask_GKU.ResumeLayout(false);
            this.groupBoxTask_GKU.PerformLayout();
            this.groupBoxInput_GKU.ResumeLayout(false);
            this.groupBoxInput_GKU.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxOutPut_GKU.ResumeLayout(false);
            this.groupBoxOutPut_GKU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_GKU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_GKU;
        private System.Windows.Forms.TextBox textBoxTask_GKU;
        private System.Windows.Forms.GroupBox groupBoxInput_GKU;
        private System.Windows.Forms.Label labelStopStep_GKU;
        private System.Windows.Forms.Label labelStartStep_GKU;
        private System.Windows.Forms.TextBox textBoxStopStep_GKU;
        private System.Windows.Forms.TextBox textBoxStartStep_GKU;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonInfo_GKU;
        private System.Windows.Forms.Button buttonDone_GKU;
        private System.Windows.Forms.Button buttonSave_GKU;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GKU;
        private System.Windows.Forms.TextBox textBoxOutPut_GKU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_GKU;
    }
}

