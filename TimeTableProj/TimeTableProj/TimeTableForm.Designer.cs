using System.Drawing;
using System.IO;

namespace TimeTableProj
{
    partial class TimeTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTableForm));
            this.Menu = new System.Windows.Forms.Panel();
            this.generate = new System.Windows.Forms.Button();
            this.design = new System.Windows.Forms.Button();
            this.Teachers = new System.Windows.Forms.Button();
            this.Classes = new System.Windows.Forms.Button();
            this.Hours = new System.Windows.Forms.Button();
            this.timeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.scroll = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Panel();
            this.TimeTableField = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Fri7 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.Fri6 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.Fri5 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.Fri4 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.Fri3 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.Fri2 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.Fri1 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.Thu7 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.Thu6 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.Thu5 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.Thu4 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.Thu3 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.Thu2 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.Thu1 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.Wed7 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.Wed6 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.Wed5 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.Wed4 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.Wed3 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.Wed2 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.Wed1 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.Tue7 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.Tue6 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.Tue5 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.Tue4 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.Tue3 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.Tue2 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.Tue1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.Mon7 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Mon6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Mon5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Mon4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Mon3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Mon2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Mon1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Offset = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dayNames = new System.Windows.Forms.Panel();
            this.fri = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.thu = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.wed = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).BeginInit();
            this.scroll.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Content.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Offset.SuspendLayout();
            this.dayNames.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.generate);
            this.Menu.Controls.Add(this.design);
            this.Menu.Controls.Add(this.Teachers);
            this.Menu.Controls.Add(this.Classes);
            this.Menu.Controls.Add(this.Hours);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1478, 73);
            this.Menu.TabIndex = 0;
            // 
            // generate
            // 
            this.generate.Dock = System.Windows.Forms.DockStyle.Left;
            this.generate.Image = ((System.Drawing.Image)(resources.GetObject("generate.Image")));
            this.generate.Location = new System.Drawing.Point(300, 0);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 73);
            this.generate.TabIndex = 5;
            this.generate.Text = "Генерирай";
            this.generate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // design
            // 
            this.design.Dock = System.Windows.Forms.DockStyle.Left;
            this.design.Image = ((System.Drawing.Image)(resources.GetObject("design.Image")));
            this.design.Location = new System.Drawing.Point(225, 0);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(75, 73);
            this.design.TabIndex = 4;
            this.design.Text = "Дизайн";
            this.design.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.design.UseVisualStyleBackColor = true;
            this.design.Click += new System.EventHandler(this.design_Click);
            // 
            // Teachers
            // 
            this.Teachers.Dock = System.Windows.Forms.DockStyle.Left;
            this.Teachers.Image = ((System.Drawing.Image)(resources.GetObject("Teachers.Image")));
            this.Teachers.Location = new System.Drawing.Point(150, 0);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(75, 73);
            this.Teachers.TabIndex = 2;
            this.Teachers.Text = "Учители";
            this.Teachers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Teachers.UseVisualStyleBackColor = true;
            this.Teachers.Click += new System.EventHandler(this.Teachers_Click);
            // 
            // Classes
            // 
            this.Classes.Dock = System.Windows.Forms.DockStyle.Left;
            this.Classes.Image = ((System.Drawing.Image)(resources.GetObject("Classes.Image")));
            this.Classes.Location = new System.Drawing.Point(75, 0);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(75, 73);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Класове";
            this.Classes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Classes.UseVisualStyleBackColor = true;
            this.Classes.Click += new System.EventHandler(this.Classes_Click);
            // 
            // Hours
            // 
            this.Hours.Dock = System.Windows.Forms.DockStyle.Left;
            this.Hours.Image = ((System.Drawing.Image)(resources.GetObject("Hours.Image")));
            this.Hours.Location = new System.Drawing.Point(0, 0);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(75, 73);
            this.Hours.TabIndex = 0;
            this.Hours.Text = "Предмети";
            this.Hours.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Hours.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Hours.UseVisualStyleBackColor = true;
            this.Hours.Click += new System.EventHandler(this.Hours_Click);
            // 
            // timeTableBindingSource
            // 
            this.timeTableBindingSource.DataSource = typeof(MyTimeTable.Models.TimeTable);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1478, 1);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // scroll
            // 
            this.scroll.AutoScroll = true;
            this.scroll.AutoSize = true;
            this.scroll.Controls.Add(this.panel1);
            this.scroll.Controls.Add(this.Content);
            this.scroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scroll.Location = new System.Drawing.Point(0, 74);
            this.scroll.Name = "scroll";
            this.scroll.Size = new System.Drawing.Size(1478, 535);
            this.scroll.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1452, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 535);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 535);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // Content
            // 
            this.Content.AutoScroll = true;
            this.Content.AutoSize = true;
            this.Content.BackColor = System.Drawing.Color.White;
            this.Content.Controls.Add(this.TimeTableField);
            this.Content.Controls.Add(this.label10);
            this.Content.Controls.Add(this.panel3);
            this.Content.Controls.Add(this.label5);
            this.Content.Controls.Add(this.label19);
            this.Content.Controls.Add(this.dayNames);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1478, 535);
            this.Content.TabIndex = 7;
            this.Content.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Paint);
            // 
            // TimeTableField
            // 
            this.TimeTableField.AutoScroll = true;
            this.TimeTableField.BackColor = System.Drawing.Color.White;
            this.TimeTableField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeTableField.Location = new System.Drawing.Point(1, 62);
            this.TimeTableField.Name = "TimeTableField";
            this.TimeTableField.Size = new System.Drawing.Size(1477, 473);
            this.TimeTableField.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(1, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1477, 1);
            this.label10.TabIndex = 28;
            this.label10.Text = "label10";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Fri7);
            this.panel3.Controls.Add(this.label80);
            this.panel3.Controls.Add(this.Fri6);
            this.panel3.Controls.Add(this.label78);
            this.panel3.Controls.Add(this.Fri5);
            this.panel3.Controls.Add(this.label76);
            this.panel3.Controls.Add(this.Fri4);
            this.panel3.Controls.Add(this.label74);
            this.panel3.Controls.Add(this.Fri3);
            this.panel3.Controls.Add(this.label72);
            this.panel3.Controls.Add(this.Fri2);
            this.panel3.Controls.Add(this.label70);
            this.panel3.Controls.Add(this.Fri1);
            this.panel3.Controls.Add(this.label68);
            this.panel3.Controls.Add(this.Thu7);
            this.panel3.Controls.Add(this.label66);
            this.panel3.Controls.Add(this.Thu6);
            this.panel3.Controls.Add(this.label64);
            this.panel3.Controls.Add(this.Thu5);
            this.panel3.Controls.Add(this.label62);
            this.panel3.Controls.Add(this.Thu4);
            this.panel3.Controls.Add(this.label60);
            this.panel3.Controls.Add(this.Thu3);
            this.panel3.Controls.Add(this.label58);
            this.panel3.Controls.Add(this.Thu2);
            this.panel3.Controls.Add(this.label56);
            this.panel3.Controls.Add(this.Thu1);
            this.panel3.Controls.Add(this.label54);
            this.panel3.Controls.Add(this.Wed7);
            this.panel3.Controls.Add(this.label52);
            this.panel3.Controls.Add(this.Wed6);
            this.panel3.Controls.Add(this.label50);
            this.panel3.Controls.Add(this.Wed5);
            this.panel3.Controls.Add(this.label48);
            this.panel3.Controls.Add(this.Wed4);
            this.panel3.Controls.Add(this.label46);
            this.panel3.Controls.Add(this.Wed3);
            this.panel3.Controls.Add(this.label44);
            this.panel3.Controls.Add(this.Wed2);
            this.panel3.Controls.Add(this.label42);
            this.panel3.Controls.Add(this.Wed1);
            this.panel3.Controls.Add(this.label40);
            this.panel3.Controls.Add(this.Tue7);
            this.panel3.Controls.Add(this.label38);
            this.panel3.Controls.Add(this.Tue6);
            this.panel3.Controls.Add(this.label36);
            this.panel3.Controls.Add(this.Tue5);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.Tue4);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.Tue3);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.Tue2);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.Tue1);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.Mon7);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.Mon6);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.Mon5);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.Mon4);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.Mon3);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.Mon2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.Mon1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.Offset);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1477, 30);
            this.panel3.TabIndex = 21;
            // 
            // Fri7
            // 
            this.Fri7.Dock = System.Windows.Forms.DockStyle.Left;
            this.Fri7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fri7.Location = new System.Drawing.Point(1411, 0);
            this.Fri7.Name = "Fri7";
            this.Fri7.Size = new System.Drawing.Size(39, 30);
            this.Fri7.TabIndex = 97;
            this.Fri7.Text = "7";
            this.Fri7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label80
            // 
            this.label80.BackColor = System.Drawing.Color.Black;
            this.label80.Dock = System.Windows.Forms.DockStyle.Left;
            this.label80.Location = new System.Drawing.Point(1410, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(1, 30);
            this.label80.TabIndex = 96;
            this.label80.Text = "label80";
            // 
            // Fri6
            // 
            this.Fri6.Dock = System.Windows.Forms.DockStyle.Left;
            this.Fri6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fri6.Location = new System.Drawing.Point(1371, 0);
            this.Fri6.Name = "Fri6";
            this.Fri6.Size = new System.Drawing.Size(39, 30);
            this.Fri6.TabIndex = 95;
            this.Fri6.Text = "6";
            this.Fri6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            this.label78.BackColor = System.Drawing.Color.Black;
            this.label78.Dock = System.Windows.Forms.DockStyle.Left;
            this.label78.Location = new System.Drawing.Point(1370, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(1, 30);
            this.label78.TabIndex = 94;
            this.label78.Text = "label78";
            // 
            // Fri5
            // 
            this.Fri5.Dock = System.Windows.Forms.DockStyle.Left;
            this.Fri5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fri5.Location = new System.Drawing.Point(1331, 0);
            this.Fri5.Name = "Fri5";
            this.Fri5.Size = new System.Drawing.Size(39, 30);
            this.Fri5.TabIndex = 93;
            this.Fri5.Text = "5";
            this.Fri5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label76
            // 
            this.label76.BackColor = System.Drawing.Color.Black;
            this.label76.Dock = System.Windows.Forms.DockStyle.Left;
            this.label76.Location = new System.Drawing.Point(1330, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(1, 30);
            this.label76.TabIndex = 92;
            this.label76.Text = "label76";
            // 
            // Fri4
            // 
            this.Fri4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Fri4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fri4.Location = new System.Drawing.Point(1291, 0);
            this.Fri4.Name = "Fri4";
            this.Fri4.Size = new System.Drawing.Size(39, 30);
            this.Fri4.TabIndex = 91;
            this.Fri4.Text = "4";
            this.Fri4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label74
            // 
            this.label74.BackColor = System.Drawing.Color.Black;
            this.label74.Dock = System.Windows.Forms.DockStyle.Left;
            this.label74.Location = new System.Drawing.Point(1290, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(1, 30);
            this.label74.TabIndex = 90;
            this.label74.Text = "label74";
            // 
            // Fri3
            // 
            this.Fri3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Fri3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fri3.Location = new System.Drawing.Point(1251, 0);
            this.Fri3.Name = "Fri3";
            this.Fri3.Size = new System.Drawing.Size(39, 30);
            this.Fri3.TabIndex = 89;
            this.Fri3.Text = "3";
            this.Fri3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label72
            // 
            this.label72.BackColor = System.Drawing.Color.Black;
            this.label72.Dock = System.Windows.Forms.DockStyle.Left;
            this.label72.Location = new System.Drawing.Point(1250, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(1, 30);
            this.label72.TabIndex = 88;
            this.label72.Text = "label72";
            // 
            // Fri2
            // 
            this.Fri2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Fri2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fri2.Location = new System.Drawing.Point(1211, 0);
            this.Fri2.Name = "Fri2";
            this.Fri2.Size = new System.Drawing.Size(39, 30);
            this.Fri2.TabIndex = 87;
            this.Fri2.Text = "2";
            this.Fri2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.BackColor = System.Drawing.Color.Black;
            this.label70.Dock = System.Windows.Forms.DockStyle.Left;
            this.label70.Location = new System.Drawing.Point(1210, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(1, 30);
            this.label70.TabIndex = 86;
            this.label70.Text = "label70";
            // 
            // Fri1
            // 
            this.Fri1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Fri1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fri1.Location = new System.Drawing.Point(1171, 0);
            this.Fri1.Name = "Fri1";
            this.Fri1.Size = new System.Drawing.Size(39, 30);
            this.Fri1.TabIndex = 85;
            this.Fri1.Text = "1";
            this.Fri1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.BackColor = System.Drawing.Color.Black;
            this.label68.Dock = System.Windows.Forms.DockStyle.Left;
            this.label68.Location = new System.Drawing.Point(1170, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(1, 30);
            this.label68.TabIndex = 84;
            this.label68.Text = "label68";
            // 
            // Thu7
            // 
            this.Thu7.Dock = System.Windows.Forms.DockStyle.Left;
            this.Thu7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thu7.Location = new System.Drawing.Point(1131, 0);
            this.Thu7.Name = "Thu7";
            this.Thu7.Size = new System.Drawing.Size(39, 30);
            this.Thu7.TabIndex = 83;
            this.Thu7.Text = "7";
            this.Thu7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label66
            // 
            this.label66.BackColor = System.Drawing.Color.Black;
            this.label66.Dock = System.Windows.Forms.DockStyle.Left;
            this.label66.Location = new System.Drawing.Point(1130, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(1, 30);
            this.label66.TabIndex = 82;
            this.label66.Text = "label66";
            // 
            // Thu6
            // 
            this.Thu6.Dock = System.Windows.Forms.DockStyle.Left;
            this.Thu6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thu6.Location = new System.Drawing.Point(1091, 0);
            this.Thu6.Name = "Thu6";
            this.Thu6.Size = new System.Drawing.Size(39, 30);
            this.Thu6.TabIndex = 81;
            this.Thu6.Text = "6";
            this.Thu6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.BackColor = System.Drawing.Color.Black;
            this.label64.Dock = System.Windows.Forms.DockStyle.Left;
            this.label64.Location = new System.Drawing.Point(1090, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(1, 30);
            this.label64.TabIndex = 80;
            this.label64.Text = "label64";
            // 
            // Thu5
            // 
            this.Thu5.Dock = System.Windows.Forms.DockStyle.Left;
            this.Thu5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thu5.Location = new System.Drawing.Point(1051, 0);
            this.Thu5.Name = "Thu5";
            this.Thu5.Size = new System.Drawing.Size(39, 30);
            this.Thu5.TabIndex = 79;
            this.Thu5.Text = "5";
            this.Thu5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.BackColor = System.Drawing.Color.Black;
            this.label62.Dock = System.Windows.Forms.DockStyle.Left;
            this.label62.Location = new System.Drawing.Point(1050, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(1, 30);
            this.label62.TabIndex = 78;
            this.label62.Text = "label62";
            // 
            // Thu4
            // 
            this.Thu4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Thu4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thu4.Location = new System.Drawing.Point(1011, 0);
            this.Thu4.Name = "Thu4";
            this.Thu4.Size = new System.Drawing.Size(39, 30);
            this.Thu4.TabIndex = 77;
            this.Thu4.Text = "4";
            this.Thu4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.BackColor = System.Drawing.Color.Black;
            this.label60.Dock = System.Windows.Forms.DockStyle.Left;
            this.label60.Location = new System.Drawing.Point(1010, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(1, 30);
            this.label60.TabIndex = 76;
            this.label60.Text = "label60";
            // 
            // Thu3
            // 
            this.Thu3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Thu3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thu3.Location = new System.Drawing.Point(971, 0);
            this.Thu3.Name = "Thu3";
            this.Thu3.Size = new System.Drawing.Size(39, 30);
            this.Thu3.TabIndex = 75;
            this.Thu3.Text = "3";
            this.Thu3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.BackColor = System.Drawing.Color.Black;
            this.label58.Dock = System.Windows.Forms.DockStyle.Left;
            this.label58.Location = new System.Drawing.Point(970, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(1, 30);
            this.label58.TabIndex = 74;
            this.label58.Text = "label58";
            // 
            // Thu2
            // 
            this.Thu2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Thu2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thu2.Location = new System.Drawing.Point(931, 0);
            this.Thu2.Name = "Thu2";
            this.Thu2.Size = new System.Drawing.Size(39, 30);
            this.Thu2.TabIndex = 73;
            this.Thu2.Text = "2";
            this.Thu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.BackColor = System.Drawing.Color.Black;
            this.label56.Dock = System.Windows.Forms.DockStyle.Left;
            this.label56.Location = new System.Drawing.Point(930, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(1, 30);
            this.label56.TabIndex = 72;
            this.label56.Text = "label56";
            // 
            // Thu1
            // 
            this.Thu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Thu1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thu1.Location = new System.Drawing.Point(891, 0);
            this.Thu1.Name = "Thu1";
            this.Thu1.Size = new System.Drawing.Size(39, 30);
            this.Thu1.TabIndex = 71;
            this.Thu1.Text = "1";
            this.Thu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.BackColor = System.Drawing.Color.Black;
            this.label54.Dock = System.Windows.Forms.DockStyle.Left;
            this.label54.Location = new System.Drawing.Point(890, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(1, 30);
            this.label54.TabIndex = 70;
            this.label54.Text = "label54";
            this.label54.Click += new System.EventHandler(this.label54_Click);
            // 
            // Wed7
            // 
            this.Wed7.Dock = System.Windows.Forms.DockStyle.Left;
            this.Wed7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wed7.Location = new System.Drawing.Point(851, 0);
            this.Wed7.Name = "Wed7";
            this.Wed7.Size = new System.Drawing.Size(39, 30);
            this.Wed7.TabIndex = 69;
            this.Wed7.Text = "7";
            this.Wed7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Wed7.Click += new System.EventHandler(this.label55_Click);
            // 
            // label52
            // 
            this.label52.BackColor = System.Drawing.Color.Black;
            this.label52.Dock = System.Windows.Forms.DockStyle.Left;
            this.label52.Location = new System.Drawing.Point(850, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(1, 30);
            this.label52.TabIndex = 68;
            this.label52.Text = "label52";
            // 
            // Wed6
            // 
            this.Wed6.Dock = System.Windows.Forms.DockStyle.Left;
            this.Wed6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wed6.Location = new System.Drawing.Point(811, 0);
            this.Wed6.Name = "Wed6";
            this.Wed6.Size = new System.Drawing.Size(39, 30);
            this.Wed6.TabIndex = 67;
            this.Wed6.Text = "6";
            this.Wed6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.Black;
            this.label50.Dock = System.Windows.Forms.DockStyle.Left;
            this.label50.Location = new System.Drawing.Point(810, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(1, 30);
            this.label50.TabIndex = 66;
            this.label50.Text = "label50";
            // 
            // Wed5
            // 
            this.Wed5.Dock = System.Windows.Forms.DockStyle.Left;
            this.Wed5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wed5.Location = new System.Drawing.Point(771, 0);
            this.Wed5.Name = "Wed5";
            this.Wed5.Size = new System.Drawing.Size(39, 30);
            this.Wed5.TabIndex = 65;
            this.Wed5.Text = "5";
            this.Wed5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.Black;
            this.label48.Dock = System.Windows.Forms.DockStyle.Left;
            this.label48.Location = new System.Drawing.Point(770, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(1, 30);
            this.label48.TabIndex = 64;
            this.label48.Text = "label48";
            this.label48.Click += new System.EventHandler(this.label48_Click);
            // 
            // Wed4
            // 
            this.Wed4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Wed4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wed4.Location = new System.Drawing.Point(731, 0);
            this.Wed4.Name = "Wed4";
            this.Wed4.Size = new System.Drawing.Size(39, 30);
            this.Wed4.TabIndex = 63;
            this.Wed4.Text = "4";
            this.Wed4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Wed4.Click += new System.EventHandler(this.label49_Click);
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.Color.Black;
            this.label46.Dock = System.Windows.Forms.DockStyle.Left;
            this.label46.Location = new System.Drawing.Point(730, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(1, 30);
            this.label46.TabIndex = 62;
            this.label46.Text = "label46";
            // 
            // Wed3
            // 
            this.Wed3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Wed3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wed3.Location = new System.Drawing.Point(691, 0);
            this.Wed3.Name = "Wed3";
            this.Wed3.Size = new System.Drawing.Size(39, 30);
            this.Wed3.TabIndex = 61;
            this.Wed3.Text = "3";
            this.Wed3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.Black;
            this.label44.Dock = System.Windows.Forms.DockStyle.Left;
            this.label44.Location = new System.Drawing.Point(690, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(1, 30);
            this.label44.TabIndex = 60;
            this.label44.Text = "label44";
            // 
            // Wed2
            // 
            this.Wed2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Wed2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wed2.Location = new System.Drawing.Point(651, 0);
            this.Wed2.Name = "Wed2";
            this.Wed2.Size = new System.Drawing.Size(39, 30);
            this.Wed2.TabIndex = 59;
            this.Wed2.Text = "2";
            this.Wed2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.Black;
            this.label42.Dock = System.Windows.Forms.DockStyle.Left;
            this.label42.Location = new System.Drawing.Point(650, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(1, 30);
            this.label42.TabIndex = 58;
            this.label42.Text = "label42";
            // 
            // Wed1
            // 
            this.Wed1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Wed1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wed1.Location = new System.Drawing.Point(611, 0);
            this.Wed1.Name = "Wed1";
            this.Wed1.Size = new System.Drawing.Size(39, 30);
            this.Wed1.TabIndex = 57;
            this.Wed1.Text = "1";
            this.Wed1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Black;
            this.label40.Dock = System.Windows.Forms.DockStyle.Left;
            this.label40.Location = new System.Drawing.Point(610, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(1, 30);
            this.label40.TabIndex = 56;
            this.label40.Text = "label40";
            // 
            // Tue7
            // 
            this.Tue7.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tue7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tue7.Location = new System.Drawing.Point(571, 0);
            this.Tue7.Name = "Tue7";
            this.Tue7.Size = new System.Drawing.Size(39, 30);
            this.Tue7.TabIndex = 55;
            this.Tue7.Text = "7";
            this.Tue7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.Black;
            this.label38.Dock = System.Windows.Forms.DockStyle.Left;
            this.label38.Location = new System.Drawing.Point(570, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(1, 30);
            this.label38.TabIndex = 54;
            this.label38.Text = "label38";
            // 
            // Tue6
            // 
            this.Tue6.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tue6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tue6.Location = new System.Drawing.Point(531, 0);
            this.Tue6.Name = "Tue6";
            this.Tue6.Size = new System.Drawing.Size(39, 30);
            this.Tue6.TabIndex = 53;
            this.Tue6.Text = "6";
            this.Tue6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Black;
            this.label36.Dock = System.Windows.Forms.DockStyle.Left;
            this.label36.Location = new System.Drawing.Point(530, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(1, 30);
            this.label36.TabIndex = 52;
            this.label36.Text = "label36";
            // 
            // Tue5
            // 
            this.Tue5.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tue5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tue5.Location = new System.Drawing.Point(491, 0);
            this.Tue5.Name = "Tue5";
            this.Tue5.Size = new System.Drawing.Size(39, 30);
            this.Tue5.TabIndex = 51;
            this.Tue5.Text = "5";
            this.Tue5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.Black;
            this.label34.Dock = System.Windows.Forms.DockStyle.Left;
            this.label34.Location = new System.Drawing.Point(490, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(1, 30);
            this.label34.TabIndex = 50;
            this.label34.Text = "label34";
            // 
            // Tue4
            // 
            this.Tue4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tue4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tue4.Location = new System.Drawing.Point(451, 0);
            this.Tue4.Name = "Tue4";
            this.Tue4.Size = new System.Drawing.Size(39, 30);
            this.Tue4.TabIndex = 49;
            this.Tue4.Text = "4";
            this.Tue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tue4.Click += new System.EventHandler(this.label35_Click);
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Black;
            this.label32.Dock = System.Windows.Forms.DockStyle.Left;
            this.label32.Location = new System.Drawing.Point(450, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(1, 30);
            this.label32.TabIndex = 48;
            this.label32.Text = "label32";
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // Tue3
            // 
            this.Tue3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tue3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tue3.Location = new System.Drawing.Point(411, 0);
            this.Tue3.Name = "Tue3";
            this.Tue3.Size = new System.Drawing.Size(39, 30);
            this.Tue3.TabIndex = 47;
            this.Tue3.Text = "3";
            this.Tue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tue3.Click += new System.EventHandler(this.label33_Click);
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Black;
            this.label30.Dock = System.Windows.Forms.DockStyle.Left;
            this.label30.Location = new System.Drawing.Point(410, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(1, 30);
            this.label30.TabIndex = 46;
            this.label30.Text = "label30";
            // 
            // Tue2
            // 
            this.Tue2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tue2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tue2.Location = new System.Drawing.Point(371, 0);
            this.Tue2.Name = "Tue2";
            this.Tue2.Size = new System.Drawing.Size(39, 30);
            this.Tue2.TabIndex = 45;
            this.Tue2.Text = "2";
            this.Tue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Black;
            this.label28.Dock = System.Windows.Forms.DockStyle.Left;
            this.label28.Location = new System.Drawing.Point(370, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(1, 30);
            this.label28.TabIndex = 44;
            this.label28.Text = "label28";
            // 
            // Tue1
            // 
            this.Tue1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tue1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tue1.Location = new System.Drawing.Point(331, 0);
            this.Tue1.Name = "Tue1";
            this.Tue1.Size = new System.Drawing.Size(39, 30);
            this.Tue1.TabIndex = 43;
            this.Tue1.Text = "1";
            this.Tue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Black;
            this.label26.Dock = System.Windows.Forms.DockStyle.Left;
            this.label26.Location = new System.Drawing.Point(330, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(1, 30);
            this.label26.TabIndex = 42;
            this.label26.Text = "label26";
            // 
            // Mon7
            // 
            this.Mon7.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mon7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mon7.Location = new System.Drawing.Point(291, 0);
            this.Mon7.Name = "Mon7";
            this.Mon7.Size = new System.Drawing.Size(39, 30);
            this.Mon7.TabIndex = 41;
            this.Mon7.Text = "7";
            this.Mon7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Black;
            this.label22.Dock = System.Windows.Forms.DockStyle.Left;
            this.label22.Location = new System.Drawing.Point(290, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1, 30);
            this.label22.TabIndex = 40;
            this.label22.Text = "label22";
            // 
            // Mon6
            // 
            this.Mon6.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mon6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mon6.Location = new System.Drawing.Point(251, 0);
            this.Mon6.Name = "Mon6";
            this.Mon6.Size = new System.Drawing.Size(39, 30);
            this.Mon6.TabIndex = 39;
            this.Mon6.Text = "6";
            this.Mon6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Dock = System.Windows.Forms.DockStyle.Left;
            this.label18.Location = new System.Drawing.Point(250, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1, 30);
            this.label18.TabIndex = 38;
            this.label18.Text = "label18";
            // 
            // Mon5
            // 
            this.Mon5.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mon5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mon5.Location = new System.Drawing.Point(211, 0);
            this.Mon5.Name = "Mon5";
            this.Mon5.Size = new System.Drawing.Size(39, 30);
            this.Mon5.TabIndex = 37;
            this.Mon5.Text = "5";
            this.Mon5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Dock = System.Windows.Forms.DockStyle.Left;
            this.label16.Location = new System.Drawing.Point(210, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1, 30);
            this.label16.TabIndex = 36;
            this.label16.Text = "label16";
            // 
            // Mon4
            // 
            this.Mon4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mon4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mon4.Location = new System.Drawing.Point(171, 0);
            this.Mon4.Name = "Mon4";
            this.Mon4.Size = new System.Drawing.Size(39, 30);
            this.Mon4.TabIndex = 35;
            this.Mon4.Text = "4";
            this.Mon4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Location = new System.Drawing.Point(170, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1, 30);
            this.label14.TabIndex = 34;
            this.label14.Text = "label14";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Mon3
            // 
            this.Mon3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mon3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mon3.Location = new System.Drawing.Point(131, 0);
            this.Mon3.Name = "Mon3";
            this.Mon3.Size = new System.Drawing.Size(39, 30);
            this.Mon3.TabIndex = 33;
            this.Mon3.Text = "3";
            this.Mon3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mon3.Click += new System.EventHandler(this.label15_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Location = new System.Drawing.Point(130, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1, 30);
            this.label12.TabIndex = 32;
            this.label12.Text = "label12";
            // 
            // Mon2
            // 
            this.Mon2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mon2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mon2.Location = new System.Drawing.Point(91, 0);
            this.Mon2.Name = "Mon2";
            this.Mon2.Size = new System.Drawing.Size(39, 30);
            this.Mon2.TabIndex = 31;
            this.Mon2.Text = "2";
            this.Mon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Location = new System.Drawing.Point(90, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1, 30);
            this.label11.TabIndex = 30;
            this.label11.Text = "label11";
            // 
            // Mon1
            // 
            this.Mon1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mon1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mon1.Location = new System.Drawing.Point(51, 0);
            this.Mon1.Name = "Mon1";
            this.Mon1.Size = new System.Drawing.Size(39, 30);
            this.Mon1.TabIndex = 28;
            this.Mon1.Text = "1";
            this.Mon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Location = new System.Drawing.Point(1476, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 30);
            this.label8.TabIndex = 27;
            this.label8.Text = "label8";
            // 
            // Offset
            // 
            this.Offset.Controls.Add(this.label7);
            this.Offset.Dock = System.Windows.Forms.DockStyle.Left;
            this.Offset.Location = new System.Drawing.Point(0, 0);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(51, 30);
            this.Offset.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(50, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(1, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1477, 1);
            this.label5.TabIndex = 20;
            this.label5.Text = "label5";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.Dock = System.Windows.Forms.DockStyle.Left;
            this.label19.Location = new System.Drawing.Point(0, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(1, 505);
            this.label19.TabIndex = 18;
            this.label19.Text = "label19";
            // 
            // dayNames
            // 
            this.dayNames.Controls.Add(this.fri);
            this.dayNames.Controls.Add(this.label4);
            this.dayNames.Controls.Add(this.thu);
            this.dayNames.Controls.Add(this.label23);
            this.dayNames.Controls.Add(this.wed);
            this.dayNames.Controls.Add(this.label21);
            this.dayNames.Controls.Add(this.tue);
            this.dayNames.Controls.Add(this.label3);
            this.dayNames.Controls.Add(this.mon);
            this.dayNames.Controls.Add(this.panel2);
            this.dayNames.Controls.Add(this.label25);
            this.dayNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.dayNames.Location = new System.Drawing.Point(0, 0);
            this.dayNames.Name = "dayNames";
            this.dayNames.Size = new System.Drawing.Size(1478, 30);
            this.dayNames.TabIndex = 11;
            // 
            // fri
            // 
            this.fri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(166)))), ((int)(((byte)(40)))));
            this.fri.Dock = System.Windows.Forms.DockStyle.Left;
            this.fri.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fri.Location = new System.Drawing.Point(1172, 0);
            this.fri.Name = "fri";
            this.fri.Size = new System.Drawing.Size(281, 30);
            this.fri.TabIndex = 34;
            this.fri.Text = "Петък";
            this.fri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(1171, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "label4";
            // 
            // thu
            // 
            this.thu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(166)))), ((int)(((byte)(40)))));
            this.thu.Dock = System.Windows.Forms.DockStyle.Left;
            this.thu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thu.Location = new System.Drawing.Point(892, 0);
            this.thu.Name = "thu";
            this.thu.Size = new System.Drawing.Size(279, 30);
            this.thu.TabIndex = 32;
            this.thu.Text = "Четвъртък";
            this.thu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Black;
            this.label23.Dock = System.Windows.Forms.DockStyle.Left;
            this.label23.Location = new System.Drawing.Point(891, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(1, 30);
            this.label23.TabIndex = 31;
            this.label23.Text = "label23";
            // 
            // wed
            // 
            this.wed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(166)))), ((int)(((byte)(40)))));
            this.wed.Dock = System.Windows.Forms.DockStyle.Left;
            this.wed.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wed.Location = new System.Drawing.Point(612, 0);
            this.wed.Name = "wed";
            this.wed.Size = new System.Drawing.Size(279, 30);
            this.wed.TabIndex = 30;
            this.wed.Text = "Сряда";
            this.wed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Black;
            this.label21.Dock = System.Windows.Forms.DockStyle.Left;
            this.label21.Location = new System.Drawing.Point(611, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(1, 30);
            this.label21.TabIndex = 29;
            this.label21.Text = "label21";
            // 
            // tue
            // 
            this.tue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(166)))), ((int)(((byte)(40)))));
            this.tue.Dock = System.Windows.Forms.DockStyle.Left;
            this.tue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tue.Location = new System.Drawing.Point(332, 0);
            this.tue.Name = "tue";
            this.tue.Size = new System.Drawing.Size(279, 30);
            this.tue.TabIndex = 28;
            this.tue.Text = "Вторик";
            this.tue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(331, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "label3";
            // 
            // mon
            // 
            this.mon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(166)))), ((int)(((byte)(40)))));
            this.mon.Dock = System.Windows.Forms.DockStyle.Left;
            this.mon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mon.Location = new System.Drawing.Point(52, 0);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(279, 30);
            this.mon.TabIndex = 26;
            this.mon.Text = "Понеделник";
            this.mon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 30);
            this.panel2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(50, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Black;
            this.label25.Dock = System.Windows.Forms.DockStyle.Left;
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(1, 30);
            this.label25.TabIndex = 23;
            this.label25.Text = "label25";
            // 
            // TimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 609);
            this.Controls.Add(this.scroll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeTableForm";
            this.Text = "Автоматичен генератор на седмично разписание";
            this.Load += new System.EventHandler(this.TimeTable_Load);
            this.ResizeEnd += new System.EventHandler(this.TimeTableForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.TimeTableForm_SizeChanged);
            this.Resize += new System.EventHandler(this.TimeTableForm_Resize);
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).EndInit();
            this.scroll.ResumeLayout(false);
            this.scroll.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Content.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Offset.ResumeLayout(false);
            this.dayNames.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button Teachers;
        private System.Windows.Forms.Button Classes;
        private System.Windows.Forms.Button Hours;
        private System.Windows.Forms.BindingSource timeTableBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel scroll;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel dayNames;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label fri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label thu;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label wed;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label tue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button design;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Fri7;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label Fri6;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label Fri5;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label Fri4;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label Fri3;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label Fri2;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label Fri1;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label Thu7;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label Thu6;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label Thu5;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label Thu4;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label Thu3;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label Thu2;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label Thu1;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label Wed7;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label Wed6;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label Wed5;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label Wed4;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label Wed3;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label Wed2;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label Wed1;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label Tue7;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label Tue6;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label Tue5;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label Tue4;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label Tue3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label Tue2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label Tue1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label Mon7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label Mon6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label Mon5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Mon4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Mon3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Mon2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Mon1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel Offset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel TimeTableField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}