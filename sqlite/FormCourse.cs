using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace sqlite
{
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button4.Text == "Додати курс")
            {
                textBox1.Visible = false;
                this.textBox1.Text = " ";
                this.textBox2.Text = " ";
                this.button4.Text = "Зберегти";
            }
            else
            {
                try
                {
                    // int Tid = Convert.ToInt32(textBox1.Text);
                    string TNam = textBox2.Text;


                    SQLiteConnection sqlite_conn =
                    new SQLiteConnection("Data Source=School.db;Version=3;New=False;Compress=True;");
                    sqlite_conn.Open();
                    string add = "INSERT INTO Courses (Named) VALUES ('" + TNam + "')";
                    SQLiteCommand sqlite_cmd =
                    new SQLiteCommand(add, sqlite_conn);
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_conn.Close();
                }
                catch
                {
                    MessageBox.Show("Введіть дані про курс");
                }
                this.button4.Text = "Додати курс";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (this.button5.Text == "Видалити курс")
            {
             this.button5.Text = "Видалити";
      MessageBox.Show("Введіть ID курсу даля видалення");
              
            }
            else
            {             
              this.button5.Text = "Видалити";
                try
                {
                    int Tid = Convert.ToInt32(textBox1.Text);
                    SQLiteConnection sqlite_conn =
                    new SQLiteConnection("Data Source=School.db;Version=3;New=False;Compress=True;");
                    sqlite_conn.Open();
                    string dell = "Delete FROM Courses Where ID =" + Tid;
                    SQLiteCommand sqlite_cmd =
                    new SQLiteCommand(dell, sqlite_conn);
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_conn.Close(); 
                    MessageBox.Show("Курс з ІD " + Tid + " Видалено!!!! Оновіть інформацію про курси");           
                }
                catch
                {
                    MessageBox.Show("Введіть ID");
                }
                this.button5.Text = "Видалити курс";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
