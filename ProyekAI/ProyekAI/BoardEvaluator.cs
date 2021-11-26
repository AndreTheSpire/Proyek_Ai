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
        int[,] setMoves = new int[,] {
            {0,1}, {0,-1}, {1,0}, {-1,0},
            {0,2}, {0,-2}, {2,0}, {-2,0},
            {1,1}, {-1,-1}, {-1,1}, {1,-1},
            {2,2}, {-2,-2}, {-2,2}, {2,-2}
        };

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

        public int threatenedStones(List<Stone> stones, int side)
        {
            int opp = 0;
            if (side == 0)
            {
                opp = 1;
            }
            int point = 0;
            foreach (Stone s in stones)
            {
                if (s.side == side)
                {
                    for(int i=0; i<16; i++)
                    {
                        int cekX = s.x + setMoves[i, 0];
                        int cekY = s.y + setMoves[i, 1];

                        foreach(Stone opponentStone in stones)
                        {
                            if (opponentStone.side == opp && opponentStone.x == cekX && opponentStone.y == cekY)
                            {
                                point++;
                            }
                        }

                    }
                }
            }
            return point;
        }


        public int possiblePassiveMoves()
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
