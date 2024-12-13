using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace greetingCard
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen blackpenthick = new Pen(Color.Black, 5);
        Pen blackpenmed = new Pen(Color.Black, 3);
        Pen blackpenthin = new Pen(Color.Black, 2);
        Brush blackbrush = new SolidBrush(Color.Black);
        Brush violetbrush = new SolidBrush(Color.Violet);
        Brush whitebrush = new SolidBrush(Color.AntiqueWhite);
        SoundPlayer soundPlayer = new SoundPlayer();
        Font blacktext = new Font("Arial", 20, FontStyle.Bold);
        Font bigblacktext = new Font("Arial", 50, FontStyle.Bold);
        Font violettext = new Font("Papyrus", 40, FontStyle.Bold);
        SoundPlayer petscop = new SoundPlayer(Properties.Resources.petscop);

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            g.DrawEllipse(blackpenthick, 250, 150, 75, 75);
            g.DrawEllipse(blackpenthin, 270, 175, 10, 10);
            g.DrawEllipse(blackpenthin, 295, 175, 10, 10);
            g.DrawArc(blackpenmed, 265, 170, 45, 40, 0, 170);
            g.DrawString("Click Me!", blacktext, blackbrush, 225, 250);

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int i = 1;

            petscop.PlayLooping();

            g.Clear(Color.White);
            
            g.DrawString("G", bigblacktext, blackbrush, 110, 75);
            Thread.Sleep(250);
            g.DrawString("A", bigblacktext, blackbrush, 150, 75);
            Thread.Sleep(250);
            g.DrawString("R", bigblacktext, blackbrush, 190, 75);
            Thread.Sleep(250);
            g.DrawString("A", bigblacktext, blackbrush, 230, 75);
            Thread.Sleep(250);
            g.DrawString("L", bigblacktext, blackbrush, 270, 75);
            Thread.Sleep(250);
            g.DrawString("I", bigblacktext, blackbrush, 310, 75);
            Thread.Sleep(250);
            g.DrawString("N", bigblacktext, blackbrush, 330, 75);
            Thread.Sleep(250);
            g.DrawString("A", bigblacktext, blackbrush, 370, 75);
            Thread.Sleep(3000);

            while (i <= 100)
            {
                g.Clear(Color.White);
                g.DrawString("Petscop", violettext, violetbrush, 180, 175);
                g.FillRectangle(violetbrush, 250, 100, 70, 70);
                g.FillRectangle(whitebrush, 250, 125, 70, 25);
                g.FillRectangle(whitebrush, 275, 100, 25, 70);
                

                Thread.Sleep(250);
                
                g.Clear(Color.White);
                g.TranslateTransform(175, 200);
                g.RotateTransform(9);
                g.DrawString("Petscop", violettext, violetbrush, 5, -45);
                g.FillRectangle(violetbrush, 85, -120, 70, 70);
                g.FillRectangle(whitebrush, 85, -95, 70, 25);
                g.FillRectangle(whitebrush, 110, -120, 25, 70);

                Thread.Sleep(250);

                g.Clear(Color.White);
                g.RotateTransform(-18);
                g.DrawString("Petscop", violettext, violetbrush, -5, -15);
                g.FillRectangle(violetbrush, 80, -90, 70, 70);
                g.FillRectangle(whitebrush, 80, -65, 70, 25);
                g.FillRectangle(whitebrush, 105, -90, 25, 70);
                g.ResetTransform();

                Thread.Sleep(250);
                i++;
            }

            Close();

        }
    }
}
