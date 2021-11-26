using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyekAI
{
    class BoardEvaluator
    {
        
        public int stoneCount(List<Stone> stones, int side)
        {

            int stone = 0;

            foreach(Stone s in stones)
            {
                if(s.x<4 && s.x>=0 && s.y < 4 && s.y >= 0)
                {
                    if (s.side == side)
                    {
                        stone++;
                    }
                }
            }

            return stone;
        }



        public int possibleMoves()
        {
            return 0;
        }

        public void changePanel()
        {
            Panel p = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
            p.Visible = false;
        }

    }
}
