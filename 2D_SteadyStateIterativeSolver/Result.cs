using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2D_SteadyStateIterativeSolver
{
    class Result : Task
    {
        new private int Size;
        private Task Iteration;

        public Result(Task t)
        {
            for (int i = 0; i < t.Size; i++)
            {
                for (int j = 0; j < t.Size; j++)
                {
                    NodeTemp[i, j] = t.NodeTemp[i, j];
                    CellType[i, j] = t.CellType[i, j];
                    Size = t.Size;
                    Lambda = t.Lambda;
                    NodeDistance = t.NodeDistance;
                }
            }
        }

        public void Solve()
        {
            int counter = 100;
            while (counter-- > 0)
            {
                Iteration = new Task(false);
                CopyOuters();
                for (int i = 1; i < Size - 1; i++)
                {
                    for (int j = 1; j < Size - 1; j++)
                    {
                        if (CellType[i, j] == (-1)) continue;
                        if (CellType[i, j] == 0)
                        {
                            //here, determine 4 values of local grid to compute node temperature
                            double[] nodes = new double[4];
                            nodes[0] = GetTopNode(i, j);
                            nodes[1] = GetBotNode(i, j);
                            nodes[2] = GetLeftNode(i, j);
                            nodes[3] = GetRightNode(i, j);
                            Iteration.NodeTemp[i, j] = 0.25 * nodes.Sum();
                        }
                        else Iteration.NodeTemp[i, j] = NodeTemp[i, j];
                    }
                }
                NodeTemp = Iteration.NodeTemp;
            }
        }

        private void CopyOuters()
        {
            for (int i = 0; i < Size; i++)
            {
                Iteration.NodeTemp[i, 0] = NodeTemp[i, 0];
                Iteration.NodeTemp[0, i] = NodeTemp[0, i];
                Iteration.NodeTemp[Size - 1, i] = NodeTemp[Size - 1, 0];
                Iteration.NodeTemp[i, Size - 1] = NodeTemp[0, Size - 1];
            }
        }

        private double GetTopNode(int i, int j)
        {
            int Type = CellType[i, j - 1];
            if (Type == 0 || Type == 1) return NodeTemp[i, j - 1];
            else if (Type == 2)
            {
                return ((2 * NodeDistance * NodeTemp[i, j - 1]) / Lambda) + NodeTemp[i, j + 1];
            }
            else return 0;
        }

        private double GetBotNode(int i, int j)
        {
            int Type = CellType[i, j + 1];
            if (Type == 0 || Type == 1) return NodeTemp[i, j + 1];
            else if (Type == 2)
            {
                return ((2 * NodeDistance * NodeTemp[i, j + 1]) / Lambda) + NodeTemp[i, j - 1];
            }
            else return 0;
        }

        private double GetLeftNode(int i, int j)
        {
            int Type = CellType[i - 1, j];
            if (Type == 0 || Type == 1) return NodeTemp[i - 1, j];
            else if (Type == 2)
            {
                return ((2 * NodeDistance * NodeTemp[i - 1, j]) / Lambda) + NodeTemp[i + 1, j];
            }
            else return 0;
        }

        private double GetRightNode(int i, int j)
        {
            int Type = CellType[i + 1, j];
            if (Type == 0 || Type == 1) return NodeTemp[i + 1, j];
            else if (Type == 2)
            {
                return ((2 * NodeDistance * NodeTemp[i + 1, j]) / Lambda) + NodeTemp[i - 1, j];
            }
            else return 0;
        }

    }
}
