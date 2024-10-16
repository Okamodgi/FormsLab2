﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show(button.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // pictureBox1

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.BackgroundImage = Image.FromFile("E:\\колледж\\kot.png");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(40, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(128, 123);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            // button1

            Button button1 = new Button();
            button1.Location = new System.Drawing.Point(40, 132);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(128, 58);
            button1.TabIndex = 1;
            button1.Text = "Абоненты";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button_Click);

            // button2

            Button button2 = new Button();
            button2.Location = new System.Drawing.Point(40, 196);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(128, 58);
            button2.TabIndex = 2;
            button2.Text = "Управление оборудованием";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button_Click);

            // button3

            Button button3 = new Button();
            button3.Location = new System.Drawing.Point(40, 260);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(128, 58);
            button3.TabIndex = 3;
            button3.Text = "Активы";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(this.button_Click);

            // button4

            Button button4 = new Button();
            button4.Location = new System.Drawing.Point(40, 324);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(128, 58);
            button4.TabIndex = 4;
            button4.Text = "Биллинг";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(this.button_Click);

            // button5

            Button button5 = new Button();
            button5.Location = new System.Drawing.Point(40, 388);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(128, 58);
            button5.TabIndex = 5;
            button5.Text = "Поддержка пользователей";
            button5.UseVisualStyleBackColor = true;
            button5.Click += new System.EventHandler(this.button_Click);

            // button6

            Button button6 = new Button();
            button6.Location = new System.Drawing.Point(40, 452);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(128, 58);
            button6.TabIndex = 6;
            button6.Text = "CRM";
            button6.UseVisualStyleBackColor = true;
            button6.Click += new System.EventHandler(this.button_Click);

            // button7

            Button button7 = new Button();
            button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button7.Location = new System.Drawing.Point(77, 537);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(65, 60);
            button7.TabIndex = 7;
            button7.Text = "поддержка";
            button7.UseVisualStyleBackColor = false;
            button7.Click += new System.EventHandler(this.button_Click);

            // button12

            Button button12 = new Button();
            button12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button12.Location = new System.Drawing.Point(77, 619);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(65, 60);
            button12.TabIndex = 8;
            button12.Text = "?";
            button12.UseVisualStyleBackColor = false;
            button12.Click += new System.EventHandler(this.button_Click);

            // panel1

            Panel panel1 = new Panel();
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(218, 702);
            panel1.TabIndex = 7;


            // label1

            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(224, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(302, 49);
            label1.TabIndex = 8;
            label1.Text = "Абоненты ТНС";

            // radioButton1

            RadioButton radioButton1 = new RadioButton();
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(309, 670);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(92, 20);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Активные";
            radioButton1.UseVisualStyleBackColor = true;

            // radioButton2

            RadioButton radioButton2 = new RadioButton();
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(464, 670);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(109, 20);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Неактивные";
            radioButton2.UseVisualStyleBackColor = true;

            // dataGridView1


            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange();

            var column1 = new DataGridViewTextBoxColumn();
            var column2 = new DataGridViewTextBoxColumn();
            var column3 = new DataGridViewTextBoxColumn();
            var column4 = new DataGridViewTextBoxColumn();

            column1.HeaderText = "ФИО";
            column1.Name = "fio";

            column2.HeaderText = "Абонентский номер";
            column2.Name = "number";

            column3.HeaderText = "Лицевой счёт";
            column3.Name = "schet";

            column4.HeaderText = "Услуги";
            column4.Name = "yslygi";

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3, column4 });

            int n = 2;
            DataGridViewTextBoxColumn[] column = new DataGridViewTextBoxColumn[n];

            for (int i = 0; i < n; i++)
            {
                column[i] = new DataGridViewTextBoxColumn(); // выделение памяти 
                column[i].HeaderText = "Header" + i;
                column[i].Name = "Header" + i;
            }

            dataGridView1.Columns.AddRange(column);
            dataGridView1.Location = new System.Drawing.Point(224, 221);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(487, 443);
            dataGridView1.TabIndex = 13;


            // button8

            Button button8 = new Button();
            button8.Location = new System.Drawing.Point(5, 75);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(200, 83);
            button8.TabIndex = 14;
            button8.Text = "Собрание менеджеров 10:00";
            button8.UseVisualStyleBackColor = true;
            button8.Click += new System.EventHandler(this.button_Click);

            // button9

            Button button9 = new Button();
            button9.Location = new System.Drawing.Point(5, 164);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(200, 78);
            button9.TabIndex = 15;
            button9.Text = "Отчёт по инентаризации";
            button9.UseVisualStyleBackColor = true;
            button9.Click += new System.EventHandler(this.button_Click);

            // button10

            Button button10 = new Button();
            button10.Location = new System.Drawing.Point(6, 249);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(200, 88);
            button10.TabIndex = 16;
            button10.Text = "Собрание акционеров 12:00";
            button10.UseVisualStyleBackColor = true;
            button10.Click += new System.EventHandler(this.button_Click);

            // button11

            Button button11 = new Button();
            button11.Location = new System.Drawing.Point(6, 348);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(200, 93);
            button11.TabIndex = 17;
            button11.Text = "Отчёт по Адмиралтейскому району";
            button11.UseVisualStyleBackColor = true;
            button11.Click += new System.EventHandler(this.button_Click);


            // GroupBox
            GroupBox groupBox1 = new GroupBox();
            groupBox1.Location = new System.Drawing.Point(717, 300);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(235, 300);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "События";

            //Panel
            Panel panel = new Panel();
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;


            panel.Controls.Add(button8);
            panel.Controls.Add(button11);
            panel.Controls.Add(button9);
            panel.Controls.Add(button10);


            groupBox1.Controls.Add(panel);

            // comboBox1
            ComboBox comboBox1 = new ComboBox();
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] {
            "ФИО Пользователя"});
            comboBox1.Location = new System.Drawing.Point(647, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(170, 24);
            comboBox1.TabIndex = 19;

            // pictureBox2

            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.BackgroundImage = Image.FromFile("E:\\колледж\\kot.png");
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox2.Location = new System.Drawing.Point(842, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(67, 65);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;

            // Form1

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 702);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(comboBox1);
            this.Controls.Add(groupBox1);
            this.Controls.Add(dataGridView1);
            this.Controls.Add(radioButton2);
            this.Controls.Add(radioButton1);
            this.Controls.Add(label1);
            this.Controls.Add(panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(pictureBox2);

            System.Drawing.Drawing2D.GraphicsPath myPath =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, button7.Width, button7.Height);
            Region myRegion = new Region(myPath);
            button7.Region = myRegion;

            System.Drawing.Drawing2D.GraphicsPath myPath2 =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath2.AddEllipse(0, 0, button7.Width, button7.Height);
            Region myRegion2 = new Region(myPath2);
            button12.Region = myRegion2;

        }
    }
}
