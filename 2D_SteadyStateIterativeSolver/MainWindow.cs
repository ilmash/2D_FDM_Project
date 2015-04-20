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
        private Task task;
        private Result result;

        public MainWindow()
        {
            InitializeComponent();
            task = new Task();
            for (int i = 0; i < task.NodeTemp.GetLength(1); i++)
            {
                tgv.Columns.Add("", "");
                tgv.Columns[i].Width = 30;
                tgv.Rows.Add();
                tgv.Rows[i].Height = 20;
                tgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
            SetupDGV(task);
            TranslateToView(task);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupDGV(Task t)
        {
            for (int i = 0; i < t.NodeTemp.GetLength(0); i++)
            {
                for (int j = 0; j < t.NodeTemp.GetLength(1); j++)
                {
                    tgv[i, j].Style.BackColor = Color.White;
                }
            }
        }

        private void TranslateToView(Task t)
        {
            for (int i = 0; i < t.NodeTemp.GetLength(0); i++)
            {
                for (int j = 0; j < t.NodeTemp.GetLength(1); j++)
                {
                    tgv[i, j].Value = Math.Ceiling(t.NodeTemp[i, j]);
                    if (t.CellType[i, j] == 0)
                    {
                        tgv[i, j].Style.BackColor = Color.White;
                    }
                    else if (t.CellType[i, j] == 1)
                    {
                        tgv[i, j].Style.BackColor = Color.OrangeRed;
                    }
                    else if (t.CellType[i, j] == 2)
                    {
                        tgv[i, j].Style.BackColor = Color.PaleTurquoise;
                    }
                    else if (t.CellType[i, j] == 3)
                    {
                        tgv[i, j].Style.BackColor = Color.SpringGreen;
                    }
                    else
                    {
                        tgv[i, j].Style.BackColor = Color.Gray;
                    }
                }
            }
        }

        private void TranslateToTask(Task t)
        {
            task.Lambda = Double.Parse(tbLambda.Text);
            task.NodeDistance = Double.Parse(tbNodeDistance.Text);
            for (int i = 0; i < t.NodeTemp.GetLength(0); i++)
            {
                for (int j = 0; j < t.NodeTemp.GetLength(1); j++)
                {
                    t.NodeTemp[i, j] = Double.Parse(tgv[i, j].Value.ToString());
                    int BC;
                    if (tgv[i, j].Style.BackColor == Color.White)
                    {
                        BC = 0;
                    }
                    else if (tgv[i,j].Style.BackColor==Color.OrangeRed)
                    {
                        BC = 1;
                    }
                    else if (tgv[i,j].Style.BackColor==Color.PaleTurquoise)
                    {
                        BC = 2;
                    }
                    else if (tgv[i,j].Style.BackColor==Color.SpringGreen)
                    {
                        BC = 3;
                    }
                    else
                    {
                        BC = -1;
                    }
                    t.CellType[i, j] = BC;
                }
            }
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            TranslateToTask(task);
            return;
        }

        private void btnSetMaterial_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection SCC = tgv.SelectedCells;
            for (int i = 0; i < SCC.Count; i++)
            {
                SCC[i].Value = tbInitTempOptional.Text;
                SCC[i].Style.BackColor = Color.White;
            }
        }

        private void btnBC1_Click_1(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection SCC = tgv.SelectedCells;
            for (int i = 0; i < SCC.Count; i++)
            {
                SCC[i].Value = tbTemp.Text;
                SCC[i].Style.BackColor = Color.OrangeRed;
            }
        }

        private void btnBC2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection SCC = tgv.SelectedCells;
            for (int i = 0; i < SCC.Count; i++)
            {
                SCC[i].Value = tbNeumann.Text;
                SCC[i].Style.BackColor = Color.PaleTurquoise;
            }
        }

        private void btnBC3_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection SCC = tgv.SelectedCells;
            for (int i = 0; i < SCC.Count; i++)
            {
                SCC[i].Value = tbRobin.Text;
                SCC[i].Style.BackColor = Color.SpringGreen;
            }
        }

        private void btnSetVoid_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection SCC = tgv.SelectedCells;
            for (int i = 0; i < SCC.Count; i++)
            {
                SCC[i].Value = -1;
                SCC[i].Style.BackColor = Color.Gray;
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            TranslateToTask(task);
            result = new Result(task);
            result.Solve();
            TranslateToView(result);
        }

        private void fileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnLoadFile_Click_1(object sender, EventArgs e)
        {
            var dialogResult=fileDialog.ShowDialog();
        }

    }
}
