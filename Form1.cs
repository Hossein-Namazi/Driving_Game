using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Driving_Game
{
    public partial class Form1 : Form
    {
        int R = new Random().Next(100, 1000);
        int r1 = new Random().Next(1, 7);
        int r2 = new Random().Next(1, 7);
        int r3 = new Random().Next(1, 7);
        int RH = new Random().Next(1, 7);
        int Score = 0;
        int Record = 0;
        int x = 288;
        int y = 545;
        int x_Car1 = 30;
        int y_Car1 = -400;
        int x_Car2 = 116;
        int y_Car2 = -400;
        int x_Car3 = 202;
        int y_Car3 = -400;
        int x_Car4 = 0;
        int y_Car4 = -400;
        int x_Car5 = 0;
        int y_Car5 = -400;
        int x_Car6 = 0;
        int y_Car6 = -400;
        int Half = 1;
        int Half_Score = 100;
        int s1 = new Random().Next(5, 8);
        int s2 = new Random().Next(5, 8);
        int s3 = new Random().Next(5, 8);
        int s4 = new Random().Next(5, 8);
        int s5 = new Random().Next(5, 8);
        int s6 = new Random().Next(5, 8);
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            try
            {
                Record = int.Parse(File.ReadAllText("Data.dll"));
            }
            catch
            {
                File.WriteAllText("Data.dll", $"{Record}");
            }
            label3.Visible = false;
            int index = random.Next(imagePaths.Length);
            pictureBox5.ImageLocation = imagePaths[index];
            index = random.Next(imagePaths.Length);
            pictureBox6.ImageLocation = imagePaths[index];
            index = random.Next(imagePaths.Length);
            pictureBox7.ImageLocation = imagePaths[index];
            index = random.Next(imagePaths.Length);
            pictureBox8.ImageLocation = imagePaths[index];
            index = random.Next(imagePaths.Length);
            pictureBox9.ImageLocation = imagePaths[index];
            index = random.Next(imagePaths.Length);
            pictureBox10.ImageLocation = imagePaths[index];
            r1 = new Random().Next(1, 7);
            timer1.Start();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            r1 = new Random().Next(1, 7);
            if (r1 == 1) { x_Car1 = 30; }
            if (r1 == 2) { x_Car1 = 116; }
            if (r1 == 3) { x_Car1 = 30; }
            if (r1 == 4) { x_Car1 = 116; }
            if (r1 == 5) { x_Car1 = 30; }
            if (r1 == 6) { x_Car1 = 116; }
            r2 = new Random().Next(1, 7);
            if (r2 == 1) { x_Car2 = 202; }
            if (r2 == 2) { x_Car2 = 288; }
            if (r2 == 3) { x_Car2 = 202; }
            if (r2 == 4) { x_Car2 = 288; }
            if (r2 == 5) { x_Car2 = 202; }
            if (r2 == 6) { x_Car2 = 288; }
            y_Car3 = R - R - R;
            r3 = new Random().Next(1, 7);
            if (r3 == 1) { x_Car3 = 374; }
            if (r3 == 2) { x_Car3 = 460; }
            if (r3 == 3) { x_Car3 = 374; }
            if (r3 == 4) { x_Car3 = 460; }
            if (r3 == 5) { x_Car3 = 374; }
            if (r3 == 6) { x_Car3 = 460; }
        }
        private string[] imagePaths = {
            "Red_Car.png",
            "Runing_Car.png",
            "Plice_Car.png",
            "Vanet_Car.png",
            "Taxi_Car.png",
            "Hosbital_Car.png",
            "Van_Car.png",
        };
        private void Location(int x, int y)
        {
            pictureBox4.Location = new System.Drawing.Point(x, y);
        }
        private void Location_Car1(int x, int y)
        {
            pictureBox5.Location = new System.Drawing.Point(x, y);
        }
        private void Location_Car2(int x, int y)
        {
            pictureBox6.Location = new System.Drawing.Point(x, y);
        }
        private void Location_Car3(int x, int y)
        {
            pictureBox7.Location = new System.Drawing.Point(x, y);
        }
        private void Location_Car4(int x, int y)
        {
            pictureBox8.Location = new System.Drawing.Point(x, y);
        }
        private void Location_Car5(int x, int y)
        {
            pictureBox9.Location = new System.Drawing.Point(x, y);
        }
        private void Location_Car6(int x, int y)
        {
            pictureBox10.Location = new System.Drawing.Point(x, y);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A | e.KeyCode == Keys.Left)
            {
                if (x > 32)
                {
                    Location(x -= 43, y);
                }
            }
            if (e.KeyCode == Keys.D | e.KeyCode == Keys.Right)
            {
                if (x < 455)
                {
                    Location(x += 43, y);
                }
            }
            if (e.KeyCode == Keys.W | e.KeyCode == Keys.Up)
            {
                if (y > 20)
                {
                    Location(x, y -= 11);
                }
            }
            if (e.KeyCode == Keys.S | e.KeyCode == Keys.Down)
            {
                if (y < 530)
                {
                    Location(x, y += 21);
                }
            }
            label3.Location = new System.Drawing.Point(x + 13, y + 54);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lose(30);
            label3.Text = $"{Half_Score}";
            if (Score > Record) { Record = Score; }
            File.WriteAllText("Data.dll", $"{Record}");
            y_Car1 += 7;
            y_Car2 += 5;
            y_Car3 += 6;
            y_Car4 += 7;
            y_Car5 += 5;
            y_Car6 += 6;
            if (true)
            {
                if (y_Car1 > 725)
                {
                    int index = random.Next(imagePaths.Length);
                    pictureBox5.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car1 = R - R - R;
                    r1 = new Random().Next(1, 7);
                    if (r1 == 1) { x_Car1 = 30; }
                    if (r1 == 2) { x_Car1 = 116; }
                    if (r1 == 3) { x_Car1 = 30; }
                    if (r1 == 4) { x_Car1 = 116; }
                    if (r1 == 5) { x_Car1 = 30; }
                    if (r1 == 6) { x_Car1 = 116; }
                    if (Score > 9)
                    {
                        x_Car1 = 30;
                    }
                    ++Score;
                    --Half_Score;
                }
                Location_Car1(x_Car1, y_Car1);
            }
            if (true)
            {
                if (y_Car2 > 725)
                {
                    int index = random.Next(imagePaths.Length);
                    pictureBox6.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car2 = R - R - R;
                    r2 = new Random().Next(1, 7);
                    if (r2 == 1) { x_Car2 = 202; }
                    if (r2 == 2) { x_Car2 = 288; }
                    if (r2 == 3) { x_Car2 = 202; }
                    if (r2 == 4) { x_Car2 = 288; }
                    if (r2 == 5) { x_Car2 = 202; }
                    if (r2 == 6) { x_Car2 = 288; }
                    if (Score > 8)
                    {
                        x_Car2 = 116;
                    }
                    ++Score;
                    --Half_Score;
                }
                Location_Car2(x_Car2, y_Car2);
            }
            if (true)
            {
                if (y_Car3 > 725)
                {
                    int index = random.Next(imagePaths.Length);
                    pictureBox7.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car3 = R - R - R;
                    r3 = new Random().Next(1, 7);
                    if (r3 == 1) { x_Car3 = 374; }
                    if (r3 == 2) { x_Car3 = 460; }
                    if (r3 == 3) { x_Car3 = 374; }
                    if (r3 == 4) { x_Car3 = 460; }
                    if (r3 == 5) { x_Car3 = 374; }
                    if (r3 == 6) { x_Car3 = 460; }
                    if (Score > 10)
                    {
                        x_Car3 = 202;
                    }
                    --Half_Score;
                    ++Score;
                }
                Location_Car3(x_Car3, y_Car3);
            }
            if (Score > 12)
            {
                if (y_Car4 > 725)
                {
                    int index = random.Next(imagePaths.Length);
                    pictureBox8.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car4 = R - R - R;
                    x_Car4 = 288;
                    ++Score;
                    --Half_Score;
                }
                Location_Car4(x_Car4, y_Car4);
            }
            if (Score > 12)
            {
                if (y_Car5 > 725)
                {
                    int index = random.Next(imagePaths.Length);
                    pictureBox9.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car5 = R - R - R;
                    x_Car5 = 374;
                    ++Score;
                    --Half_Score;
                }
                Location_Car5(x_Car5, y_Car5);
            }
            if (Score > 12)
            {
                if (y_Car6 > 725)
                {
                    int index = random.Next(imagePaths.Length);
                    pictureBox10.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car6 = R - R - R; 
                    x_Car6 = 460;
                    ++Score;
                    --Half_Score;
                }
                Location_Car6(x_Car6, y_Car6);
            }
            if (Half == 1)
            {
                pictureBox4.ImageLocation = "My_Car1.png";
            }
            if (Half != 1)
            {
                pictureBox4.ImageLocation = "My_Car2.png";
                label3.Visible = true;
                if (Half_Score <= 0)
                {
                    label3.Visible = false;
                    Half = 1;
                }
            }
            label1.Text = $"Your Score: {Score}";
            label2.Text = $"Your Record: {Record}";
        }
        private void Lose(int Half_Sore)
        {
            if (x_Car1 == x & y_Car1 + 127 >= y & y_Car1 <= y + 120)
            {
                this.Half_Score = Half_Sore;
                if (Half == 0)
                {
                    System.Threading.Thread.Sleep(1500);
                    Environment.Exit(0);
                }
                if (Half != 0)
                {
                    Half -= 1;
                    int index = random.Next(imagePaths.Length);
                    pictureBox5.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car1 = R - R - R;
                    r1 = new Random().Next(1, 7);
                    if (r1 == 1) { x_Car1 = 30; }
                    if (r1 == 2) { x_Car1 = 116; }
                    if (r1 == 3) { x_Car1 = 30; }
                    if (r1 == 4) { x_Car1 = 116; }
                    if (r1 == 5) { x_Car1 = 30; }
                    if (r1 == 6) { x_Car1 = 116; }
                    if (Score > 9)
                    {
                        x_Car1 = 30;
                    }
                    Location_Car1(x_Car1, y_Car1);
                }
            }
            if (x_Car2 == x & y_Car2 + 127 >= y & y_Car2 <= y + 120)
            {
                this.Half_Score = Half_Sore;
                if (Half == 0)
                {
                    System.Threading.Thread.Sleep(1500);
                    Environment.Exit(0);
                }
                if (Half != 0)
                {
                    Half -= 1;
                    int index = random.Next(imagePaths.Length);
                    pictureBox6.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car2 = R - R - R;
                    r2 = new Random().Next(1, 7);
                    if (r2 == 1) { x_Car2 = 202; }
                    if (r2 == 2) { x_Car2 = 288; }
                    if (r2 == 3) { x_Car2 = 202; }
                    if (r2 == 4) { x_Car2 = 288; }
                    if (r2 == 5) { x_Car2 = 202; }
                    if (r2 == 6) { x_Car2 = 288; }
                    if (Score > 8)
                    {
                        x_Car2 = 116;
                    }
                    Location_Car2(x_Car2, y_Car2);
                }
            }
            if (x_Car3 == x & y_Car3 + 127 >= y & y_Car3 <= y + 120)
            {
                this.Half_Score = Half_Sore;
                if (Half == 0)
                {
                    System.Threading.Thread.Sleep(1500);
                    Environment.Exit(0);
                }
                if (Half != 0)
                {
                    Half -= 1;
                    int index = random.Next(imagePaths.Length);
                    pictureBox7.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car3 = R - R - R;
                    r3 = new Random().Next(1, 7);
                    if (r3 == 1) { x_Car3 = 374; }
                    if (r3 == 2) { x_Car3 = 460; }
                    if (r3 == 3) { x_Car3 = 374; }
                    if (r3 == 4) { x_Car3 = 460; }
                    if (r3 == 5) { x_Car3 = 374; }
                    if (r3 == 6) { x_Car3 = 460; }
                    if (Score > 10)
                    {
                        x_Car3 = 202;
                    }
                    Location_Car3(x_Car3, y_Car3);
                }
            }
            if (x_Car4 == x & y_Car4 + 127 >= y & y_Car4 <= y + 120)
            {
                this.Half_Score = Half_Sore;
                if (Half == 0)
                {
                    System.Threading.Thread.Sleep(1500);
                    Environment.Exit(0);
                }
                if (Half != 0)
                {
                    Half -= 1;
                    int index = random.Next(imagePaths.Length);
                    pictureBox8.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car4 = R - R - R;
                    x_Car4 = 288;
                    ++Score;
                    Location_Car4(x_Car4, y_Car4);
                }
            }
            if (x_Car5 == x & y_Car5 + 127 >= y & y_Car5 <= y + 120)
            {
                this.Half_Score = Half_Sore;
                if (Half == 0)
                {
                    System.Threading.Thread.Sleep(1500);
                    Environment.Exit(0);
                }
                if (Half != 0)
                {
                    Half -= 1;
                    int index = random.Next(imagePaths.Length);
                    pictureBox9.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car5 = R - R - R;
                    x_Car5 = 374;
                    ++Score;
                    Location_Car5(x_Car5, y_Car5);
                }
            }
            if (x_Car6 == x & y_Car6 + 127 >= y & y_Car6 <= y + 120)
            {
                this.Half_Score = Half_Sore;
                if (Half == 0)
                {
                    System.Threading.Thread.Sleep(1500);
                    Environment.Exit(0);
                }
                if (Half != 0)
                {
                    Half -= 1;
                    int index = random.Next(imagePaths.Length);
                    pictureBox10.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car6 = R - R - R;
                    x_Car6 = 460;
                    ++Score;
                    Location_Car6(x_Car6, y_Car6);
                }
                if (Half != 0)
                {
                    Half -= 1;
                    int index = random.Next(imagePaths.Length);
                    pictureBox6.ImageLocation = imagePaths[index];
                    R = new Random().Next(100, 500);
                    y_Car2 = R - R - R;
                    r2 = new Random().Next(1, 7);
                    if (r2 == 1) { x_Car2 = 202; }
                    if (r2 == 2) { x_Car2 = 288; }
                    if (r2 == 3) { x_Car2 = 202; }
                    if (r2 == 4) { x_Car2 = 288; }
                    if (r2 == 5) { x_Car2 = 202; }
                    if (r2 == 6) { x_Car2 = 288; }
                    if (Score > 8)
                    {
                        x_Car2 = 116;
                    }
                    Location_Car2(x_Car2, y_Car2);
                }
            }
        }
    }
}