
namespace Tyuiu.SugrovskiyNI.Sprint6.Task6.V25
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDone = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.Button();
            this.FormAbout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxLoadFromFile = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonDone);
            this.panel1.Controls.Add(this.FileName);
            this.panel1.Controls.Add(this.FormAbout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 87);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 81);
            this.panel2.TabIndex = 1;
            // 
            // buttonDone
            // 
            this.buttonDone.Image = global::Tyuiu.SugrovskiyNI.Sprint6.Task6.V25.Properties.Resources.textblock_1054__1_;
            this.buttonDone.Location = new System.Drawing.Point(91, 12);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(73, 60);
            this.buttonDone.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonDone, "Производит поиск");
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FileName
            // 
            this.FileName.Image = ((System.Drawing.Image)(resources.GetObject("FileName.Image")));
            this.FileName.Location = new System.Drawing.Point(6, 12);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(79, 60);
            this.FileName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.FileName, "Открыть файл");
            this.FileName.UseVisualStyleBackColor = true;
            this.FileName.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // FormAbout
            // 
            this.FormAbout.Image = global::Tyuiu.SugrovskiyNI.Sprint6.Task6.V25.Properties.Resources.question_icon_205993;
            this.FormAbout.Location = new System.Drawing.Point(1146, 6);
            this.FormAbout.Name = "FormAbout";
            this.FormAbout.Size = new System.Drawing.Size(80, 66);
            this.FormAbout.TabIndex = 0;
            this.toolTip1.SetToolTip(this.FormAbout, "Чтобы узнать автора программы");
            this.FormAbout.UseVisualStyleBackColor = true;
            this.FormAbout.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(0, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1229, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 21);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(1217, 54);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // textBoxLoadFromFile
            // 
            this.textBoxLoadFromFile.Location = new System.Drawing.Point(9, 181);
            this.textBoxLoadFromFile.Multiline = true;
            this.textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            this.textBoxLoadFromFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFromFile.Size = new System.Drawing.Size(608, 363);
            this.textBoxLoadFromFile.TabIndex = 2;
            // 
            // groupBoxOutPutData
            // 
            this.groupBoxOutPutData.Location = new System.Drawing.Point(622, 181);
            this.groupBoxOutPutData.Multiline = true;
            this.groupBoxOutPutData.Name = "groupBoxOutPutData";
            this.groupBoxOutPutData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.groupBoxOutPutData.Size = new System.Drawing.Size(601, 363);
            this.groupBoxOutPutData.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 87);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 457);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ввод данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вывод данных";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogTask";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBoxOutPutData);
            this.Controls.Add(this.textBoxLoadFromFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Такс 6| Вариант 25 | Сугровский Н.И";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button FileName;
        private System.Windows.Forms.Button FormAbout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxLoadFromFile;
        private System.Windows.Forms.TextBox groupBoxOutPutData;
        private System.Windows.Forms.Splitter splitter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

