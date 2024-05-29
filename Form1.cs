using System;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private int player;
        private int counter;
        public Form1()
        {
            InitializeComponent();
            player = 1;
            counter = 0;
            label1.Text = "Игрок 1";
        }
        private void new_game()
        {
            counter = 0;
            label1.Text = "Игрок 1";
            player = 1;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        private bool check_win()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button2.Text != "")
            {
                MessageBox.Show("Поздравляем! Игрок " + player + " выиграл в этом раунде!");
                new_game();
                return true;
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button5.Text != "")
            {
                MessageBox.Show("Поздравляем! Игрок " + player + " выиграл в этом раунде!");
                new_game();
                return true;
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button8.Text != "")
            {
                MessageBox.Show("Поздравляем! Игрок " + player + " выиграл в этом раунде!");
                new_game();
                return true;
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button5.Text != "")
            {
                MessageBox.Show("Поздравляем! Игрок " + player + " выиграл в этом раунде!");
                new_game();
                return true;
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button5.Text != "")
            {
                MessageBox.Show("Поздравляем! Игрок " + player + " выиграл в этом раунде!");
                new_game();
                return true;
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button4.Text != "")
            {
                MessageBox.Show("Поздравляем! Игрок " + player + " выиграл в этом раунде!");
                new_game();
                return true;
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text != "")
            {
                MessageBox.Show("Поздравляем! Игрок " + player + " выиграл в этом раунде!");
                new_game();
                return true;
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button6.Text != "")
            {
                MessageBox.Show("Поздравляем! Игрок " + player + " выиграл в этом раунде!");
                new_game();
                return true;
            }
            if (counter == 9)
            {
                MessageBox.Show("Ничья! В этом раунде никто не выиграл :(");
                new_game();
                return true;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "X" ||  button1.Text == "O") 
            {
                return;
            }
            switch (player)
            {
                case 1:
                    counter++;
                    button1.Text = "X";
                    if (!(check_win()))
                    {
                        player = 2;
                        label1.Text = "Игрок 2";
                    }
                    break;
                case 2:
                    counter++;
                    button1.Text = "O";
                    if (!(check_win()))
                    {
                        player = 1;
                        label1.Text = "Игрок 1";
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "X" || button2.Text == "O")
            {
                return;
            }
            switch (player)
            {
                case 1:
                    counter++;
                    button2.Text = "X";
                    if (!(check_win()))
                    {
                        player = 2;
                        label1.Text = "Игрок 2";
                    }
                    break;
                case 2:
                    counter++;
                    button2.Text = "O";
                    if (!(check_win()))
                    {
                        player = 1;
                        label1.Text = "Игрок 1";
                    }
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "X" || button3.Text == "O")
            {
                return;
            }
            switch (player)
            {
                case 1:
                    counter++;
                    button3.Text = "X";
                    if (!(check_win()))
                    {
                        player = 2;
                        label1.Text = "Игрок 2";
                    }
                    break;
                case 2:
                    counter++;
                    button3.Text = "O";
                    if (!(check_win()))
                    {
                        player = 1;
                        label1.Text = "Игрок 1";
                    }
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "X" || button4.Text == "O")
            {
                return;
            }
            switch (player)
            {
                case 1:
                    counter++;
                    button4.Text = "X";
                    if (!(check_win()))
                    {
                        player = 2;
                        label1.Text = "Игрок 2";
                    }
                    break;
                case 2:
                    counter++;
                    button4.Text = "O";
                    if (!(check_win()))
                    {
                        player = 1;
                        label1.Text = "Игрок 1";
                    }
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "X" || button5.Text == "O")
            {
                return;
            }
            switch (player)
            {
                case 1:
                    counter++;
                    button5.Text = "X";
                    if (!(check_win()))
                    {
                        player = 2;
                        label1.Text = "Игрок 2";
                    }
                    break;
                case 2:
                    counter++;
                    button5.Text = "O";
                    if (!(check_win()))
                    {
                        player = 1;
                        label1.Text = "Игрок 1";
                    }
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "X" || button6.Text == "O")
            {
                return;
            }
            switch (player)
            {
                case 1:
                    counter++;
                    button6.Text = "X";
                    if (!(check_win()))
                    {
                        player = 2;
                        label1.Text = "Игрок 2";
                    }
                    break;
                case 2:
                    counter++;
                    button6.Text = "O";
                    if (!(check_win()))
                    {
                        player = 1;
                        label1.Text = "Игрок 1";
                    }
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "X" || button7.Text == "O")
            {
                return;
            }
            switch (player)
            {
                case 1:
                    counter++;
                    button7.Text = "X";
                    if (!(check_win()))
                    {
                        player = 2;
                        label1.Text = "Игрок 2";
                    }
                    break;
                case 2:
                    counter++;
                    button7.Text = "O";
                    if (!(check_win()))
                    {
                        player = 1;
                        label1.Text = "Игрок 1";
                    }
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "X" || button8.Text == "O")
            {
                return;
            }
            switch (player)
            {
                case 1:
                    counter++;
                    button8.Text = "X";
                    if (!(check_win()))
                    {
                        player = 2;
                        label1.Text = "Игрок 2";
                    }
                    break;
                case 2:
                    counter++;
                    button8.Text = "O";
                    if (!(check_win()))
                    {
                        player = 1;
                        label1.Text = "Игрок 1";
                    }
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "X" || button9.Text == "O")
            {
                return;
            }
            switch (player)
            {
                case 1:
                    counter++;
                    button9.Text = "X";
                    if (!(check_win()))
                    {
                        player = 2;
                        label1.Text = "Игрок 2";
                    }
                    break;
                case 2:
                    counter++;
                    button9.Text = "O";
                    if (!(check_win()))
                    {
                        player = 1;
                        label1.Text = "Игрок 1";
                    }
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new_game();
        }
    }
}
