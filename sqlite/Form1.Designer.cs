namespace sqlite
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BStudents = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняКурсівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняСтудентівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняВикладачівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCourses = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelStudents = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTeachers = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bZnStudent = new System.Windows.Forms.Button();
            this.bZnTeacher = new System.Windows.Forms.Button();
            this.tZnStudent = new System.Windows.Forms.TextBox();
            this.tZnTeacher = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelCourses.SuspendLayout();
            this.panelStudents.SuspendLayout();
            this.panelTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Курси";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(451, 230);
            this.dataGridView1.TabIndex = 3;
            // 
            // BStudents
            // 
            this.BStudents.Location = new System.Drawing.Point(646, 300);
            this.BStudents.Name = "BStudents";
            this.BStudents.Size = new System.Drawing.Size(211, 41);
            this.BStudents.TabIndex = 4;
            this.BStudents.Text = "Студенти";
            this.BStudents.UseVisualStyleBackColor = true;
            this.BStudents.Click += new System.EventHandler(this.BStudents_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Викладачі";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редагуванняКурсівToolStripMenuItem,
            this.редагуванняСтудентівToolStripMenuItem,
            this.редагуванняВикладачівToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // редагуванняКурсівToolStripMenuItem
            // 
            this.редагуванняКурсівToolStripMenuItem.Name = "редагуванняКурсівToolStripMenuItem";
            this.редагуванняКурсівToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.редагуванняКурсівToolStripMenuItem.Text = "Редагування Курсів";
            this.редагуванняКурсівToolStripMenuItem.Click += new System.EventHandler(this.редагуванняКурсівToolStripMenuItem_Click);
            // 
            // редагуванняСтудентівToolStripMenuItem
            // 
            this.редагуванняСтудентівToolStripMenuItem.Name = "редагуванняСтудентівToolStripMenuItem";
            this.редагуванняСтудентівToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.редагуванняСтудентівToolStripMenuItem.Text = "Редагування Студентів";
            this.редагуванняСтудентівToolStripMenuItem.Click += new System.EventHandler(this.редагуванняСтудентівToolStripMenuItem_Click);
            // 
            // редагуванняВикладачівToolStripMenuItem
            // 
            this.редагуванняВикладачівToolStripMenuItem.Name = "редагуванняВикладачівToolStripMenuItem";
            this.редагуванняВикладачівToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.редагуванняВикладачівToolStripMenuItem.Text = "Редагування Викладачів";
            this.редагуванняВикладачівToolStripMenuItem.Click += new System.EventHandler(this.редагуванняВикладачівToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // panelCourses
            // 
            this.panelCourses.Controls.Add(this.label4);
            this.panelCourses.Controls.Add(this.label3);
            this.panelCourses.Location = new System.Drawing.Point(12, 22);
            this.panelCourses.Name = "panelCourses";
            this.panelCourses.Size = new System.Drawing.Size(451, 34);
            this.panelCourses.TabIndex = 15;
            this.panelCourses.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(273, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // panelStudents
            // 
            this.panelStudents.Controls.Add(this.label9);
            this.panelStudents.Controls.Add(this.label8);
            this.panelStudents.Controls.Add(this.label7);
            this.panelStudents.Controls.Add(this.label6);
            this.panelStudents.Controls.Add(this.label5);
            this.panelStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelStudents.Location = new System.Drawing.Point(12, 27);
            this.panelStudents.Name = "panelStudents";
            this.panelStudents.Size = new System.Drawing.Size(451, 32);
            this.panelStudents.TabIndex = 16;
            this.panelStudents.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Курс";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ім\'я";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Прізвище";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // panelTeachers
            // 
            this.panelTeachers.Controls.Add(this.label15);
            this.panelTeachers.Controls.Add(this.label10);
            this.panelTeachers.Controls.Add(this.label11);
            this.panelTeachers.Controls.Add(this.label12);
            this.panelTeachers.Controls.Add(this.label13);
            this.panelTeachers.Controls.Add(this.label14);
            this.panelTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelTeachers.Location = new System.Drawing.Point(12, 36);
            this.panelTeachers.Name = "panelTeachers";
            this.panelTeachers.Size = new System.Drawing.Size(451, 24);
            this.panelTeachers.TabIndex = 17;
            this.panelTeachers.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(378, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Студент?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Курс";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Телефон";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(170, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ім\'я";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Прізвище";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "ID";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(501, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(122, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Викладачі курсу";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(469, 88);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(388, 206);
            this.dataGridView2.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(667, 39);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(114, 21);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Студенти курсу";
            // 
            // bZnStudent
            // 
            this.bZnStudent.Location = new System.Drawing.Point(235, 349);
            this.bZnStudent.Name = "bZnStudent";
            this.bZnStudent.Size = new System.Drawing.Size(116, 45);
            this.bZnStudent.TabIndex = 22;
            this.bZnStudent.Text = "Знайти Студента";
            this.bZnStudent.UseVisualStyleBackColor = true;
            this.bZnStudent.Click += new System.EventHandler(this.bZnStudent_Click);
            // 
            // bZnTeacher
            // 
            this.bZnTeacher.Location = new System.Drawing.Point(627, 349);
            this.bZnTeacher.Name = "bZnTeacher";
            this.bZnTeacher.Size = new System.Drawing.Size(140, 45);
            this.bZnTeacher.TabIndex = 23;
            this.bZnTeacher.Text = "Знайти Викладача";
            this.bZnTeacher.UseVisualStyleBackColor = true;
            this.bZnTeacher.Click += new System.EventHandler(this.bZnTeacher_Click);
            // 
            // tZnStudent
            // 
            this.tZnStudent.Location = new System.Drawing.Point(71, 374);
            this.tZnStudent.Name = "tZnStudent";
            this.tZnStudent.Size = new System.Drawing.Size(145, 20);
            this.tZnStudent.TabIndex = 24;
            // 
            // tZnTeacher
            // 
            this.tZnTeacher.Location = new System.Drawing.Point(459, 374);
            this.tZnTeacher.Name = "tZnTeacher";
            this.tZnTeacher.Size = new System.Drawing.Size(158, 20);
            this.tZnTeacher.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(102, 355);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Введіть прізвище";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(481, 355);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Введіть прізвище";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(498, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Прізвище";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(604, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Ім\'я";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(695, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "Телефон";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(793, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Курс";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 399);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tZnTeacher);
            this.Controls.Add(this.tZnStudent);
            this.Controls.Add(this.bZnTeacher);
            this.Controls.Add(this.bZnStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panelTeachers);
            this.Controls.Add(this.panelStudents);
            this.Controls.Add(this.panelCourses);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BStudents);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCourses.ResumeLayout(false);
            this.panelCourses.PerformLayout();
            this.panelStudents.ResumeLayout(false);
            this.panelStudents.PerformLayout();
            this.panelTeachers.ResumeLayout(false);
            this.panelTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BStudents;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редагуванняКурсівToolStripMenuItem;
        private System.Windows.Forms.Panel panelCourses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTeachers;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem редагуванняСтудентівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуванняВикладачівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bZnStudent;
        private System.Windows.Forms.Button bZnTeacher;
        private System.Windows.Forms.TextBox tZnStudent;
        private System.Windows.Forms.TextBox tZnTeacher;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;

    }
}

