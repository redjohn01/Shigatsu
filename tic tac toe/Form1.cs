using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if ((button1.Text == "") && (i % 2 == 0))
            {
                i++;
                button1.Text = "X";
            }
            else if ((button1.Text == "") && (i % 2 == 0))
            {
                i++;
                button1.Text = "O";
            }
            if ((button1.Text == button2.Text) && (button1.Text == button3.Text) && (button1.Text !=""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button1.Text == button4.Text) && (button1.Text == button7.Text) && (button1.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button1.Text == button5.Text) && (button1.Text == button9.Text) && (button1.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((button2.Text == "") && (i % 2 == 0))
            {
                i++;
                button2.Text = "X";
            }
            else if ((button2.Text == "") && (i % 2 == 1))
            {
                i++;
                button2.Text = "O";
            }
            if ((button1.Text == button2.Text) && (button1.Text == button3.Text) && (button2.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button2.Text == button5.Text) && (button2.Text == button8.Text) && (button2.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if ((button3.Text == "") && (i % 2 == 0))
            {
                i++;
                button3.Text = "X";
            }
            else if ((button3.Text == "") && (i % 2 == 1))
            {
                i++;
                button3.Text = "O";
            }
            if ((button1.Text == button2.Text) && (button1.Text == button3.Text) && (button3.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button3.Text == button6.Text) && (button3.Text == button9.Text) && (button3.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button3.Text == button5.Text) && (button3.Text == button7.Text) && (button3.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if ((button4.Text == "") && (i % 2 == 0))
            {
                i++;
                button4.Text = "X";
            }
            else if ((button4.Text == "") && (i % 2 == 1))
            {
                i++;
                button4.Text = "O";
            }
            if ((button4.Text == button5.Text) && (button4.Text == button6.Text) && (button4.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (button4.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if ((button5.Text == "") && (i % 2 == 0))
            {
                i++;
                button5.Text = "X";
            }
            else if ((button5.Text == "") && (i % 2 == 1))
            {
                i++;
                button5.Text = "O";
            }
            if ((button4.Text == button5.Text) && (button4.Text == button6.Text) && (button5.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (button5.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button5.Text == button1.Text) && (button5.Text == button9.Text) && (button5.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button5.Text == button3.Text) && (button5.Text == button7.Text) && (button5.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if ((button6.Text == "") && (i % 2 == 0))
            {
                i++;
                button6.Text = "X";
            }
            else if ((button6.Text == "") && (i % 2 == 1))
            {
                i++;
                button6.Text = "O";
            }
            if ((button4.Text == button5.Text) && (button4.Text == button6.Text) && (button6.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button6.Text == button3.Text) && (button6.Text == button9.Text) && (button6.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if ((button7.Text == "") && (i % 2 == 0))
            {
                i++;
                button7.Text = "X";
            }
            else if ((button7.Text == "") && (i % 2 == 1))
            {
                i++;
                button7.Text = "O";
            }
            if ((button7.Text == button8.Text) && (button7.Text == button9.Text) && (button7.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button7.Text == button4.Text) && (button7.Text == button1.Text) && (button7.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button5.Text == button7.Text) && (button7.Text == button3.Text) && (button7.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if ((button8.Text == "") && (i % 2 == 0))
            {
                i++;
                button8.Text = "X";
            }
            else if ((button8.Text == "") && (i % 2 == 1))
            {
                i++;
                button8.Text = "O";
            }
            if ((button7.Text == button8.Text) && (button7.Text == button9.Text) && (button8.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button8.Text == button5.Text) && (button8.Text == button2.Text) && (button8.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if ((button9.Text == "") && (i % 2 == 0))
            {
                i++;
                button9.Text = "X";
            }
            else if ((button9.Text == "") && (i % 2 == 1))
            {
                i++;
                button9.Text = "O";
            }
            if ((button9.Text == button5.Text) && (button9.Text == button1.Text) && (button9.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button9.Text == button6.Text) && (button9.Text == button3.Text) && (button9.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
            if ((button9.Text == button8.Text) && (button9.Text == button7.Text) && (button9.Text != ""))
            {
                if ((i - 1) % 2 == 0) MessageBox.Show("X wins");
                else MessageBox.Show("O wins");
                this.Close();
            }
        }
    }
}