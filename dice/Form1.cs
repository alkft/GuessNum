﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dice
{
    public partial class Form1 : Form
    {
        //private int GuessNum = new Random().Next(100);
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            /*
            try
            {
                int randomNum = new Random().Next(5) + 1;

                string num = tb_input.Text;
                int input_num = int.Parse(num);
                if (input_num > GuessNum)
                {
                    MessageBox.Show("太大", "", MessageBoxButtons.OK);
                }
                if (input_num < GuessNum)
                {
                    MessageBox.Show("太小", "", MessageBoxButtons.OK);
                }
                if (input_num == GuessNum)
                {
                    MessageBox.Show("猜對", "", MessageBoxButtons.OK);
                }


            }
            catch (Exception)
            {
                string message = "";

                string caption = "TEST";
                DialogResult result;

                result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                }
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //messagebox();
                }
            } 
            */

        }
        void messagebox()
        {
            int randomNum = new Random().Next(5) + 1;

            string message = randomNum.ToString();
            DialogResult result;
            result = MessageBox.Show(message, "TEST", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                messagebox();
            }
            if (result == System.Windows.Forms.DialogResult.No)
            {
                this.Close();
            }
        }

        private void Rtb_show_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_text_Click(object sender, EventArgs e)
        {
            Poker p =new Poker();

            List<int> poker = p.GetPoker(52);

            string msg = "";

            for(int i=0;i<poker.Count;i++)
            {
                msg += $"{poker[i]},";
            }
            rtb_show.Text = msg + "\n";
        }

    }
}
