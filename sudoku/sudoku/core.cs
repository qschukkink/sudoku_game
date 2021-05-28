using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace sudoku
{
    class core
    {
        static Label[,] grid;
        static int gridSize = 9;

     internal static void makegrid(Panel Panel)
        {
            for (int R  = 0; R < gridSize; R++)
            {
                for (int C = 0; C < gridSize; C++)
                {
                    int PH = Panel.ClientSize.Height;
                    int PW = Panel.ClientSize.Width;
                    grid[R, C] = new Label();
                    grid[R, C].Size = new Size(9,9);
                    grid[R, C].Location = new Point(C * PW / gridSize, R * PH / gridSize);
                    grid[R, C].BackColor = Color.Gray;
                    Panel.Controls.Add(grid[R, C]);

                }
            }
        }
    }
}
