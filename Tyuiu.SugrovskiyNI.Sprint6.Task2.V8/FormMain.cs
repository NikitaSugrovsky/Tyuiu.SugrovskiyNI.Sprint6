using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SugrovskiyNI.Sprint6.Task2.V8.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint6.Task2.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            { 
            int startStep = Convert.ToInt32(textBoxStartStep.Text);
            int stopStep = Convert.ToInt32(textBoxStopStep.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            this.chartFunction.Titles.Add("График функции sin(x)");
            this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);

                startStep++;
            }
        }
          catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }



    private void chartFunction_Click(object sender, EventArgs e)
        {
            //
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }
        private void buttonDone_MouseDown(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-23-1 Cугровский Никита Игоревич ", "Сообщение");
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
