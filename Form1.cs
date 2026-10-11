namespace Tic_Tac_Tok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            pen.Width = 10;
            //draw Horizental lines
           // e.Graphics.DrawLine(pen, 600, 300, 1050, 300);
           // e.Graphics.DrawLine(pen, 600, 460, 1050, 460);

            //draw Vertical lines
           // e.Graphics.DrawLine(pen, 610, 140, 610, 620);
           // e.Graphics.DrawLine(pen, 840, 140, 840, 620);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (x == true)
                {
                    button1.Image = Properties.Resources.x;
                    button1.Tag = "x";
                }
                else if (y == true) { 
                    button1.Image = Properties.Resources.o;
                    button1.Tag = "o";
                }
                checkWinner();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button2.Image = Properties.Resources.x;
                button2.Tag = "x";
            }
            else if (y == true)
            {
                button2.Image = Properties.Resources.o;
                button2.Tag = "o";

            }
            checkWinner();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            if (x == true)
            {
                button3.Image = Properties.Resources.x;
                button3.Tag = "x";
            }
            else if (y == true)
            {
                button3.Image = Properties.Resources.o;
                button3.Tag = "o";
            }
                checkWinner();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int i = 9;
        int j = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button6.Image = Properties.Resources.x;
                button6.Tag = "x";
            }
            else if (y == true) {
                button6.Image = Properties.Resources.o;
                button6.Tag = "o";
                    }
          
                checkWinner();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button5.Image = Properties.Resources.x;
                button5.Tag = "x";
            }
            else if (y == true)
            { 
            button5.Image = Properties.Resources.o;
            button5.Tag = "o"; 
            }
            checkWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button4.Image = Properties.Resources.x;
                button4.Tag = "x";
            }
            else if (y == true)
            { 
            button4.Image = Properties.Resources.o;
            button4.Tag = "o";
            }
            checkWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button9.Image = Properties.Resources.x;
                button9.Tag = "x";
            }
            else if (y == true)
            {
                button9.Image = Properties.Resources.o;
                button9.Tag = "o";
            }
            checkWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (x == true)
            { 
                button8.Image = Properties.Resources.x;
                button8.Tag = "x";
            }
            else if (y == true)
            {
                button8.Image = Properties.Resources.o;
                button8.Tag = "o";
            }
            checkWinner();       
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                button7.Image = Properties.Resources.x;
                button7.Tag = "x";
            }
            else if (y == true)
            {
                button7.Image = Properties.Resources.o;
                button7.Tag = "o";
            }
            checkWinner();
        }
        bool x = false;
        bool y = false;

        private void label_pl1_Click(object sender, EventArgs e)
        {
            x = true;
        }

        private void label_pl2_Click(object sender, EventArgs e)
        {
            y = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = true;
            y = false;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            y = true;
            x = false;

        }

        private void restart_Click(object sender, EventArgs e)
        {
            button7.Image = Properties.Resources.s;
            button8.Image = Properties.Resources.s;
            button9.Image = Properties.Resources.s;
            button1.Image = Properties.Resources.s; 
            button2.Image = Properties.Resources.s;
            button3.Image = Properties.Resources.s;
            button4.Image = Properties.Resources.s;
            button5.Image = Properties.Resources.s;
            button6.Image = Properties.Resources.s;

            button1.Tag = "s";
            button2.Tag = "s";
            button3.Tag = "s";
            button4.Tag = "s";
            button5.Tag = "s";
            button6.Tag = "s";
            button7.Tag = "s";
            button8.Tag = "s";
            button9.Tag = "s";

        }
        public bool CheckValue(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag == "x" && btn2.Tag  == "x" && btn3.Tag == "x")
            {
                MessageBox.Show("Player 1 Wins!");
                return true;
            }
            else if ((btn1.Tag == "o" && btn2.Tag == "o" && btn3.Tag == "o"))
            {
                MessageBox.Show("Player 2 Wins!");
                return true;
            }
            return false;
        }
        public void checkWinner()
        {
            if (CheckValue(button1, button2, button3)) 
            return;
            if (CheckValue(button4, button5, button6)) 
            return;
            if (CheckValue(button7, button8, button9))
                return;
            if (CheckValue(button1, button6, button9))
                return;
            if (CheckValue(button3, button4, button7))
                return;
            if (CheckValue(button2, button5, button8))
                return;
            if (CheckValue(button1, button5, button7))
                return;
            if (CheckValue(button3, button5, button9))
                return;

        }
    }
}
