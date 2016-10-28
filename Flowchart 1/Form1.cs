using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Flowchart_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            exitButton.Visible = false;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();
            Font whiteFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            startButton.Visible = false;

            fg.Clear(Color.Black);
            fg.DrawString("Hello", whiteFont, whiteBrush, 100, 40);
            fg.DrawString("World!", whiteFont, whiteBrush, 100, 70);

            Thread.Sleep(3000);
            fg.Clear(Color.Red);
            fg.DrawString("Hello", whiteFont, whiteBrush, 100, 40);
            fg.DrawString("World!", whiteFont, whiteBrush, 100, 70);
            Thread.Sleep(500);

            fg.Clear(Color.Black);
            fg.DrawString("Hello", whiteFont, whiteBrush, 100, 40);
            fg.DrawString("World!", whiteFont, whiteBrush, 100, 70);
            Thread.Sleep(500);

            fg.Clear(Color.Red);
            fg.DrawString("Hello", whiteFont, whiteBrush, 100, 40);
            fg.DrawString("World!", whiteFont, whiteBrush, 100, 70);
            Thread.Sleep(500);

            fg.Clear(Color.Black);
            fg.DrawString("Hello", whiteFont, whiteBrush, 100, 40);
            fg.DrawString("World!", whiteFont, whiteBrush, 100, 70);
            Thread.Sleep(500);

            fg.Clear(Color.Black);
            exitButton.Visible = true;
            fg.DrawString("Press the exit button!", whiteFont, whiteBrush, 30, 40);



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();
            Font whiteFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            exitButton.Visible = false;
            fg.Clear(Color.Black);

            fg.DrawString("Good-bye!", whiteFont, whiteBrush, 80, 40);
            Thread.Sleep(2500);

            this.Close();

        }
        
}
   
}


