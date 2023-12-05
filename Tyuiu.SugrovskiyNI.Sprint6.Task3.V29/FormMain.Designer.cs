
namespace Tyuiu.SugrovskiyNI.Sprint6.Task3.V29
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxData_N_S = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.textBoxResult = new System.Windows.Forms.DataGridView();
            this.button_Done = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxData_N_S);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxData_N_S
            // 
            this.textBoxData_N_S.Location = new System.Drawing.Point(7, 21);
            this.textBoxData_N_S.Multiline = true;
            this.textBoxData_N_S.Name = "textBoxData_N_S";
            this.textBoxData_N_S.ReadOnly = true;
            this.textBoxData_N_S.Size = new System.Drawing.Size(329, 344);
            this.textBoxData_N_S.TabIndex = 0;
            this.textBoxData_N_S.Text = resources.GetString("textBoxData_N_S.Text");
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(220, 326);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(40, 23);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Done);
            this.groupBox3.Controls.Add(this.textBoxResult);
            this.groupBox3.Controls.Add(this.buttonHelp);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(770, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 371);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(360, 54);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersWidth = 51;
            this.dataGridViewMatrix.RowTemplate.Height = 24;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(284, 262);
            this.dataGridViewMatrix.TabIndex = 5;
            this.dataGridViewMatrix.Click += new System.EventHandler(this.FormMain_Load);
            // 
            // textBoxResult
            // 
            this.textBoxResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.textBoxResult.Location = new System.Drawing.Point(31, 31);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.RowHeadersWidth = 51;
            this.textBoxResult.RowTemplate.Height = 24;
            this.textBoxResult.Size = new System.Drawing.Size(324, 248);
            this.textBoxResult.TabIndex = 6;
            this.textBoxResult.Click += new System.EventHandler(this.FormMain_Load);
            // 
            // button_Done
            // 
            this.button_Done.Location = new System.Drawing.Point(266, 326);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(102, 23);
            this.button_Done.TabIndex = 1;
            this.button_Done.Text = "Выполнить";
            this.button_Done.UseVisualStyleBackColor = true;
            this.button_Done.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 413);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxData_N_S;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Button button_Done;
        private System.Windows.Forms.DataGridView textBoxResult;
    }
}

