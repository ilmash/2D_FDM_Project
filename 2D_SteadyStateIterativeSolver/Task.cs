using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_SteadyStateIterativeSolver
{
    class Task
    {
        public int[,] CellType { get; set; }
        public double[,] NodeTemp { get; set; }

        public Task()
        {
            CellType = new int[20, 20];
            NodeTemp = new double[20, 20];
            getrandom();
        }

        private void getrandom()
        {
            Random qq=new Random();
            for(int i=0;i<NodeTemp.GetLength(0);i++)
                for (int j = 0; j < NodeTemp.GetLength(1); j++)
                {
                    NodeTemp[i, j] = qq.NextDouble() * 10.0;
                }
        }

        public Task(int size)
        {
            CellType = new int[size, size];
            NodeTemp = new double[size, size];
        }
    }
}
