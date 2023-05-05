using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelsRaiosGroupBoxDinamicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            VScrollBar vScrollBar = new VScrollBar();
            vScrollBar.Dock = DockStyle.Right;
            Controls.Add(vScrollBar);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            int xGB = 50;
            int yGB = 80;

            int xRB = 50;
            int yRB = 80;

            Point positionGB = new Point(xGB, yGB);

            List<GroupBox> listGB = new List<GroupBox>();
            List<RadioButton> listRB = new List<RadioButton>();


            for (int i = 1; i <= 2; i++)
            {
                GroupBox newGB = new GroupBox();

                newGB.Name = "GroupBox-" + i;
                newGB.BackColor = Color.FromArgb(79, 239, 255);
                newGB.ForeColor = Color.Maroon;
                newGB.Text = "GroupBox-" + i;
                newGB.Font = new Font("Georgia", 12);
                newGB.FlatStyle = FlatStyle.Flat;
                newGB.Width = 650;
                newGB.Height = 150;
                this.Controls.Add(newGB);
                newGB.Location = new Point(xGB, yGB += 170);

                listGB.Add(newGB);

                Console.WriteLine("*GB\n");

                for (int j = 1; j <= 4; j++)
                {
                    RadioButton rdbtn = new RadioButton();

                    rdbtn.Name = "Radio-" + j;
                    rdbtn.Text = "Radio-" + j;
                    newGB.Controls.Add(rdbtn);
                    rdbtn.Location = new Point(xRB += 105, yRB);

                    listRB.Add(rdbtn);

                    Console.WriteLine("RB");

                }

                xRB = 50;
                Console.WriteLine("\n========\n");


            }

            Console.WriteLine("FIN de la creacion de controles\n");

            Console.WriteLine("Lectura de controles dinamicos:");

            foreach (Control gb in listGB)
            {
                foreach (Control rb in listRB)
                {
                    Console.WriteLine("GB.Name = " + gb.Name + ". RB.Name = " + rb.Name);
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("groupBox1.Name = " + groupBox1.Name.ToString());

            Console.WriteLine("\nradioButton3.Name = " + rbt88.Name.ToString());

            Console.WriteLine("\ngroupBox1.Controls.Count = " + groupBox1.Controls.Count);

            Console.WriteLine("=================");
            foreach (Control control in groupBox1.Controls)
            {
                Console.WriteLine("control.Name = " + control.Name.ToString());
            }





        }
    }
}
