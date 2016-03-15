using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Finisar.SQLite;
using System.Data.SQLite;



namespace sqlite
{
    public partial class Form1 : Form
    {
        private sqliteclass coursdb = null;
        private string sCurDir = string.Empty;
        private string sPath = string.Empty;
        private string sSql = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
           
           sPath = Path.Combine(Application.StartupPath, "School.db");

           coursdb = new sqliteclass();
           sSql = "select Named from  Courses";
           DataRow[] datarows = coursdb.drExecute(sPath, sSql);
           if (datarows == null)
           {
               MessageBox.Show("Помилка читання");
               coursdb = null;
               return;
           }
           Text = "";
            foreach (DataRow dr in datarows )
            {
                

                this.comboBox2.Items.Add(dr["Named"].ToString());
                this.comboBox3.Items.Add(dr["Named"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCourses.Visible = true;
            panelStudents.Visible = false;
            panelTeachers.Visible = false;
            
            coursdb = new sqliteclass();
            sSql = "select * from  Courses";
            DataRow[] datarows = coursdb.drExecute(sPath, sSql);
           if (datarows == null)
           {
                MessageBox.Show("Помилка читання");         
                coursdb = null;
                return;
            }
            Text = "";
            int i = 0, j= 0;
            dataGridView1.ColumnCount = 2;

            foreach (DataRow dr in datarows) {j++;}

            dataGridView1.RowCount = j;

           foreach (DataRow dr in datarows )
            { 
                dataGridView1[0, i].Value = dr["ID"].ToString();
                dataGridView1[1, i].Value = dr["Named"].ToString();
                i++;
            }               
        }

        private void BStudents_Click(object sender, EventArgs e)
        {
            panelStudents.Visible = true;
            panelCourses.Visible = false;
            panelTeachers.Visible = false;
            coursdb = new sqliteclass();
            sSql = "SELECT * from  Students";
            DataRow[] datarows = coursdb.drExecute(sPath, sSql);
            if (datarows == null)
            {
                MessageBox.Show("Помилка читання");         
                coursdb = null;
                return;
            }
            Text = "";
            int i = 0, j= 0;
            dataGridView1.ColumnCount = 5;

            foreach (DataRow dr in datarows) {j++;}
            if (j==0) 
                j++;
            dataGridView1.RowCount = j;
           
            foreach (DataRow dr in datarows)
            {
                dataGridView1[0, i].Value = dr["ID_Student"].ToString();
                dataGridView1[1, i].Value = dr["SurName"].ToString();
                dataGridView1[2, i].Value = dr["Name"].ToString();
                dataGridView1[3, i].Value = dr["Phone"].ToString();
                dataGridView1[4, i].Value = dr["ID_Cours"].ToString();
                i++;
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelTeachers.Visible = true;
            panelCourses.Visible = false;
            panelStudents.Visible = false;
            coursdb = new sqliteclass();
            sSql = "SELECT * from Teachers";
            DataRow[] datarows = coursdb.drExecute(sPath, sSql);
            if (datarows == null)
            {
                MessageBox.Show("Помилка читання");         
                coursdb = null;
                return;
            }
            Text = "";
            int i = 0, j= 0;
            dataGridView1.ColumnCount = 6;

            foreach (DataRow dr in datarows) {j++;}

            dataGridView1.RowCount = j;

            foreach (DataRow dr in datarows)
            {
                dataGridView1[0, i].Value = dr["ID_Teacher"].ToString();
                dataGridView1[1, i].Value = dr["SurName"].ToString();
                dataGridView1[2, i].Value = dr["Name"].ToString();
                dataGridView1[3, i].Value = dr["Phone"].ToString();
                dataGridView1[4, i].Value = dr["ID_CoursTeach"].ToString();
                dataGridView1[5, i].Value = dr["NameCoursLearn"].ToString();
                i++;
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {             
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void редагуванняКурсівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormNameAboutProgram = new FormCourse();
            FormNameAboutProgram.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string look = this.comboBox2.Text;
            sSql = "SELECT Students.SurName, Students.Name, Students.Phone, Courses.Named FROM Courses INNER JOIN Students ON Courses.ID = Students.ID_Cours WHERE (Courses.Named = '" + look + "'";
            coursdb = new sqliteclass();
            DataRow[] datarows = coursdb.drExecute(sPath, sSql);
            if (datarows == null)
            {
                MessageBox.Show("Помилка читання");
                coursdb = null;
                return;
            }
            Text = "";
            int i = 0, j = 0;
            dataGridView2.ColumnCount = 4;

            foreach (DataRow dr in datarows) { j++; }
            if (j == 0) j = 1;
            dataGridView2.RowCount = j;

            foreach (DataRow dr in datarows)
            {
                dataGridView2[0, i].Value = dr["SurName"].ToString();
                dataGridView2[1, i].Value = dr["Name"].ToString();
                dataGridView2[2, i].Value = dr["Phone"].ToString();
                dataGridView2[3, i].Value = dr["Named"].ToString();
                i++;

            } 
            sSql = "SELECT Students.SurName, Students.Name, Students.Phone, Courses.Named FROM Courses INNER JOIN Students ON Courses.ID = Students.ID_Cours WHERE        (Courses.Named = '" + look + "'";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void редагуванняСтудентівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormNameAboutProgram = new FormStudent();
            FormNameAboutProgram.ShowDialog();
        }

        private void редагуванняВикладачівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormNameAboutProgram = new FormTeacher();
            FormNameAboutProgram.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string look = this.comboBox2.Text;
            sSql = "SELECT Teachers.SurName, Teachers.Name, Teachers.Phone, Courses.Named FROM Teachers INNER JOIN Courses ON Teachers.ID_CoursTeach = Courses.ID WHERE        (Courses.Named = '"+ look +"')";
            coursdb = new sqliteclass();
            DataRow[] datarows = coursdb.drExecute(sPath, sSql);
            if (datarows == null)
            {
                MessageBox.Show("Помилка читання");
                coursdb = null;
                return;
            }
            Text = "";
            int i = 0, j = 0;
            dataGridView2.ColumnCount = 4;

            foreach (DataRow dr in datarows) { j++; }
            if (j == 0) j = 1;
            dataGridView2.RowCount = j;

            foreach (DataRow dr in datarows)
            {
                dataGridView2[0, i].Value = dr["SurName"].ToString();
                dataGridView2[1, i].Value = dr["Name"].ToString();
                dataGridView2[2, i].Value = dr["Phone"].ToString();
                dataGridView2[3, i].Value = dr["Named"].ToString();
                i++;

            } 
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            string look = this.comboBox3.Text;
            sSql = "SELECT        Students.SurName, Students.Name, Students.Phone, Courses.Named FROM Courses INNER JOIN Students ON Courses.ID = Students.ID_Cours WHERE (Courses.Named ='" + look + "')";
            coursdb = new sqliteclass();
            DataRow[] datarows = coursdb.drExecute(sPath, sSql);
            if (datarows == null)
            {
                MessageBox.Show("Помилка читання");
                coursdb = null;
                return;
            }
            Text = "";
            int i = 0, j = 0;
            dataGridView2.ColumnCount = 4;

            foreach (DataRow dr in datarows) { j++; }
            if (j == 0) j = 1;
            dataGridView2.RowCount = j;

            foreach (DataRow dr in datarows)
            {
                dataGridView2[0, i].Value = dr["SurName"].ToString();
                dataGridView2[1, i].Value = dr["Name"].ToString();
                dataGridView2[2, i].Value = dr["Phone"].ToString();
                dataGridView2[3, i].Value = dr["Named"].ToString();
                i++;

            } 
        }

        private void bZnStudent_Click(object sender, EventArgs e)
        {
            panelStudents.Visible = true;
            panelCourses.Visible = false;
            panelTeachers.Visible = false;
            coursdb = new sqliteclass();
            string lok=this.tZnStudent.Text;

            sSql = "SELECT * from  Students WHERE (SurName ='" + lok + "')";
            DataRow[] datarows = coursdb.drExecute(sPath, sSql);
            if (datarows == null)
            {
                MessageBox.Show("Помилка читання");
                coursdb = null;
                return;
            }
            Text = "";
            int i = 0, j = 0;
            dataGridView1.ColumnCount = 5;

            foreach (DataRow dr in datarows) { j++; }
            if (j == 0)
                j++;
            dataGridView1.RowCount = j;

            foreach (DataRow dr in datarows)
            {
                dataGridView1[0, i].Value = dr["ID_Student"].ToString();
                dataGridView1[1, i].Value = dr["SurName"].ToString();
                dataGridView1[2, i].Value = dr["Name"].ToString();
                dataGridView1[3, i].Value = dr["Phone"].ToString();
                dataGridView1[4, i].Value = dr["ID_Cours"].ToString();
                i++;
            }      
        }

        private void bZnTeacher_Click(object sender, EventArgs e)
        {
            panelTeachers.Visible = true;
            panelCourses.Visible = false;
            panelStudents.Visible = false;

            string lok = this.tZnTeacher.Text;

            coursdb = new sqliteclass();
            sSql = "SELECT * from Teachers WHERE (SurName ='" + lok + "')";
            DataRow[] datarows = coursdb.drExecute(sPath, sSql);
            if (datarows == null)
            {
                MessageBox.Show("Помилка читання");
                coursdb = null;
                return;
            }
            Text = "";
            int i = 0, j = 0;
            dataGridView1.ColumnCount = 6;

            foreach (DataRow dr in datarows) { j++; }
            if (j == 0) j = 1;
            dataGridView1.RowCount = j;

            foreach (DataRow dr in datarows)
            {
                dataGridView1[0, i].Value = dr["ID_Teacher"].ToString();
                dataGridView1[1, i].Value = dr["SurName"].ToString();
                dataGridView1[2, i].Value = dr["Name"].ToString();
                dataGridView1[3, i].Value = dr["Phone"].ToString();
                dataGridView1[4, i].Value = dr["ID_CoursTeach"].ToString();
                dataGridView1[5, i].Value = dr["NameCoursLearn"].ToString();
                i++;
            } 
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormNameAboutProgram = new ProProg();
            FormNameAboutProgram.ShowDialog();
        }
    }
}
