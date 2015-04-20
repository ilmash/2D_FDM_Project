using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_SteadyStateIterativeSolver
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Task task = new Task();
            for (int i = 0; i < task.NodeTemp.GetLength(1); i++)
            {
                tgv.Columns.Add("", "");
                tgv.Columns[i].Width = 30;
                tgv.Rows.Add();
                tgv.Rows[i].Height=20;
            }
            TranslateToView(task);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TranslateToView(Task t)
        {
            for (int i = 0; i < t.NodeTemp.GetLength(1); i++)
            {
                for (int j = 0; j < t.NodeTemp.GetLength(0); j++)
                {
                    tgv[i, j].Value = Math.Ceiling(t.NodeTemp[i,j]);
                }
            }
        }
    }
}
