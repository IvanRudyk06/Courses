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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button4.Text == "Додати викладача")
            {
                this.tBId.Text = " ";
                this.tBSurname.Text = " ";
                this.tBName.Text = " ";
                this.tBPhone.Text = " ";
                this.tBCours.Text = " ";
                this.tBCoL.Text = " ";

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
                    string tNamCoL = tBCoL.Text;
                    SQLiteConnection sqlite_conn =
                    new SQLiteConnection("Data Source=School.db;Version=3;New=False;Compress=True;");
                    sqlite_conn.Open();
                    string add = "INSERT INTO Teachers (SurName,Name,Phone,ID_CoursTeach,NameCoursLearn) VALUES ('" + tSurname + "','" + tName + "','" + tPhone + "','" + tCours + "','" + tNamCoL + "')";
                    SQLiteCommand sqlite_cmd =
                    new SQLiteCommand(add, sqlite_conn);
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_conn.Close();
               }
                catch
                {
                    MessageBox.Show("Введіть дані про Викладачів");
                }
                this.button4.Text = "Додати викладача";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.button5.Text == "Видалити викладача")
            {
                this.button5.Text = "Видалити";
                MessageBox.Show("Введіть ID викладача даля видалення");

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
                    string dell = "Delete FROM Teachers Where ID_Teacher =" + Tid;
                    SQLiteCommand sqlite_cmd =
                    new SQLiteCommand(dell, sqlite_conn);
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_conn.Close();
                    MessageBox.Show("Викладача з ІD " + Tid + " Видалено!!!! Оновіть інформацію про викладачів");
                }
                catch
                {
                    MessageBox.Show("Введіть ID");
                }
                this.button5.Text = "Видалити викладача";
            }
        }
    }
}
