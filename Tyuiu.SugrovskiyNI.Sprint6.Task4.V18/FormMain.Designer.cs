
namespace Tyuiu.SugrovskiyNI.Sprint6.Task4.V18
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxStopStep = new System.Windows.Forms.TextBox();
            this.textBoxStartStep = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 106);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxStartStep);
            this.groupBox3.Controls.Add(this.textBoxStopStep);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(595, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 102);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ввод данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Конец шага:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Старт шага:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(1015, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 68);
            this.button4.TabIndex = 3;
            this.button4.Text = "Выполнить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSave.Location = new System.Drawing.Point(1110, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 68);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(1201, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Справка";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonHelp_Click_NI);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 102);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Улсовие";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(3, 21);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(570, 71);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 548);
            this.panel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxResult);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(252, 527);
            this.textBoxResult.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(261, 106);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 548);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // chartFunction
            // 
            this.chartFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction.Legends.Add(legend3);
            this.chartFunction.Location = new System.Drawing.Point(270, 0);
            this.chartFunction.Name = "chartFunction";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction.Series.Add(series3);
            this.chartFunction.Size = new System.Drawing.Size(1033, 548);
            this.chartFunction.TabIndex = 0;
            this.chartFunction.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.chartFunction);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 548);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBoxStopStep
            // 
            this.textBoxStopStep.Location = new System.Drawing.Point(222, 45);
            this.textBoxStopStep.Multiline = true;
            this.textBoxStopStep.Name = "textBoxStopStep";
            this.textBoxStopStep.Size = new System.Drawing.Size(152, 31);
            this.textBoxStopStep.TabIndex = 4;
            // 
            // textBoxStartStep
            // 
            this.textBoxStartStep.Location = new System.Drawing.Point(14, 45);
            this.textBoxStartStep.Multiline = true;
            this.textBoxStartStep.Name = "textBoxStartStep";
            this.textBoxStartStep.Size = new System.Drawing.Size(152, 31);
            this.textBoxStartStep.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 654);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Такс 4| Вариант 18 | Сугровский Н.И";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxStartStep;
        private System.Windows.Forms.TextBox textBoxStopStep;
    }
}

