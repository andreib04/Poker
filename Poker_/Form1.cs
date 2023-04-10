using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker_
{
    public partial class Form1 : Form
    {
        
        PictureBox[] cards = new PictureBox[5];
        Random rnd = new Random();
        int[] T = new int[5];
        
        public Form1()
        {
            InitializeComponent();
            cards[0] = pictureBox1;
            cards[1] = pictureBox2;
            cards[2] = pictureBox3;
            cards[3] = pictureBox4;
            cards[4] = pictureBox5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create();
        }

        //private void Create()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        cardPictureBox = new PictureBox();
                
        //        cardPictureBox.Width = 175;
        //        cardPictureBox.Height = 325;
        //        cardPictureBox.BorderStyle = BorderStyle.FixedSingle;
        //        cardPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        //        int x = (175 + 10) * i + 10;
        //        cardPictureBox.Location = new Point(x, 10);

        //        this.Controls.Add(cardPictureBox);
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox[] card = new PictureBox[5];
            for (int i = 0; i < 5; i++)
            {
                T[i] = rnd.Next(2, 15);
                ValueToCard(T[i], i);
            }
            label1.Text = IDxToFormation(Calculus());
        }

        private void ValueToCard(int x, int incr)
        {
            
            switch (x)
            {
                case 2:
                    cards[incr].Image = Poker_.Properties.Resources._2;
                    break;
                case 3:
                    cards[incr].Image = Poker_.Properties.Resources._3;
                    break;
                case 4:
                    cards[incr].Image = Poker_.Properties.Resources._4;
                    break;
                case 5:
                    cards[incr].Image = Poker_.Properties.Resources._5;
                    break;
                case 6:
                    cards[incr].Image = Poker_.Properties.Resources._6;
                    break;
                case 7:
                    cards[incr].Image = Poker_.Properties.Resources._7;
                    break;
                case 8:
                    cards[incr].Image = Poker_.Properties.Resources._8;
                    break;
                case 9:
                    cards[incr].Image = Poker_.Properties.Resources._9;
                    break;
                case 10:
                    cards[incr].Image = Poker_.Properties.Resources._10;
                    break;
                case 11:
                    cards[incr].Image = Poker_.Properties.Resources.ace;
                    break;
                case 12:
                    cards[incr].Image = Poker_.Properties.Resources.jack;
                    break;
                case 13:
                    cards[incr].Image = Poker_.Properties.Resources.king;
                    break;
                case 14:
                    cards[incr].Image = Poker_.Properties.Resources.queen;
                    break;
            }
            
        }
        public int Calculus()
        {
            int[] Nr = new int[15];
            for (int i = 0; i < T.Length; i++)
            {
                Nr[T[i]]++;
            }
            int max = 0;
            int np2 = 0;
            for (int i = 0; i < Nr.Length; i++)
            {
                if (Nr[i] > max)
                    max = Nr[i];
                if (Nr[i] == 2)
                    np2++;
            }
            if (max == 5)
                return 9;
            else if (max == 4)
                return 7;
            else if (max == 3 && np2 == 2)
                return 6;
            else if (max == 3)
                return 3;
            else if (max == 2 && np2 == 2)
                return 2;
            else if (max == 2)
                return 1;
            else if (max == 1)
                return 0;
            return -1;
        }

        public string IDxToFormation(int x)
        {
            switch (x)
            {
                case 0:
                    return "";
                case 1:
                    return "One pair";
                case 2:
                    return "Two pairs";
                case 3:
                    return "Three of a kind";
                case 4:
                    return "Straight";
                case 5:
                    return "Flush";
                case 6:
                    return "Full house";
                case 7:
                    return "Four of a kind";
                case 8:
                    return "Royal flush";
                case 9:
                    return "Five of a kind";
            }
            return "";
        }

    }
}