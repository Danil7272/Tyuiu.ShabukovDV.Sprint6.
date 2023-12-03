
namespace Tyuiu.ShabukovDV.Sprint6.Task3.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonInform_ZDA = new System.Windows.Forms.Button();
            this.buttonPushMe_ZDA = new System.Windows.Forms.Button();
            this.groupBoxOut_ZDA = new System.Windows.Forms.GroupBox();
            this.labelResult_ZDA = new System.Windows.Forms.Label();
            this.textBoxResult_ZDA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_ZDA = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_ZDA = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_ZDA = new System.Windows.Forms.DataGridView();
            this.groupBoxOut_ZDA.SuspendLayout();
            this.groupBoxTask_ZDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_ZDA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInform_ZDA
            // 
            this.buttonInform_ZDA.Location = new System.Drawing.Point(473, 193);
            this.buttonInform_ZDA.Name = "buttonInform_ZDA";
            this.buttonInform_ZDA.Size = new System.Drawing.Size(32, 35);
            this.buttonInform_ZDA.TabIndex = 6;
            this.buttonInform_ZDA.Text = "?";
            this.buttonInform_ZDA.UseVisualStyleBackColor = true;
            this.buttonInform_ZDA.Click += new System.EventHandler(this.buttonInform_ZDA_Click);
            // 
            // buttonPushMe_ZDA
            // 
            this.buttonPushMe_ZDA.Location = new System.Drawing.Point(513, 187);
            this.buttonPushMe_ZDA.Name = "buttonPushMe_ZDA";
            this.buttonPushMe_ZDA.Size = new System.Drawing.Size(80, 47);
            this.buttonPushMe_ZDA.TabIndex = 4;
            this.buttonPushMe_ZDA.Text = "Выполнить";
            this.buttonPushMe_ZDA.UseVisualStyleBackColor = true;
            this.buttonPushMe_ZDA.Click += new System.EventHandler(this.buttonPushMe_ZDA_Click);
            // 
            // groupBoxOut_ZDA
            // 
            this.groupBoxOut_ZDA.Controls.Add(this.labelResult_ZDA);
            this.groupBoxOut_ZDA.Controls.Add(this.textBoxResult_ZDA);
            this.groupBoxOut_ZDA.Location = new System.Drawing.Point(464, 25);
            this.groupBoxOut_ZDA.Name = "groupBoxOut_ZDA";
            this.groupBoxOut_ZDA.Size = new System.Drawing.Size(129, 122);
            this.groupBoxOut_ZDA.TabIndex = 5;
            this.groupBoxOut_ZDA.TabStop = false;
            this.groupBoxOut_ZDA.Text = "Вывод данных";
            // 
            // labelResult_ZDA
            // 
            this.labelResult_ZDA.AutoSize = true;
            this.labelResult_ZDA.Location = new System.Drawing.Point(6, 16);
            this.labelResult_ZDA.Name = "labelResult_ZDA";
            this.labelResult_ZDA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_ZDA.TabIndex = 1;
            this.labelResult_ZDA.Text = "Результат:";
            // 
            // textBoxResult_ZDA
            // 
            this.textBoxResult_ZDA.Location = new System.Drawing.Point(9, 32);
            this.textBoxResult_ZDA.Multiline = true;
            this.textBoxResult_ZDA.Name = "textBoxResult_ZDA";
            this.textBoxResult_ZDA.ReadOnly = true;
            this.textBoxResult_ZDA.Size = new System.Drawing.Size(109, 78);
            this.textBoxResult_ZDA.TabIndex = 0;
            this.textBoxResult_ZDA.TabStop = false;
            // 
            // groupBoxTask_ZDA
            // 
            this.groupBoxTask_ZDA.Controls.Add(this.textBoxUslovie_ZDA);
            this.groupBoxTask_ZDA.Controls.Add(this.dataGridViewMatrix_ZDA);
            this.groupBoxTask_ZDA.Location = new System.Drawing.Point(5, 25);
            this.groupBoxTask_ZDA.Name = "groupBoxTask_ZDA";
            this.groupBoxTask_ZDA.Size = new System.Drawing.Size(453, 209);
            this.groupBoxTask_ZDA.TabIndex = 3;
            this.groupBoxTask_ZDA.TabStop = false;
            this.groupBoxTask_ZDA.Text = "Условие";
            // 
            // textBoxUslovie_ZDA
            // 
            this.textBoxUslovie_ZDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie_ZDA.Location = new System.Drawing.Point(6, 16);
            this.textBoxUslovie_ZDA.Multiline = true;
            this.textBoxUslovie_ZDA.Name = "textBoxUslovie_ZDA";
            this.textBoxUslovie_ZDA.ReadOnly = true;
            this.textBoxUslovie_ZDA.Size = new System.Drawing.Size(242, 184);
            this.textBoxUslovie_ZDA.TabIndex = 0;
            this.textBoxUslovie_ZDA.TabStop = false;
            this.textBoxUslovie_ZDA.Text = resources.GetString("textBoxUslovie_ZDA.Text");
            this.textBoxUslovie_ZDA.TextChanged += new System.EventHandler(this.textBoxUslovie_ZDA_TextChanged);
            // 
            // dataGridViewMatrix_ZDA
            // 
            this.dataGridViewMatrix_ZDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_ZDA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_ZDA.Location = new System.Drawing.Point(254, 16);
            this.dataGridViewMatrix_ZDA.Name = "dataGridViewMatrix_ZDA";
            this.dataGridViewMatrix_ZDA.ReadOnly = true;
            this.dataGridViewMatrix_ZDA.RowHeadersVisible = false;
            this.dataGridViewMatrix_ZDA.Size = new System.Drawing.Size(193, 184);
            this.dataGridViewMatrix_ZDA.TabIndex = 0;
            this.dataGridViewMatrix_ZDA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 259);
            this.Controls.Add(this.buttonInform_ZDA);
            this.Controls.Add(this.buttonPushMe_ZDA);
            this.Controls.Add(this.groupBoxOut_ZDA);
            this.Controls.Add(this.groupBoxTask_ZDA);
            this.Name = "FormMain";
            this.Text = "Спринт6 | Таск3 | Вариант 20 | Шабуков Д. В. | СМАРТб-23-1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOut_ZDA.ResumeLayout(false);
            this.groupBoxOut_ZDA.PerformLayout();
            this.groupBoxTask_ZDA.ResumeLayout(false);
            this.groupBoxTask_ZDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_ZDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInform_ZDA;
        private System.Windows.Forms.Button buttonPushMe_ZDA;
        private System.Windows.Forms.GroupBox groupBoxOut_ZDA;
        private System.Windows.Forms.Label labelResult_ZDA;
        private System.Windows.Forms.TextBox textBoxResult_ZDA;
        private System.Windows.Forms.GroupBox groupBoxTask_ZDA;
        private System.Windows.Forms.TextBox textBoxUslovie_ZDA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_ZDA;
    }
}

