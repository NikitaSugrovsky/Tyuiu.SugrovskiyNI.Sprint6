using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SugrovskiyNI.Sprint6.Task5.V21.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint6.Task5.V21
{

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V21.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].Width = 20;
            dataGridViewNums.Columns[1].Width = 50;

            this.numsMas.ChartAreas[0].AxisX.Title = "Ось Х";
            this.numsMas.ChartAreas[0].AxisY.Title = "Ось Y";

            this.numsMas.Series[0].Points.Clear();

            double[] numsMas = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMas.Length; i++)
            {
                dataGridViewNums.Rows.Add(i, numsMas[i]);
                this.numsMas.Series[0].Points.AddXY(i, numsMas[i]);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click_NI(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-23-1 Cугровский Никита Игоревич ", "Сообщение");
        }
    }
}

