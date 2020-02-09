using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {
        int scor = 0;
        int gata = 1;
        int gata2 = 1;
        int nrrunde = -1;
        int i = 1;
        int d;
        int t1;  int t2;   int t3;
        int t4; int t5; int t6;
        int nralb = 49;
        int nrgol = 49;
        int ok;
        int a1 = 0;
        int a2 = 0; int a3 = 0; int a4 = 0;
        int a5 = 0;  int a6 = 0; int a7 = 0;
        int a8 = 0;int a9 = 0; int a10 = 0;
        int a11 = 0; int a12 = 0;  int a13 = 0;
        int a14 = 0; int a15 = 0; int a16 = 0;


        int nr1 = 1;
        int nr2 = 1;  int nr3 = 1; int nr4 = 1;
        int nr5 = 1;  int nr6 = 1; int nr7 = 1;
        int nr8 = 1; int nr9 = 1; int nr10 = 1;
        int nr11 = 1;   int nr12 = 1; int nr13 = 1;
        int nr14 = 1; int nr15 = 1; int nr16 = 1;
        int nr17 = 1;int nr18 = 1; int nr19 = 1;
        int nr20 = 1; int nr21 = 1;int nr22 = 1;
        int nr23 = 1; int nr24 = 1;int nr25 = 1;
        int nr26 = 1; int nr27 = 1;int nr28 = 1;
        int nr29 = 1;  int nr30 = 1; int nr31 = 1;
        int nr32 = 1; int nr33 = 1; int nr34 = 1;
        int nr35 = 1; int nr36 = 1; int nr37 = 1;
        int nr38 = 1;  int nr39 = 1; int nr40 = 1;
        int nr41 = 1;  int nr42 = 1; int nr43 = 1;
        int nr44 = 1; int nr45 = 1; int nr46 = 1;
        int nr47 = 1; int nr48 = 1;  int nr49 = 1;

        int[] y;
        int sc;
        string linie;
        

        private void scrie_fisier(int nr,int q)
        {
            if (nr == 1)
            {
                if (q > sc)
                {
                    StreamWriter fout = new StreamWriter("scorT1.out");

                    fout.WriteLine(q);
                    fout.Close();
                }
            }
        }
        private void citire_fisier(int nr)
        {
            if (nr == 1)
            {
                StreamReader fin = new StreamReader("scorT1.out"); 
                linie = fin.ReadLine();
                 sc = int.Parse(linie);
                fin.Close();
                label49.Text = linie; 
            }
        }


        public Form1()
        {
 InitializeComponent();
            citire_fisier(1);
           

        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nr1!=0&&gata2==1){
                if (t1 == 1 || t2 == 1 || t3 == 1 || t4 == 1 || t5 == 1 || t6 == 1)
                {
                    if (t1 == 1) { label45.Text = " "; t1 = 0; button1.BackColor = button51.BackColor; }
                    else
                        if (t2 == 1) { label44.Text = " "; t2 = 0; button1.BackColor = button51.BackColor; }
                        else
                            if (t3 == 1) { label43.Text = " "; t3 = 0; button1.BackColor = button51.BackColor; }
                            else
                                if (t4 == 1) { label42.Text = " "; t4 = 0; button1.BackColor = button51.BackColor; }
                                else
                                    if (t5 == 1) { label41.Text = " "; t5 = 0; button1.BackColor = button51.BackColor; }
                                    else
                                        if (t6 == 1) { label40.Text = " "; t6 = 0; button1.BackColor = button51.BackColor; }
                }
                else
                {

                    if (t1 == 0) { label45.Text = "1"; t1 = 1; button1.BackColor = button52.BackColor; }
                    else
                        if (t2 == 0) { label44.Text = "1"; t2 = 1; button1.BackColor = button52.BackColor; }
                        else
                            if (t3 == 0) { label43.Text = "1"; t3 = 1; button1.BackColor = button52.BackColor; }
                            else
                                if (t4 == 0) { label42.Text = "1"; t4 = 1; button1.BackColor = button52.BackColor; }
                                else
                                    if (t5 == 0) { label41.Text = "1"; t5 = 1; button1.BackColor = button52.BackColor; }
                                    else
                                        if (t6 == 0) { label40.Text = "1"; t6 = 1; button1.BackColor = button52.BackColor; }
                }
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (nr44 != 0 && gata2 == 1)
            {
                var c = 44;
                string z = "44";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button44.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button44.BackColor = button52.BackColor;
                }
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (nr45 != 0 && gata2 == 1)
            {
                var c = 45;
                string z = "45";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button45.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button45.BackColor = button52.BackColor;
                }
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (nr46 != 0 && gata2 == 1)
            {
                var c = 46;
                string z = "46";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button46.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button46.BackColor = button52.BackColor;
                }
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (nr47 != 0 && gata2 == 1)
            {
                var c = 47;
                string z = "47";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button47.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button47.BackColor = button52.BackColor;
                }
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (nr48 != 0 && gata2 == 1)
            {
                var c = 48;
                string z = "48";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button48.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button48.BackColor = button52.BackColor;
                }
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (nr49 != 0 && gata2 == 1)
            {
                var c = 49;
                string z = "49";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button49.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button49.BackColor = button52.BackColor;
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (nr29 != 0 && gata2 == 1)
            {
                var c = 29;
                string z = "29";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button29.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button29.BackColor = button52.BackColor;
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (nr30 != 0 && gata2 == 1)
            {
                var c = 30;
                string z = "30";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button30.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button30.BackColor = button52.BackColor;
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (nr31 != 0 && gata2 == 1)
            {
                var c = 31;
                string z = "31";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button31.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button31.BackColor = button52.BackColor;
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (nr32 != 0 && gata2 == 1)
            {
                var c = 32;
                string z = "32";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button32.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button32.BackColor = button52.BackColor;
                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (nr33 != 0 && gata2 == 1)
            {
                var c = 33;
                string z = "33";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button33.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button33.BackColor = button52.BackColor;
                }
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (nr34 != 0 && gata2 == 1)
            {
                var c = 34;
                string z = "34";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button34.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button34.BackColor = button52.BackColor;
                }
            }
        }
        private void button35_Click(object sender, EventArgs e)
        {
            if (nr35 != 0 && gata2 == 1)
            {
                var c = 35;
                string z = "35";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button35.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button35.BackColor = button52.BackColor;
                }
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (nr36 != 0 && gata2 == 1)
            {
                var c = 36;
                string z = "36";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button36.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button36.BackColor = button52.BackColor;
                }
            }
        }
        private void button37_Click(object sender, EventArgs e)
        {
            if (nr37 != 0 && gata2 == 1)
            {
                var c = 37;
                string z = "37";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button37.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button37.BackColor = button52.BackColor;
                }
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (nr38 != 0 && gata2 == 1)
            {
                var c = 38;
                string z = "38";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button38.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button38.BackColor = button52.BackColor;
                }
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (nr39 != 0 && gata2 == 1)
            {
                var c = 39;
                string z = "39";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button39.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button39.BackColor = button52.BackColor;
                }
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (nr40 != 0 && gata2 == 1)
            {
                var c = 40;
                string z = "40";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button40.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button40.BackColor = button52.BackColor;
                }
            }
        }
        private void button41_Click(object sender, EventArgs e)
        {
            if (nr41 != 0 && gata2 == 1)
            {
                var c = 41;
                string z = "41";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button41.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button41.BackColor = button52.BackColor;
                }
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (nr42 != 0 && gata2 == 1)
            {
                var c = 42;
                string z = "42";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button42.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button42.BackColor = button52.BackColor;
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (nr22 != 0 && gata2 == 1)
            {
                var c = 22;
                string z = "22";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button22.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button22.BackColor = button52.BackColor;
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (nr23 != 0 && gata2 == 1)
            {
                var c = 23;
                string z = "23";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button23.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button23.BackColor = button52.BackColor;
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (nr24 != 0 && gata2 == 1)
            {
                var c = 24;
                string z = "24";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button24.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button24.BackColor = button52.BackColor;
                }
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            if (nr25 != 0 && gata2 == 1)
            {
                var c = 25;
                string z = "25";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button25.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button25.BackColor = button52.BackColor;
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (nr26 != 0 && gata2 == 1)
            {
                var c = 26;
                string z = "26";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button26.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button26.BackColor = button52.BackColor;
                }
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            if (nr27 != 0 && gata2 == 1)
            {
                var c = 27;
                string z = "27";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button27.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button27.BackColor = button52.BackColor;
                }
            }
        }
        private void button28_Click(object sender, EventArgs e)
        {
            if (nr28 != 0 && gata2 == 1)
            {
                var c = 28;
                string z = "28";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button28.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button28.BackColor = button52.BackColor;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (nr15 != 0 && gata2 == 1)
            {
                var c = 15;
                string z = "15";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button15.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button15.BackColor = button52.BackColor;
                }
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (nr16 != 0 && gata2 == 1)
            {
                var c = 16;
                string z = "16";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button16.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button16.BackColor = button52.BackColor;
                }
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (nr17 != 0 && gata2 == 1)
            {
                var c = 17;
                string z = "17";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button17.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button17.BackColor = button52.BackColor;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (nr18 != 0 && gata2 == 1)
            {
                var c = 18;
                string z = "18";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button18.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button18.BackColor = button52.BackColor;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (nr19 != 0 && gata2 == 1)
            {
                var c = 19;
                string z = "19";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button19.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button19.BackColor = button52.BackColor;
                }
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (nr20 != 0 && gata2 == 1)
            {
                var c = 20;
                string z = "20";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button20.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button20.BackColor = button52.BackColor;
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (nr21 != 0 && gata2 == 1)
            {
                var c = 21;
                string z = "21";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button21.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button21.BackColor = button52.BackColor;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (nr8 != 0 && gata2 == 1)
            {
                var c = 8;
                string z = "8";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button8.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button8.BackColor = button52.BackColor;
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (nr9 != 0 && gata2 == 1)
            {
                var c = 9;
                string z = "9";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button9.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button9.BackColor = button52.BackColor;
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (nr10 != 0 && gata2 == 1)
            {
                var c = 10;
                string z = "10";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button10.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button10.BackColor = button52.BackColor;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (nr11 != 0 && gata2 == 1)
            {
                var c = 11;
                string z = "11";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button11.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button11.BackColor = button52.BackColor;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (nr12 != 0 && gata2 == 1)
            {
                var c = 12;
                string z = "12";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button12.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button12.BackColor = button52.BackColor;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (nr13 != 0 && gata2 == 1)
            {
                var c = 13;
                string z = "13";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button13.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button13.BackColor = button52.BackColor;
                }
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (nr14 != 0 && gata2 == 1)
            {
                var c = 14;
                string z = "14";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button14.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button14.BackColor = button52.BackColor;
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (nr7 != 0 && gata2 == 1)
            {
                var c = 7;
                string z = "7";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button7.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button7.BackColor = button52.BackColor;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (nr6 != 0 && gata2 == 1)
            {
                var c = 6;
                string z = "6";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button6.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button6.BackColor = button52.BackColor;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nr5 != 0 && gata2 == 1)
            {
                var c = 5;
                string z = "5";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button5.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button5.BackColor = button52.BackColor;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (nr4 != 0 && gata2 == 1)
            {
                var c = 4;
                string z = "4";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button4.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button4.BackColor = button52.BackColor;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nr3 != 0 && gata2 == 1)
            {
                var c = 3;
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; button3.BackColor = button51.BackColor; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; button3.BackColor = button51.BackColor; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; button3.BackColor = button51.BackColor; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; button3.BackColor = button51.BackColor; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; button3.BackColor = button51.BackColor; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; button3.BackColor = button51.BackColor; }
                }
                else
                {

                    if (t1 == 0) { label45.Text = "3"; t1 = c; button3.BackColor = button52.BackColor; }
                    else
                        if (t2 == 0) { label44.Text = "3"; t2 = c; button3.BackColor = button52.BackColor; }
                        else
                            if (t3 == 0) { label43.Text = "3"; t3 = c; button3.BackColor = button52.BackColor; }
                            else
                                if (t4 == 0) { label42.Text = "3"; t4 = c; button3.BackColor = button52.BackColor; }
                                else
                                    if (t5 == 0) { label41.Text = "3"; t5 = c; button3.BackColor = button52.BackColor; }
                                    else
                                        if (t6 == 0) { label40.Text = "3"; t6 = c; button3.BackColor = button52.BackColor; }

                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (nr2 != 0 && gata2 == 1)
            {
                if (t1 == 2 || t2 == 2 || t3 == 2 || t4 == 2 || t5 == 2 || t6 == 2)
                {
                    if (t1 == 2) { label45.Text = " "; t1 = 0; button2.BackColor = button51.BackColor; }
                    else
                        if (t2 == 2) { label44.Text = " "; t2 = 0; button2.BackColor = button51.BackColor; }
                        else
                            if (t3 == 2) { label43.Text = " "; t3 = 0; button2.BackColor = button51.BackColor; }
                            else
                                if (t4 == 2) { label42.Text = " "; t4 = 0; button2.BackColor = button51.BackColor; }
                                else
                                    if (t5 == 2) { label41.Text = " "; t5 = 0; button2.BackColor = button51.BackColor; }
                                    else
                                        if (t6 == 2) { label40.Text = " "; t6 = 0; button2.BackColor = button51.BackColor; }
                }
                else
                {

                    if (t1 == 0) { label45.Text = "2"; t1 = 2; button2.BackColor = button52.BackColor; }
                    else
                        if (t2 == 0) { label44.Text = "2"; t2 = 2; button2.BackColor = button52.BackColor; }
                        else
                            if (t3 == 0) { label43.Text = "2"; t3 = 2; button2.BackColor = button52.BackColor; }
                            else
                                if (t4 == 0) { label42.Text = "2"; t4 = 2; button2.BackColor = button52.BackColor; }
                                else
                                    if (t5 == 0) { label41.Text = "2"; t5 = 2; button2.BackColor = button52.BackColor; }
                                    else
                                        if (t6 == 0) { label40.Text = "2"; t6 = 2; button2.BackColor = button52.BackColor; }

                }
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (nr43 != 0 && gata2 == 1)
            {
                var c = 43;
                string z = "43";
                if (t1 == c || t2 == c || t3 == c || t4 == c || t5 == c || t6 == c)
                {
                    if (t1 == c) { label45.Text = " "; t1 = 0; }
                    else
                        if (t2 == c) { label44.Text = " "; t2 = 0; }
                        else
                            if (t3 == c) { label43.Text = " "; t3 = 0; }
                            else
                                if (t4 == c) { label42.Text = " "; t4 = 0; }
                                else
                                    if (t5 == c) { label41.Text = " "; t5 = 0; }
                                    else
                                        if (t6 == c) { label40.Text = " "; t6 = 0; }
                    button43.BackColor = button51.BackColor;
                }
                else if (t1 == 0 || t2 == 0 || t3 == 0 || t4 == 0 || t5 == 0 || t6 == 0)
                {

                    if (t1 == 0) { label45.Text = z; t1 = c; }
                    else
                        if (t2 == 0) { label44.Text = z; t2 = c; }
                        else
                            if (t3 == 0) { label43.Text = z; t3 = c; }
                            else
                                if (t4 == 0) { label42.Text = z; t4 = c; }
                                else
                                    if (t5 == 0) { label41.Text = z; t5 = c; }
                                    else
                                        if (t6 == 0) { label40.Text = z; t6 = c; }
                    button43.BackColor = button52.BackColor;
                }
            }
        }

        private void label13_Click(object sender, System.EventArgs e)
        {

        }
        private void bifeaza_ca_negru(int nr)
        {
            if (nr == 1) nr1 = 0;
            if (nr == 2) nr2 = 0;
            if (nr == 3) nr3 = 0;
            if (nr == 4) nr4 = 0;
            if (nr == 5) nr5 = 0;
            if (nr == 6) nr6 = 0;
            if (nr == 7) nr7 = 0;
            if (nr == 8) nr8 = 0;
            if (nr == 9) nr9 = 0;
            if (nr == 10) nr10 = 0;

            if (nr == 11) nr11 = 0;
            if (nr == 12) nr12 = 0;
            if (nr == 13) nr13 = 0;
            if (nr == 14) nr14 = 0;
            if (nr == 15) nr15 = 0;
            if (nr == 16) nr16 = 0;
            if (nr == 17) nr17 = 0;
            if (nr == 18) nr18 = 0;
            if (nr == 19) nr19 = 0;
            if (nr == 20) nr20 = 0;

            if (nr == 21) nr21 = 0;
            if (nr == 22) nr22 = 0;
            if (nr == 23) nr23 = 0;
            if (nr == 24) nr24 = 0;
            if (nr == 25) nr25 = 0;
            if (nr == 26) nr26 = 0;
            if (nr == 27) nr27 = 0;
            if (nr == 28) nr28 = 0;
            if (nr == 29) nr29 = 0;
            if (nr == 30) nr30 = 0;

            if (nr == 31) nr31 = 0;
            if (nr == 32) nr32 = 0;
            if (nr == 33) nr33 = 0;
            if (nr == 34) nr34 = 0;
            if (nr == 35) nr35 = 0;
            if (nr == 36) nr36 = 0;
            if (nr == 37) nr37 = 0;
            if (nr == 38) nr38 = 0;
            if (nr == 39) nr39 = 0;
            if (nr == 40) nr40 = 0;

            if (nr == 41) nr41 = 0;
            if (nr == 42) nr42 = 0;
            if (nr == 43) nr43 = 0;
            if (nr == 44) nr44 = 0;
            if (nr == 45) nr45 = 0;
            if (nr == 46) nr46 = 0;
            if (nr == 47) nr47 = 0;
            if (nr == 48) nr48 = 0;
            if (nr == 49) nr49 = 0;
            
        }
        private void gasit(int nr)
        {
        
        


                 
                 if (t1== nr||t2==nr||t3==nr||t4==nr||t5==nr||t6==nr)
                 {
                    
                     if (nr == 1) button1.BackColor = button53.BackColor; 
                     else
                          if (nr == 2) button2.BackColor = button53.BackColor;
                     else
                               if (nr == 3) button3.BackColor = button53.BackColor;
                     else
                                    if (nr == 4) button4.BackColor = button53.BackColor;
                     else
                                         if (nr == 5) button5.BackColor = button53.BackColor;
                     else
                                              if (nr == 6) button6.BackColor = button53.BackColor;
                     else
                                                   if (nr == 7) button7.BackColor = button53.BackColor;
                     else
                                                        if (nr == 8) button8.BackColor = button53.BackColor;
                     else
                                                             if (nr == 9) button9.BackColor = button53.BackColor;
                     else
                                                                  if (nr == 10) button10.BackColor = button53.BackColor;
                     else
                                                                       if (nr == 11) button11.BackColor = button53.BackColor;
                     else
                      if (nr == 12) button12.BackColor = button53.BackColor;
                     else
                           if (nr == 13) button13.BackColor = button53.BackColor;
                     else
                                if (nr == 14) button14.BackColor = button53.BackColor;
                     else
                                     if (nr == 15) button15.BackColor = button53.BackColor;
                     else
                                          if (nr == 16) button16.BackColor = button53.BackColor;
                     else
                                               if (nr == 17) button17.BackColor = button53.BackColor;
                     else
                                                    if (nr == 18) button18.BackColor = button53.BackColor;
                     else
                                                         if (nr == 19) button19.BackColor = button53.BackColor;
                     else
                                                              if (nr == 20) button20.BackColor = button53.BackColor;
                     else
                                                                   if (nr == 21) button21.BackColor = button53.BackColor;
                     else
                                                                        if (nr == 22) button22.BackColor = button53.BackColor;
                     else
                      if (nr == 23) button23.BackColor = button53.BackColor;
                     else
                           if (nr == 24) button24.BackColor = button53.BackColor;
                     else
                                if (nr == 25) button25.BackColor = button53.BackColor;
                     else
                                     if (nr == 26) button26.BackColor = button53.BackColor;
                     else
                                          if (nr == 27) button27.BackColor = button53.BackColor;
                     else
                                               if (nr == 28) button28.BackColor = button53.BackColor;
                     else
                                                    if (nr == 29) button29.BackColor = button53.BackColor;
                     else
                                                         if (nr == 30) button30.BackColor = button53.BackColor;
                     else
                                                              if (nr == 31) button31.BackColor = button53.BackColor;
                     else
                                                                   if (nr == 32) button32.BackColor = button53.BackColor;
                     else
                                                                        if (nr == 33) button33.BackColor = button53.BackColor;
                     else
                                                                             if (nr == 34) button34.BackColor = button53.BackColor;
                     else
                      if (nr == 35) button35.BackColor = button53.BackColor;
                     else
                           if (nr == 36) button36.BackColor = button53.BackColor;
                     else
                                if (nr == 37) button37.BackColor = button53.BackColor;
                     else
                                     if (nr == 38) button38.BackColor = button53.BackColor;
                     else
                                          if (nr == 39) button39.BackColor = button53.BackColor;
                     else
                                               if (nr == 40) button40.BackColor = button53.BackColor;
                     else
                                                    if (nr == 41) button41.BackColor = button53.BackColor;
                     else
                                                         if (nr == 42) button42.BackColor = button53.BackColor;
                     else
                                                              if (nr == 43) button43.BackColor = button53.BackColor;
                     else
                                                                   if (nr == 44) button44.BackColor = button53.BackColor;
                     else
                                                                        if (nr == 45) button45.BackColor = button53.BackColor;
                     else
                      if (nr == 46) button46.BackColor = button53.BackColor;
                     else
                           if (nr == 47) button47.BackColor = button53.BackColor;
                     else
                                if (nr == 48) button48.BackColor = button53.BackColor;
                     else
                                     if (nr == 49) button49.BackColor = button53.BackColor;



                     if (t1 == nr) { t1 = 0;  }
                     if (t2 == nr) {t2 = 0;}
                     if (t3 == nr) {t3 = 0; }
                     if (t4 == nr){ t4 = 0; }
                     if (t5 == nr) {t5 = 0; }
                     if (t6 == nr) { t6 = 0; }
                     bifeaza_ca_negru(nr);
                     nralb--; scor = 49 - nralb;
                     label47.Text = label13.Text + scor;
                 }


               
        }
        private void button50_Click(object sender, System.EventArgs e)
        {
            var nrs = 0;//numerelealese in t 1-6
            if (t1 != 0) nrs++;
            if (t2 != 0) nrs++;
            if (t3 != 0) nrs++;
            if (t4 != 0) nrs++;
            if (t5 != 0) nrs++;
            if (t6 != 0) nrs++;
            if (((nralb>=6&&nrs==6)||(nralb==nrs))&&nralb>0)
            { 
              
                nrrunde++;
                if (nrrunde == 15) gata2 = 0;
                if (nrrunde == 16) { nrrunde = 15; gata = 0; }
                nrgol = nralb;

              label7.Text = label13.Text ; 
                label8.Text = label13.Text ; 
                label9.Text = label13.Text ; 
                label10.Text = label13.Text ; 
                label11.Text = label13.Text ; 
                 label12.Text = label13.Text ; 
                label26.Text = label13.Text ; 
               label27.Text = label13.Text ; 
                label28.Text = label13.Text ; 
                label29.Text = label13.Text ; 
                 label30.Text = label13.Text ; 
                 label31.Text = label13.Text ; 
            label32.Text = label13.Text ; 
                label33.Text = label13.Text ; 
                 label34.Text = label13.Text ; 
                label35.Text = label13.Text ;
                //blocare casute
              

              rectangleShape1.FillStyle = rectangleShape24.FillStyle; 
              rectangleShape2.FillStyle = rectangleShape24.FillStyle; 
                rectangleShape3.FillStyle = rectangleShape24.FillStyle; 
                rectangleShape4.FillStyle = rectangleShape24.FillStyle; 
               rectangleShape5.FillStyle = rectangleShape24.FillStyle; 
                 rectangleShape6.FillStyle = rectangleShape24.FillStyle; 
               rectangleShape16.FillStyle = rectangleShape24.FillStyle; 
               rectangleShape15.FillStyle = rectangleShape24.FillStyle;
             rectangleShape7.FillStyle = rectangleShape24.FillStyle; 
                rectangleShape11.FillStyle = rectangleShape24.FillStyle; 
                rectangleShape10.FillStyle = rectangleShape24.FillStyle; 
               rectangleShape9.FillStyle = rectangleShape24.FillStyle; 
              rectangleShape8.FillStyle = rectangleShape24.FillStyle; 
               rectangleShape12.FillStyle = rectangleShape24.FillStyle; 
              rectangleShape14.FillStyle = rectangleShape24.FillStyle; 
                rectangleShape13.FillStyle = rectangleShape24.FillStyle;

               
                if (nrrunde >= 15) rectangleShape2.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 14) rectangleShape3.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 13) rectangleShape4.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 12) rectangleShape5.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 11) rectangleShape6.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 10) rectangleShape16.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 9) rectangleShape15.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 8) rectangleShape7.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 7) rectangleShape11.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 6) rectangleShape10.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 5) rectangleShape9.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 4) rectangleShape8.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 3) rectangleShape12.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 2) rectangleShape14.FillStyle = rectangleShape25.FillStyle;
                if (nrrunde >= 1) rectangleShape13.FillStyle = rectangleShape25.FillStyle; 


                var ew = a1;
               if(t1!=ew&&t2!=ew&&t3!=ew&&t4!=ew&&t5!=ew&&t6!=ew) nr_alb(ew);
               ew = a2;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a3;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a4;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a5;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a6;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a7;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a8;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a9;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a10;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a11;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a12;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a13;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a14;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a15;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
               ew = a16;
               if (t1 != ew && t2 != ew && t3 != ew && t4 != ew && t5 != ew && t6 != ew) nr_alb(ew);
             





               

                a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = a10 = a11 = a12 = a13 = a14 = a15 = a16 = 0; 
               
                timer1.Start();
              
            }


        }

        private void label22_Click(object sender, System.EventArgs e)
        {

        }

        private void label38_Click(object sender, System.EventArgs e)
        {

        }

        private void label45_Click(object sender, System.EventArgs e)
        {

        }

        private void label44_Click(object sender, System.EventArgs e)
        {

        }

        private void label43_Click(object sender, System.EventArgs e)
        {

        }

        private void label42_Click(object sender, System.EventArgs e)
        {

        }

        private void label41_Click(object sender, System.EventArgs e)
        {

        }
        private void verifica_casut_neagra(int nr)
        {
             ok=1;
            if (nr == 1) if (nr1 == 0) ok = 0 ;
            if (nr == 2) if (nr2 == 0) ok = 0;
            if (nr == 3) if (nr3 == 0) ok = 0;
            if (nr == 4) if (nr4 == 0) ok = 0;
            if (nr == 5) if (nr5 == 0) ok = 0;
            if (nr == 6) if (nr6 == 0) ok = 0;
            if (nr == 7) if (nr7 == 0) ok = 0;
            if (nr == 8) if (nr8 == 0) ok = 0;
            if (nr == 9) if (nr9 == 0) ok = 0;
            if (nr == 10) if (nr10 == 0) ok = 0;

            if (nr == 11) if (nr11 == 0) ok = 0;
            if (nr == 12) if (nr12 == 0) ok = 0;
            if (nr == 13) if (nr13 == 0) ok = 0;
            if (nr == 14) if (nr14 == 0) ok = 0;
            if (nr == 15) if (nr15 == 0) ok = 0;
            if (nr == 16) if (nr16 == 0) ok = 0;
            if (nr == 17) if (nr17 == 0) ok = 0;
            if (nr == 18) if (nr18 == 0) ok = 0;
            if (nr == 19) if (nr19 == 0) ok = 0;
            if (nr == 20) if (nr20 == 0) ok = 0;

            if (nr == 21) if (nr21 == 0) ok = 0;
            if (nr == 22) if (nr22 == 0) ok = 0;
            if (nr == 23) if (nr23 == 0) ok = 0;
            if (nr == 24) if (nr24 == 0) ok = 0;
            if (nr == 25) if (nr25 == 0) ok = 0;
            if (nr == 26) if (nr26 == 0) ok = 0;
            if (nr == 27) if (nr27 == 0) ok = 0;
            if (nr == 28) if (nr28 == 0) ok = 0;
            if (nr == 29) if (nr29 == 0) ok = 0;
            if (nr == 30) if (nr30 == 0) ok = 0;

            if (nr == 31) if (nr31 == 0) ok = 0;
            if (nr == 32) if (nr32 == 0) ok = 0;
            if (nr == 33) if (nr33 == 0) ok = 0;
            if (nr == 34) if (nr34 == 0) ok = 0;
            if (nr == 35) if (nr35 == 0) ok = 0;
            if (nr == 36) if (nr36 == 0) ok = 0;
            if (nr == 37) if (nr37 == 0) ok = 0;
            if (nr == 38) if (nr38 == 0) ok = 0;
            if (nr == 39) if (nr39 == 0) ok = 0;
            if (nr == 40) if (nr40 == 0) ok = 0;

            if (nr == 41) if (nr41 == 0) ok = 0;
            if (nr == 42) if (nr42 == 0) ok = 0;
            if (nr == 43) if (nr43 == 0) ok = 0;
            if (nr == 44) if (nr44 == 0) ok = 0;
            if (nr == 45) if (nr45 == 0) ok = 0;
            if (nr == 46) if (nr46 == 0) ok = 0;
            if (nr == 47) if (nr47 == 0) ok = 0;
            if (nr == 48) if (nr48 == 0) ok = 0;
            if (nr == 49) if (nr49 == 0) ok = 0;
        }
        private void nr_alb(int nr)
        {



            if (nr == 1) button1.BackColor = button51.BackColor;
            else
                if (nr == 2) button2.BackColor = button51.BackColor;
                else
                    if (nr == 3) button3.BackColor = button51.BackColor;
                    else
                        if (nr == 4) button4.BackColor = button51.BackColor;
                        else
                            if (nr == 5) button5.BackColor = button51.BackColor;
                            else
                                if (nr == 6) button6.BackColor = button51.BackColor;
                                else
                                    if (nr == 7) button7.BackColor = button51.BackColor;
                                    else
                                        if (nr == 8) button8.BackColor = button51.BackColor;
                                        else
                                            if (nr == 9) button9.BackColor = button51.BackColor;
                                            else
                                                if (nr == 10) button10.BackColor = button51.BackColor;
                                                else
                                                    if (nr == 11) button11.BackColor = button51.BackColor;
                                                    else
                                                        if (nr == 12) button12.BackColor = button51.BackColor;
                                                        else
                                                            if (nr == 13) button13.BackColor = button51.BackColor;
                                                            else
                                                                if (nr == 14) button14.BackColor = button51.BackColor;
                                                                else
                                                                    if (nr == 15) button15.BackColor = button51.BackColor;
                                                                    else
                                                                        if (nr == 16) button16.BackColor = button51.BackColor;
                                                                        else
                                                                            if (nr == 17) button17.BackColor = button51.BackColor;
                                                                            else
                                                                                if (nr == 18) button18.BackColor = button51.BackColor;
                                                                                else
                                                                                    if (nr == 19) button19.BackColor = button51.BackColor;
                                                                                    else
                                                                                        if (nr == 20) button20.BackColor = button51.BackColor;
                                                                                        else
                                                                                            if (nr == 21) button21.BackColor = button51.BackColor;
                                                                                            else
                                                                                                if (nr == 22) button22.BackColor = button51.BackColor;
                                                                                                else
                                                                                                    if (nr == 23) button23.BackColor = button51.BackColor;
                                                                                                    else
                                                                                                        if (nr == 24) button24.BackColor = button51.BackColor;
                                                                                                        else
                                                                                                            if (nr == 25) button25.BackColor = button51.BackColor;
                                                                                                            else
                                                                                                                if (nr == 26) button26.BackColor = button51.BackColor;
                                                                                                                else
                                                                                                                    if (nr == 27) button27.BackColor = button51.BackColor;
                                                                                                                    else
                                                                                                                        if (nr == 28) button28.BackColor = button51.BackColor;
                                                                                                                        else
                                                                                                                            if (nr == 29) button29.BackColor = button51.BackColor;
                                                                                                                            else
                                                                                                                                if (nr == 30) button30.BackColor = button51.BackColor;
                                                                                                                                else
                                                                                                                                    if (nr == 31) button31.BackColor = button51.BackColor;
                                                                                                                                    else
                                                                                                                                        if (nr == 32) button32.BackColor = button51.BackColor;
                                                                                                                                        else
                                                                                                                                            if (nr == 33) button33.BackColor = button51.BackColor;
                                                                                                                                            else
                                                                                                                                                if (nr == 34) button34.BackColor = button51.BackColor;
                                                                                                                                                else
                                                                                                                                                    if (nr == 35) button35.BackColor = button51.BackColor;
                                                                                                                                                    else
                                                                                                                                                        if (nr == 36) button36.BackColor = button51.BackColor;
                                                                                                                                                        else
                                                                                                                                                            if (nr == 37) button37.BackColor = button51.BackColor;
                                                                                                                                                            else
                                                                                                                                                                if (nr == 38) button38.BackColor = button51.BackColor;
                                                                                                                                                                else
                                                                                                                                                                    if (nr == 39) button39.BackColor = button51.BackColor;
                                                                                                                                                                    else
                                                                                                                                                                        if (nr == 40) button40.BackColor = button51.BackColor;
                                                                                                                                                                        else
                                                                                                                                                                            if (nr == 41) button41.BackColor = button51.BackColor;
                                                                                                                                                                            else
                                                                                                                                                                                if (nr == 42) button42.BackColor = button51.BackColor;
                                                                                                                                                                                else
                                                                                                                                                                                    if (nr == 43) button43.BackColor = button51.BackColor;
                                                                                                                                                                                    else
                                                                                                                                                                                        if (nr == 44) button44.BackColor = button51.BackColor;
                                                                                                                                                                                        else
                                                                                                                                                                                            if (nr == 45) button45.BackColor = button51.BackColor;
                                                                                                                                                                                            else
                                                                                                                                                                                                if (nr == 46) button46.BackColor = button51.BackColor;
                                                                                                                                                                                                else
                                                                                                                                                                                                    if (nr == 47) button47.BackColor = button51.BackColor;
                                                                                                                                                                                                    else
                                                                                                                                                                                                        if (nr == 48) button48.BackColor = button51.BackColor;
                                                                                                                                                                                                        else
                                                                                                                                                                                                            if (nr == 49) button49.BackColor = button51.BackColor;


        }
         private void nr_extras(int nr)
        {
        
   
                    
                     if (nr == 1) button1.BackColor = button54.BackColor; 
                     else
                          if (nr == 2) button2.BackColor = button54.BackColor;
                     else
                               if (nr == 3) button3.BackColor = button54.BackColor;
                     else
                                    if (nr == 4) button4.BackColor = button54.BackColor;
                     else
                                         if (nr == 5) button5.BackColor = button54.BackColor;
                     else
                                              if (nr == 6) button6.BackColor = button54.BackColor;
                     else
                                                   if (nr == 7) button7.BackColor = button54.BackColor;
                     else
                                                        if (nr == 8) button8.BackColor = button54.BackColor;
                     else
                                                             if (nr == 9) button9.BackColor = button54.BackColor;
                     else
                                                                  if (nr == 10) button10.BackColor = button54.BackColor;
                     else
                                                                       if (nr == 11) button11.BackColor = button54.BackColor;
                     else
                      if (nr == 12) button12.BackColor = button54.BackColor;
                     else
                           if (nr == 13) button13.BackColor = button54.BackColor;
                     else
                                if (nr == 14) button14.BackColor = button54.BackColor;
                     else
                                     if (nr == 15) button15.BackColor = button54.BackColor;
                     else
                                          if (nr == 16) button16.BackColor = button54.BackColor;
                     else
                                               if (nr == 17) button17.BackColor = button54.BackColor;
                     else
                                                    if (nr == 18) button18.BackColor = button54.BackColor;
                     else
                                                         if (nr == 19) button19.BackColor = button54.BackColor;
                     else
                                                              if (nr == 20) button20.BackColor = button54.BackColor;
                     else
                                                                   if (nr == 21) button21.BackColor = button54.BackColor;
                     else
                                                                        if (nr == 22) button22.BackColor = button54.BackColor;
                     else
                      if (nr == 23) button23.BackColor = button54.BackColor;
                     else
                           if (nr == 24) button24.BackColor = button54.BackColor;
                     else
                                if (nr == 25) button25.BackColor = button54.BackColor;
                     else
                                     if (nr == 26) button26.BackColor = button54.BackColor;
                     else
                                          if (nr == 27) button27.BackColor = button54.BackColor;
                     else
                                               if (nr == 28) button28.BackColor = button54.BackColor;
                     else
                                                    if (nr == 29) button29.BackColor = button54.BackColor;
                     else
                                                         if (nr == 30) button30.BackColor = button54.BackColor;
                     else
                                                              if (nr == 31) button31.BackColor = button54.BackColor;
                     else
                                                                   if (nr == 32) button32.BackColor = button54.BackColor;
                     else
                                                                        if (nr == 33) button33.BackColor = button54.BackColor;
                     else
                                                                             if (nr == 34) button34.BackColor = button54.BackColor;
                     else
                      if (nr == 35) button35.BackColor = button54.BackColor;
                     else
                           if (nr == 36) button36.BackColor = button54.BackColor;
                     else
                                if (nr == 37) button37.BackColor = button54.BackColor;
                     else
                                     if (nr == 38) button38.BackColor = button54.BackColor;
                     else
                                          if (nr == 39) button39.BackColor = button54.BackColor;
                     else
                                               if (nr == 40) button40.BackColor = button54.BackColor;
                     else
                                                    if (nr == 41) button41.BackColor = button54.BackColor;
                     else
                                                         if (nr == 42) button42.BackColor = button54.BackColor;
                     else
                                                              if (nr == 43) button43.BackColor = button54.BackColor;
                     else
                                                                   if (nr == 44) button44.BackColor = button54.BackColor;
                     else
                                                                        if (nr == 45) button45.BackColor = button54.BackColor;
                     else
                      if (nr == 46) button46.BackColor = button54.BackColor;
                     else
                           if (nr == 47) button47.BackColor = button54.BackColor;
                     else
                                if (nr == 48) button48.BackColor = button54.BackColor;
                     else
                                     if (nr == 49) button49.BackColor = button54.BackColor;


                 }
        private void start()
        {
            if (nrgol != 0 &&gata==1)
            {


                Random r;
                var fd = 0;

                r = new Random();
                d = r.Next(50);
                verifica_casut_neagra(d);
                while (ok == 0 || d == a1 || d == a2 || d == a3 || d == a4 || d == a5 || d == 0 || d == a6 || d == a7 || d == a8 || d == a9 || d == a10 || d == a11 || d == a12 || d == a13 || d == a14 || d == a15)
                {
                    r = new Random();
                    d = r.Next(50);
                    verifica_casut_neagra(d);
                }
                fd = d;
                nrgol--;
                if (i == 1) { a1 = fd; label7.Text = label13.Text + a1; }
                if (i == 2) { a2 = fd; label8.Text = label13.Text + a2; }
                if (i == 3) { a3 = fd; label9.Text = label13.Text + a3; }
                if (i == 4) { a4 = fd; label10.Text = label13.Text + a4; }
                if (i == 5) { a5 = fd; label11.Text = label13.Text + a5; }
                if (i == 6) { a6 = fd; label12.Text = label13.Text + a6; }
                if (i == 7) { a7 = fd; label26.Text = label13.Text + a7; }
                if (i == 8) { a8 = fd; label27.Text = label13.Text + a8; }
                if (i == 9) { a9 = fd; label28.Text = label13.Text + a9; }
                if (i == 10) { a10 = fd; label29.Text = label13.Text + a10; }
                if (i == 11) { a11 = fd; label30.Text = label13.Text + a11; }
                if (i == 12) { a12 = fd; label31.Text = label13.Text + a12; }
                if (i == 13) { a13 = fd; label32.Text = label13.Text + a13; }
                if (i == 14) { a14 = fd; label33.Text = label13.Text + a14; }
                if (i == 15) { a15 = fd; label34.Text = label13.Text + a15; }
                if (i == 16) { a16 = fd; label35.Text = label13.Text + a16; }

                nr_extras(fd);
                var rer = nralb;
                gasit(fd);//negru




                if (rer != nralb)
                {
                    if (i == 1) { a1 = 0; rectangleShape1.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 2) { a2 = 0; rectangleShape2.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 3) { a3 = 0; rectangleShape3.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 4) { a4 = 0; rectangleShape4.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 5) { a5 = 0; rectangleShape5.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 6) { a6 = 0; rectangleShape6.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 7) { a7 = 0; rectangleShape16.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 8) { a8 = 0; rectangleShape15.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 9) { a9 = 0; rectangleShape7.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 10) { a10 = 0; rectangleShape11.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 11) { a11 = 0; rectangleShape10.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 12) { a12 = 0; rectangleShape9.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 13) { a13 = 0; rectangleShape8.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 14) { a14 = 0; rectangleShape12.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 15) { a15 = 0; rectangleShape14.FillStyle = rectangleShape23.FillStyle; }
                    if (i == 16) { a16 = 0; rectangleShape13.FillStyle = rectangleShape23.FillStyle; }
                }
                i = i + 1; 
                scrie_fisier(1, scor);
                citire_fisier(1);
                if (i +nrrunde== 17) { timer1.Stop(); i = 1; }
            }
            else { timer1.Stop(); i = 1;  if(gata==0) rectangleShape1.FillStyle = rectangleShape25.FillStyle; }
        }

        private void nr_ales(int nr)
        {



            if (nr == 1) button1.BackColor = button52.BackColor;
            else
                if (nr == 2) button2.BackColor = button52.BackColor;
                else
                    if (nr == 3) button3.BackColor = button52.BackColor;
                    else
                        if (nr == 4) button4.BackColor = button52.BackColor;
                        else
                            if (nr == 5) button5.BackColor = button52.BackColor;
                            else
                                if (nr == 6) button6.BackColor = button52.BackColor;
                                else
                                    if (nr == 7) button7.BackColor = button52.BackColor;
                                    else
                                        if (nr == 8) button8.BackColor = button52.BackColor;
                                        else
                                            if (nr == 9) button9.BackColor = button52.BackColor;
                                            else
                                                if (nr == 10) button10.BackColor = button52.BackColor;
                                                else
                                                    if (nr == 11) button11.BackColor = button52.BackColor;
                                                    else
                                                        if (nr == 12) button12.BackColor = button52.BackColor;
                                                        else
                                                            if (nr == 13) button13.BackColor = button52.BackColor;
                                                            else
                                                                if (nr == 14) button14.BackColor = button52.BackColor;
                                                                else
                                                                    if (nr == 15) button15.BackColor = button52.BackColor;
                                                                    else
                                                                        if (nr == 16) button16.BackColor = button52.BackColor;
                                                                        else
                                                                            if (nr == 17) button17.BackColor = button52.BackColor;
                                                                            else
                                                                                if (nr == 18) button18.BackColor = button52.BackColor;
                                                                                else
                                                                                    if (nr == 19) button19.BackColor = button52.BackColor;
                                                                                    else
                                                                                        if (nr == 20) button20.BackColor = button52.BackColor;
                                                                                        else
                                                                                            if (nr == 21) button21.BackColor = button52.BackColor;
                                                                                            else
                                                                                                if (nr == 22) button22.BackColor = button52.BackColor;
                                                                                                else
                                                                                                    if (nr == 23) button23.BackColor = button52.BackColor;
                                                                                                    else
                                                                                                        if (nr == 24) button24.BackColor = button52.BackColor;
                                                                                                        else
                                                                                                            if (nr == 25) button25.BackColor = button52.BackColor;
                                                                                                            else
                                                                                                                if (nr == 26) button26.BackColor = button52.BackColor;
                                                                                                                else
                                                                                                                    if (nr == 27) button27.BackColor = button52.BackColor;
                                                                                                                    else
                                                                                                                        if (nr == 28) button28.BackColor = button52.BackColor;
                                                                                                                        else
                                                                                                                            if (nr == 29) button29.BackColor = button52.BackColor;
                                                                                                                            else
                                                                                                                                if (nr == 30) button30.BackColor = button52.BackColor;
                                                                                                                                else
                                                                                                                                    if (nr == 31) button31.BackColor = button52.BackColor;
                                                                                                                                    else
                                                                                                                                        if (nr == 32) button32.BackColor = button52.BackColor;
                                                                                                                                        else
                                                                                                                                            if (nr == 33) button33.BackColor = button52.BackColor;
                                                                                                                                            else
                                                                                                                                                if (nr == 34) button34.BackColor = button52.BackColor;
                                                                                                                                                else
                                                                                                                                                    if (nr == 35) button35.BackColor = button52.BackColor;
                                                                                                                                                    else
                                                                                                                                                        if (nr == 36) button36.BackColor = button52.BackColor;
                                                                                                                                                        else
                                                                                                                                                            if (nr == 37) button37.BackColor = button52.BackColor;
                                                                                                                                                            else
                                                                                                                                                                if (nr == 38) button38.BackColor = button52.BackColor;
                                                                                                                                                                else
                                                                                                                                                                    if (nr == 39) button39.BackColor = button52.BackColor;
                                                                                                                                                                    else
                                                                                                                                                                        if (nr == 40) button40.BackColor = button52.BackColor;
                                                                                                                                                                        else
                                                                                                                                                                            if (nr == 41) button41.BackColor = button52.BackColor;
                                                                                                                                                                            else
                                                                                                                                                                                if (nr == 42) button42.BackColor = button52.BackColor;
                                                                                                                                                                                else
                                                                                                                                                                                    if (nr == 43) button43.BackColor = button52.BackColor;
                                                                                                                                                                                    else
                                                                                                                                                                                        if (nr == 44) button44.BackColor = button52.BackColor;
                                                                                                                                                                                        else
                                                                                                                                                                                            if (nr == 45) button45.BackColor = button52.BackColor;
                                                                                                                                                                                            else
                                                                                                                                                                                                if (nr == 46) button46.BackColor = button52.BackColor;
                                                                                                                                                                                                else
                                                                                                                                                                                                    if (nr == 47) button47.BackColor = button52.BackColor;
                                                                                                                                                                                                    else
                                                                                                                                                                                                        if (nr == 48) button48.BackColor = button52.BackColor;
                                                                                                                                                                                                        else
                                                                                                                                                                                                            if (nr == 49) button49.BackColor = button52.BackColor;


        }
        private void label40_Click(object sender, System.EventArgs e)
        {

        }

        private void button53_Click(object sender, System.EventArgs e)
        {

        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
           
            start();
           
 
          }

        private void label7_Click(object sender, System.EventArgs e)
        {
            
        }

        private void rectangleShape1_Click(object sender, System.EventArgs e)
        {
            
        }

        private void rectangleShape23_Click(object sender, System.EventArgs e)
        {

        }

        private void label47_Click(object sender, System.EventArgs e)
        {

        }
        private void de_la_inceput()
        {
            scor = 0;
            gata = 1;
            gata2 = 1;
            nrrunde = -1;
            i = 1;

            nralb = 49;
            nrgol = 49;
            var k = 1;
            for (k = 1; k <= 49; k++)
                nr_alb(k);
            a1 = 0;
            a2 = 0; a3 = 0; a4 = 0;
            a5 = 0; a6 = 0; a7 = 0;
            a8 = 0; a9 = 0; a10 = 0;
            a11 = 0; a12 = 0; a13 = 0;
            a14 = 0; a15 = 0; a16 = 0;
            t1 = 0; t2 = 0; t3 = 0; t4 = 0; t5 = 0; t6 = 0;
            nr1 = 1;
            nr2 = 1; nr3 = 1; nr4 = 1;
            nr5 = 1; nr6 = 1; nr7 = 1;
            nr8 = 1; nr9 = 1; nr10 = 1;
            nr11 = 1; nr12 = 1; nr13 = 1;
            nr14 = 1; nr15 = 1; nr16 = 1;
            nr17 = 1; nr18 = 1; nr19 = 1;
            nr20 = 1; nr21 = 1; nr22 = 1;
            nr23 = 1; nr24 = 1; nr25 = 1;
            nr26 = 1; nr27 = 1; nr28 = 1;
            nr29 = 1; nr30 = 1; nr31 = 1;
            nr32 = 1; nr33 = 1; nr34 = 1;
            nr35 = 1; nr36 = 1; nr37 = 1;
            nr38 = 1; nr39 = 1; nr40 = 1;
            nr41 = 1; nr42 = 1; nr43 = 1;
            nr44 = 1; nr45 = 1; nr46 = 1;
            nr47 = 1; nr48 = 1; nr49 = 1;


            label7.Text = label13.Text;
            label8.Text = label13.Text;
            label9.Text = label13.Text;
            label10.Text = label13.Text;
            label11.Text = label13.Text;
            label12.Text = label13.Text;
            label26.Text = label13.Text;
            label27.Text = label13.Text;
            label28.Text = label13.Text;
            label29.Text = label13.Text;
            label30.Text = label13.Text;
            label31.Text = label13.Text;
            label32.Text = label13.Text;
            label33.Text = label13.Text;
            label34.Text = label13.Text;
            label35.Text = label13.Text;

            rectangleShape1.FillStyle = rectangleShape24.FillStyle;
            rectangleShape2.FillStyle = rectangleShape24.FillStyle;
            rectangleShape3.FillStyle = rectangleShape24.FillStyle;
            rectangleShape4.FillStyle = rectangleShape24.FillStyle;
            rectangleShape5.FillStyle = rectangleShape24.FillStyle;
            rectangleShape6.FillStyle = rectangleShape24.FillStyle;
            rectangleShape16.FillStyle = rectangleShape24.FillStyle;
            rectangleShape15.FillStyle = rectangleShape24.FillStyle;
            rectangleShape7.FillStyle = rectangleShape24.FillStyle;
            rectangleShape11.FillStyle = rectangleShape24.FillStyle;
            rectangleShape10.FillStyle = rectangleShape24.FillStyle;
            rectangleShape9.FillStyle = rectangleShape24.FillStyle;
            rectangleShape8.FillStyle = rectangleShape24.FillStyle;
            rectangleShape12.FillStyle = rectangleShape24.FillStyle;
            rectangleShape14.FillStyle = rectangleShape24.FillStyle;
            rectangleShape13.FillStyle = rectangleShape24.FillStyle;


            label45.Text = " ";
            label44.Text = " ";
            label43.Text = " ";
            label42.Text = " ";
            label41.Text = " ";
            label40.Text = " ";
            label47.Text = label13.Text + scor;
        }
        private void button55_Click(object sender, System.EventArgs e)
        {
            de_la_inceput();
        }

        private void label49_Click(object sender, System.EventArgs e)
        {

        }

        private void label48_Click(object sender, System.EventArgs e)
        {

        }

        private void button56_Click(object sender, System.EventArgs e)
        {
            var nrs = 0;//numerelealese in t 1-6

            if (nralb > 5)
            {
                a1 = 0;
                a2 = 0; a3 = 0; a4 = 0;
                a5 = 0; a6 = 0; a7 = 0;
                a8 = 0; a9 = 0; a10 = 0;
                a11 = 0; a12 = 0; a13 = 0;
                a14 = 0; a15 = 0; a16 = 0;
                Random r1;

                var lp1 = 0; var lp2 = 0; var lp3 = 0; var lp4 = 0; var lp5 = 0; var lp6 = 0;
                var d1 = 0;

                r1 = new Random();
                d1 = r1.Next(50);
                verifica_casut_neagra(d1);
                while (d1 == 0 || ok == 0)
                {
                    r1 = new Random();
                    d1 = r1.Next(50);
                    verifica_casut_neagra(d1);
                }

                lp1 = d1;
                r1 = new Random();
                d1 = r1.Next(50);
                verifica_casut_neagra(d1);
                while (d1 == lp1 || d1 == 0 || ok == 0)
                {
                    r1 = new Random();
                    d1 = r1.Next(50);
                    verifica_casut_neagra(d1);
                }

                lp2 = d1;

                r1 = new Random();
                d1 = r1.Next(50);
                verifica_casut_neagra(d1);
                while (d1 == lp1 || d1 == lp2 || d1 == 0 || ok == 0)
                {
                    r1 = new Random();
                    d1 = r1.Next(50);
                    verifica_casut_neagra(d1);
                }

                lp3 = d1;
                r1 = new Random();
                d1 = r1.Next(50);
                verifica_casut_neagra(d1);
                while (d1 == lp1 || d1 == lp2 || d1 == lp3 || d1 == 0 || ok == 0)
                {
                    r1 = new Random();
                    d1 = r1.Next(50);
                    verifica_casut_neagra(d1);
                }

                lp4 = d1;

                r1 = new Random();
                d1 = r1.Next(50);
                verifica_casut_neagra(d1);
                while (d1 == lp1 || d1 == lp2 || d1 == lp3 || d1 == lp4 || d1 == 0 || ok == 0)
                {
                    r1 = new Random();
                    d1 = r1.Next(50);
                    verifica_casut_neagra(d1);
                }

                lp5 = d1;

                r1 = new Random();
                d1 = r1.Next(50);
                verifica_casut_neagra(d1);
                while (d1 == lp1 || d1 == lp2 || d1 == lp3 || d1 == lp4 || d1 == lp5 || d1 == 0 || ok == 0)
                {
                    r1 = new Random();
                    d1 = r1.Next(50);
                    verifica_casut_neagra(d1);
                }
                lp6 = d1;
                ////structura urmatoare modifica in alb casutele albastre
                var ty = 1;
                for (ty = 1; ty < 50; ty++)
                {
                    verifica_casut_neagra(ty);//ok devine 0 daca exista//ok este initializat cu 1 in subprogram
                    if (ok == 1) nr_alb(ty);
                }

                t1 = lp1;
                t2 = lp2;
                t3 = lp3;
                t4 = lp4;
                t5 = lp5;
                t6 = lp6;
                label45.Text = label13.Text + t1;
                label44.Text = label13.Text + t2;
                label43.Text = label13.Text + t3;
                label42.Text = label13.Text + t4;
                label41.Text = label13.Text + t5;
                label40.Text = label13.Text + t6;
                nr_ales(t1); nr_ales(t2); nr_ales(t3); nr_ales(t4); nr_ales(t5); nr_ales(t6);
            }
        }
    }
}
