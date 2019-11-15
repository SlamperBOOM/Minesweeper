using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool win = false;
        uint time = 0;
        uint minestotal = 0, mines = 0;
        int sizex;
        int sizey;
        Block[,] pool = new Block[30,30];
        bool start = false;
        bool pause = false;
        bool load = false;

        public void showpole() //рисует поле после выигрыша\проигрыша
        {
            for (int i = 0; i < sizex; i++)
                for (int j = 0; j < sizey; j++)
                {
                    switch (pool[i, j].count)
                    {
                        case -1: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.bomb; break; }
                        case 0: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.zero; break; }
                        case 1: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num1; break; }
                        case 2: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num2; break; }
                        case 3: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num3; break; }
                        case 4: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num4; break; }
                        case 5: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num5; break; }
                        case 6: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num6; break; }
                        case 7: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num7; break; }
                        case 8: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num8; break; }
                    }
                }
        }

        public void midbt(int x, int y, int[] x1, int[] y1, EventArgs e)//обрабатывает нажатие средней кнопки
        {
            if (checkmine(x, y, true) == 0)
            for (int k = 0; k < 8; k++)
            {
                if (!(x + x1[k] == sizex || x + x1[k] == -1 || y + y1[k] == sizey || y + y1[k] == -1) && 
                !win && pool[x + x1[k], y + y1[k]].flag != 1) click(this.Controls["p_" + (x + x1[k]) + "_" + (y + y1[k])], e, "Left");
            }
        }

        public void flagset(int x, int y, int[] x1, int[] y1, bool e)
        {
            if (pool[x, y].count <= 0 || !start || e)
            {
                for (int k = 0; k < 8; k++)
                {
                    if (!(x + x1[k] == sizex || x + x1[k] == -1 || y + y1[k] == sizey || y + y1[k] == -1))
                    {
                        if (pool[x + x1[k], y + y1[k]].count > 0) pool[x + x1[k], y + y1[k]].flag = 3;
                    }
                    if (x + x1[k] == sizex || x + x1[k] == -1 || y + y1[k] == sizey || y + y1[k] == -1 ||
                        pool[x + x1[k], y + y1[k]].mine || pool[x + x1[k], y + y1[k]].flag != 0 ||
                        pool[x + x1[k], y + y1[k]].count > 0 ) continue;
                    else { pool[x + x1[k], y + y1[k]].flag = 3; flagset(x + x1[k], y + y1[k], x1, y1, false); }
                }
            }
        }

        public void draw()
        {
            for (int i = 0; i < sizex; i++)
                for (int j = 0; j < sizey; j++)
                {
                    switch (pool[i, j].flag)
                    {
                        case 0: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.closed; break; }
                        case 1: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.flaged; break; }
                        case 2: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.inform; break; }
                        case 3:
                            {
                                switch (pool[i, j].count)
                                {
                                    case 0: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.zero; break; }
                                    case 1: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num1; break; }
                                    case 2: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num2; break; }
                                    case 3: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num3; break; }
                                    case 4: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num4; break; }
                                    case 5: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num5; break; }
                                    case 6: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num6; break; }
                                    case 7: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num7; break; }
                                    case 8: { this.Controls["p_" + i + "_" + j].BackgroundImage = Properties.Resources.num8; break; }
                                }
                                break;
                            }
                    }
                }
        }

        public int checkmine(int x, int y, bool check)
        {
            int mine = 0, flags = 0;
            int[] x1 = { 0, 1, 1, 1, 0, -1, -1, -1 };
            int[] y1 = { 1, 1, 0, -1, -1, -1, 0, 1 };
            for (int i = 0; i < 8; i++)
            {
                if (x + x1[i] == sizex || x + x1[i] == -1 || y + y1[i] == sizey || y + y1[i] == -1) continue;
                else if (pool[x + x1[i], y + y1[i]].mine) mine++; if (pool[x + x1[i], y + y1[i]].flag == 1) flags++;
            }
            if (!check) return mine;
            else return mine - flags;
        }

        public void createfield(int x, int y)//создание поля
        {
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    this.Controls["p_" + i.ToString() + "_" + j.ToString()].Visible = true;
                }
            this.Width = 12 + 20 * y + 12 + 16;
            this.Height = 40 + 20 * x + 12 + 48;
        }

        public void sbros()//возврат поля в исходное состояние
        { 
             for (int i = 0; i < 30; i++)
                 for (int j = 0; j < 30; j++)
                 {
                     pool[i, j].mine = false;
                     pool[i, j].flag = 0;
                     pool[i, j].count = 0;
                     this.Controls["p_" + i.ToString() + "_" + j.ToString()].Visible = false;
                 }
        }

        public void viccheck()//проверка выигрыша
        {
            uint m = minestotal;
            int pole = sizex * sizey;
            for (int i = 0; i < sizex; i++)
                for (int j = 0; j < sizey; j++)
                {
                    if (pool[i, j].mine && pool[i, j].flag == 1)
                    {
                        m--;
                    }
                    if (!(pool[i, j].mine) && pool[i, j].flag == 3)
                    {
                        pole--;
                    }
                }
            if (m == 0 || pole == minestotal)
            {
                timer1.Enabled = false;
                showpole();
                MessageBox.Show("Вы победили! Ваше время: " + time + " секунд");
                win = true;
            }
        }

        public void click(object sender, EventArgs e, string but)//нажатие на плитку
        {
            int[] x1 = { 0, 1, 1, 1, 0, -1, -1, -1 };
            int[] y1 = { 1, 1, 0, -1, -1, -1, 0, 1 };
            //определение координаты нажатия
            int x = 0, y = 0;
            string s = "";
            if (sender is Panel) s = (sender as Panel).Name;
            int a = s.IndexOf('_', 2);
                if (a == 3)
                {
                    x = Convert.ToInt32(s[2].ToString());
                    if (a + 1 == s.Length - 1) y = Convert.ToInt32(s[4].ToString());
                    else y = Convert.ToInt32(s[4].ToString() + s[5].ToString());
                }
                else
                {
                    x = Convert.ToInt32(s[2].ToString() + s[3].ToString());
                    if (a + 1 == s.Length - 1) y = Convert.ToInt32(s[5].ToString());
                    else y = Convert.ToInt32(s[5].ToString() + s[6].ToString());
                }

            //обработка нажатия
            if (!start)
            {
                uint m = mines;
                DateTime date = DateTime.Now;
                double prob, bombs;
                bombs = minestotal;
                prob = bombs / (sizex * sizey) * 100;
                while (m > 0)
                for (int i = 0; i < sizex; i++)
                    for (int j = 0; j < sizey; j++)
                    {
                        if (m == 0) continue;
                        Random r = new Random();
                        int d = r.Next(0, 100);
                        if (d <= prob && !pool[i, j].mine && !(x == i && j == y))
                        {
                            pool[i, j].mine = true;
                            pool[i, j].count = -1;
                            m--;
                            Thread.Sleep(5);
                        }
                    }
                        MessageBox.Show((DateTime.Now - date).Seconds.ToString() + " " + (DateTime.Now - date).Milliseconds.ToString());
                for (int i = 0; i < sizex; i++)
                    for (int j = 0; j < sizey; j++)
                    {
                        if (pool[i, j].mine) continue;
                        else pool[i, j].count = checkmine(i, j, false);
                    }
                timer1.Enabled = true;
                flagset(x, y, x1, y1, false);
                start = true;
                draw();
            }
            else if (load)
            {
                паузапродолжитьToolStripMenuItem_Click(sender, e);
                timer1.Enabled = true;
                load = false;
            }
            if (but == "Left")
            {
                if (pool[x, y].mine)
                {
                    timer1.Enabled = false;
                    showpole();
                    this.Controls["p_" + x + "_" + y].BackgroundImage = Properties.Resources.nobomb;
                    MessageBox.Show("Вы проиграли");
                    pool[x, y].flag = 3;
                    win = true;
                }
                else if (pool[x, y].flag == 0)
                {
                    flagset(x, y, x1, y1, false);
                    pool[x, y].flag = 3;
                    draw();
                    viccheck();
                }
            }
            else if (but == "Right")
            {
                if (pool[x, y].flag == 0 && mines > 0)
                {
                    mines--;
                    pool[x, y].flag = 1;
                    lbmine.Text = mines.ToString();
                    draw();
                    viccheck();
                }
                else if (pool[x, y].flag == 1)
                {
                    mines++;
                    pool[x, y].flag = 2;
                    lbmine.Text = mines.ToString();
                    draw();
                }
                else if (pool[x, y].flag == 2)
                {
                    pool[x, y].flag = 0;
                    this.Controls["p_" + x + "_" + y].BackgroundImage = Properties.Resources.closed;
                    draw();
                }
            }
            else if (but == "Middle")
            {
                midbt(x, y, x1, y1, e);
                flagset(x, y, x1, y1, checkmine(x, y, true) == 0);
                draw();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo check = new FileInfo("save.txt");
            if (check.Exists) продолжитьИгруToolStripMenuItem.Text = "Загрузить игру(сохранение есть)";
            else продолжитьИгруToolStripMenuItem.Text = "Загрузить игру(сохранения нет)";
            this.Width = 720;
            this.Height = 480;
            for (int i = 0; i < 30; i++)
                for (int j = 0; j < 30; j++)
                {
                    Panel pn = new Panel();
                    pn.Location = new Point(12 + 20 * j, 48 + 20 * i);
                    pn.BackgroundImage = Properties.Resources.closed;
                    pn.BackgroundImageLayout = panel1.BackgroundImageLayout;
                    pn.Name = "p_" + i.ToString() + "_" + j.ToString();
                    pn.Size = new Size(20, 20);
                    pn.MouseClick += new MouseEventHandler(pn_MouseClick);
                    pn.Visible = false;
                    this.Controls.Add(pn);
                    pool[i, j] = new Block();
                }
        }

        void pn_MouseClick(object sender, MouseEventArgs e)
        {
            if((!win && !pause)||(pause && load)) p_0_0_MouseClick(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e) //время
        {
            time ++;
            if (time < 10) { lbtime.Text = "00" + time.ToString(); }
            else if (time < 100) { lbtime.Text = "0" + time.ToString(); }
            else { lbtime.Text = time.ToString(); }
            FileInfo check = new FileInfo("save.txt");
            if (check.Exists) продолжитьИгруToolStripMenuItem.Text = "Загрузить игру(сохранение есть)";
            else продолжитьИгруToolStripMenuItem.Text = "Загрузить игру(сохранения нет)";
        }

        private void паузапродолжитьToolStripMenuItem_Click(object sender, EventArgs e) //пауза/продолжить
        {
            if (!pause)
            {
                pause = true;
                timer1.Enabled = false;
            }
            else
            {
                pause = false;
                timer1.Enabled = true;
            }

        }

        private void p_0_0_MouseClick(object sender, MouseEventArgs e)//обработка клавиши мыши
        {
            click(sender, e, e.Button.ToString());
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            lbtime.Left = this.Width - 43 - 30;
        }

        private void легкоToolStripMenuItem_Click(object sender, EventArgs e) //начало игры - легко
        {
            timer1.Enabled = false;
            time = 0;
            lbtime.Text = "000";
            sizex = 9;
            sizey = 9;
            minestotal = 10;
            mines = minestotal;
            sbros();
            createfield(sizex, sizey);
            lbmine.Text = mines.ToString();
            draw();
            start = false;
            win = false;
            pause = false;
            load = false;
        }

        private void среднеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            time = 0;
            lbtime.Text = "000";
            sizex = 16;
            sizey = 16;
            minestotal = 40;
            mines = minestotal;
            sbros();
            createfield(sizex, sizey);
            lbmine.Text = mines.ToString();
            draw();
            start = false;
            win = false;
            pause = false;
            load = false;
        }

        private void сложноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            time = 0;
            lbtime.Text = "000";
            sizex = 16;
            sizey = 30;
            minestotal = 99;
            mines = minestotal;
            sbros();
            createfield(sizex, sizey);
            lbmine.Text = mines.ToString();
            draw();
            start = false;
            win = false;
            pause = false;
            load = false;
        }

        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            time = 0;
            lbtime.Text = "000";
            sizey = Convert.ToInt32(tbheigth.Text);
            sizex = Convert.ToInt32(tbwidth.Text);
            minestotal = Convert.ToUInt32(tbmines.Text);
            mines = minestotal;
            createfield(sizex, sizey);
            lbmine.Text = mines.ToString();
            sbros();
            draw();
            start = false;
            win = false;
            pause = false;
            load = false;
        }

        private void продолжитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo check = new FileInfo("save.txt");
            if (check.Exists)
            {
                timer1.Enabled = false;
                StreamReader f = new StreamReader("save.txt");
                time = Convert.ToUInt32(f.ReadLine());
                time--;
                timer1_Tick(sender, e);
                sizex = Convert.ToInt32(f.ReadLine());
                sizey = Convert.ToInt32(f.ReadLine());
                minestotal = Convert.ToUInt32(f.ReadLine());
                mines = Convert.ToUInt32(f.ReadLine());
                sbros();
                for (int i = 0; i < sizex; i++)
                    for (int j = 0; j < sizey; j++)
                    {
                        pool[i, j].mine = Convert.ToBoolean(f.ReadLine());
                        pool[i, j].flag = Convert.ToInt32(f.ReadLine());
                        pool[i, j].count = Convert.ToInt32(f.ReadLine());
                    }
                createfield(sizex, sizey);
                lbmine.Text = mines.ToString();
                draw();
                start = true;
                win = false;
                pause = true;
                load = true;
                f.Close();
            }
        }

        private void сохранитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("save.txt");
            f.WriteLine(time);
            f.WriteLine(sizex);
            f.WriteLine(sizey);
            f.WriteLine(minestotal);
            f.WriteLine(mines);
            for (int i = 0; i < sizex; i++)
                for (int j = 0; j < sizey; j++)
                {
                    f.WriteLine(pool[i, j].mine);
                    f.WriteLine(pool[i, j].flag);
                    f.WriteLine(pool[i, j].count);
                }
            f.Close();
        }
    }
}
