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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button4.Text == "Додати студента")
            {
                this.tBId.Text = " ";
                this.tBSurname.Text = " ";
                this.tBName.Text = " ";
                this.tBPhone.Text = " ";
                this.tBCours.Text = " ";
                this.button4.Text = "Зберегти";
                MessageBox.Show("Введіть дані, ID можна не вводити ");
            }
            else
            {
                try{
                 //   int tId = Convert.ToInt32(tBId.Text);
                    string tSurname = tBSurname.Text;
                    string tName = tBName.Text;
                    int tPhone = Convert.ToInt32(tBPhone.Text);
                    int tCours = Convert.ToInt32(tBCours.Text);
                    
                    SQLiteConnection sqlite_conn =
                    new SQLiteConnection("Data Source=School.db;Version=3;New=False;Compress=True;");
                    sqlite_conn.Open();
                    string add = "INSERT INTO Students (SurName,Name,Phone,ID_Cours) VALUES ('"  + tSurname + "','" + tName + "','" + tPhone + "','" + tCours + "')";
                    SQLiteCommand sqlite_cmd =
                    new SQLiteCommand(add, sqlite_conn);
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_conn.Close();
                }
                catch
                {
                    MessageBox.Show("Введіть дані про Студентів");
                }
                this.button4.Text = "Додати студента";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.button5.Text == "Видалити студента")
            {
                this.button5.Text = "Видалити";
                MessageBox.Show("Введіть ID студента даля видалення");

            }
            else
            {
                this.button5.Text = "Видалити";
                try
                {
                    int Tid = Convert.ToInt32(tBId.Text);
                    SQLiteConnection sqlite_conn =
                    new SQLiteConnection("Data Source=School.db;Version=3;New=False;Compress=True;");
                    sqlite_conn.Open();
                    string dell = "Delete FROM Students Where ID_Student =" + Tid;
                    SQLiteCommand sqlite_cmd =
                    new SQLiteCommand(dell, sqlite_conn);
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_conn.Close();
                    MessageBox.Show("Студента з ІD " + Tid + " Видалено!!!! Оновіть інформацію про студентів");
                }
                catch
                {
                    MessageBox.Show("Введіть ID");
                }
                this.button5.Text = "Видалити студента";
            }
        }
    }
}
