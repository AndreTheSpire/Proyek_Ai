using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyekAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            createLabel(panel1);
            createLabel(panel2);
            createLabel(panel3);
            createLabel(panel4);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void createLabel(Panel panelx)
        {
            int x = 0, y = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Label l = new Label();
                    l.Size = new Size(100, 100);

                    l.Location = new Point(x, y);
                    if()

                    panelx.Controls.Add(l);
                    x += 100;
                }
                x = 0;
                y += 100;
            }
        }
    }
}
