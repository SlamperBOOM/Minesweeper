namespace Minesweeper
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbtime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.легкоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ширинамакс50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbwidth = new System.Windows.Forms.ToolStripTextBox();
            this.высотамакс50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbheigth = new System.Windows.Forms.ToolStripTextBox();
            this.минымакс2499ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbmines = new System.Windows.Forms.ToolStripTextBox();
            this.начатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продолжитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паузапродолжитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbmine = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbtime.Location = new System.Drawing.Point(469, 24);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(43, 24);
            this.lbtime.TabIndex = 0;
            this.lbtime.Text = "000";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.сохранитьИгруToolStripMenuItem,
            this.продолжитьИгруToolStripMenuItem,
            this.паузапродолжитьToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.менюToolStripMenuItem.Text = "Меню ";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.легкоToolStripMenuItem,
            this.среднеToolStripMenuItem,
            this.сложноToolStripMenuItem,
            this.customToolStripMenuItem});
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            // 
            // легкоToolStripMenuItem
            // 
            this.легкоToolStripMenuItem.Name = "легкоToolStripMenuItem";
            this.легкоToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.легкоToolStripMenuItem.Text = "Легко";
            this.легкоToolStripMenuItem.Click += new System.EventHandler(this.легкоToolStripMenuItem_Click);
            // 
            // среднеToolStripMenuItem
            // 
            this.среднеToolStripMenuItem.Name = "среднеToolStripMenuItem";
            this.среднеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.среднеToolStripMenuItem.Text = "Средне";
            this.среднеToolStripMenuItem.Click += new System.EventHandler(this.среднеToolStripMenuItem_Click);
            // 
            // сложноToolStripMenuItem
            // 
            this.сложноToolStripMenuItem.Name = "сложноToolStripMenuItem";
            this.сложноToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сложноToolStripMenuItem.Text = "Сложно";
            this.сложноToolStripMenuItem.Click += new System.EventHandler(this.сложноToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ширинамакс50ToolStripMenuItem,
            this.tbwidth,
            this.высотамакс50ToolStripMenuItem,
            this.tbheigth,
            this.минымакс2499ToolStripMenuItem,
            this.tbmines,
            this.начатьToolStripMenuItem});
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // ширинамакс50ToolStripMenuItem
            // 
            this.ширинамакс50ToolStripMenuItem.Name = "ширинамакс50ToolStripMenuItem";
            this.ширинамакс50ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ширинамакс50ToolStripMenuItem.Text = "Ширина (макс. 30)";
            // 
            // tbwidth
            // 
            this.tbwidth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbwidth.Name = "tbwidth";
            this.tbwidth.Size = new System.Drawing.Size(100, 23);
            // 
            // высотамакс50ToolStripMenuItem
            // 
            this.высотамакс50ToolStripMenuItem.Name = "высотамакс50ToolStripMenuItem";
            this.высотамакс50ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.высотамакс50ToolStripMenuItem.Text = "Высота (макс. 30)";
            // 
            // tbheigth
            // 
            this.tbheigth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbheigth.Name = "tbheigth";
            this.tbheigth.Size = new System.Drawing.Size(100, 23);
            // 
            // минымакс2499ToolStripMenuItem
            // 
            this.минымакс2499ToolStripMenuItem.Name = "минымакс2499ToolStripMenuItem";
            this.минымакс2499ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.минымакс2499ToolStripMenuItem.Text = "Мины (макс. 899)";
            // 
            // tbmines
            // 
            this.tbmines.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbmines.Name = "tbmines";
            this.tbmines.Size = new System.Drawing.Size(100, 23);
            // 
            // начатьToolStripMenuItem
            // 
            this.начатьToolStripMenuItem.Name = "начатьToolStripMenuItem";
            this.начатьToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.начатьToolStripMenuItem.Text = "Начать";
            this.начатьToolStripMenuItem.Click += new System.EventHandler(this.начатьToolStripMenuItem_Click);
            // 
            // сохранитьИгруToolStripMenuItem
            // 
            this.сохранитьИгруToolStripMenuItem.Name = "сохранитьИгруToolStripMenuItem";
            this.сохранитьИгруToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.сохранитьИгруToolStripMenuItem.Text = "Сохранить игру";
            this.сохранитьИгруToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИгруToolStripMenuItem_Click);
            // 
            // продолжитьИгруToolStripMenuItem
            // 
            this.продолжитьИгруToolStripMenuItem.Name = "продолжитьИгруToolStripMenuItem";
            this.продолжитьИгруToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.продолжитьИгруToolStripMenuItem.Text = "Загрузить игру";
            this.продолжитьИгруToolStripMenuItem.Click += new System.EventHandler(this.продолжитьИгруToolStripMenuItem_Click);
            // 
            // паузапродолжитьToolStripMenuItem
            // 
            this.паузапродолжитьToolStripMenuItem.Name = "паузапродолжитьToolStripMenuItem";
            this.паузапродолжитьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.паузапродолжитьToolStripMenuItem.Text = "Пауза";
            this.паузапродолжитьToolStripMenuItem.Click += new System.EventHandler(this.паузапродолжитьToolStripMenuItem_Click);
            // 
            // lbmine
            // 
            this.lbmine.AutoSize = true;
            this.lbmine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbmine.Location = new System.Drawing.Point(8, 24);
            this.lbmine.Name = "lbmine";
            this.lbmine.Size = new System.Drawing.Size(43, 24);
            this.lbmine.TabIndex = 129;
            this.lbmine.Text = "000";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-200, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 130;
            this.panel1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(946, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbmine);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem легкоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продолжитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ширинамакс50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tbwidth;
        private System.Windows.Forms.ToolStripMenuItem высотамакс50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tbheigth;
        private System.Windows.Forms.ToolStripMenuItem минымакс2499ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tbmines;
        private System.Windows.Forms.ToolStripMenuItem начатьToolStripMenuItem;
        private System.Windows.Forms.Label lbmine;
        private System.Windows.Forms.ToolStripMenuItem паузапродолжитьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИгруToolStripMenuItem;
    }
}

