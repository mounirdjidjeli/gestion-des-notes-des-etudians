namespace projet_gestion_detudiants
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStudentNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnAddStudent = new Button();
            txtCourseNumber = new TextBox();
            txtCourseCode = new TextBox();
            txtCourseTitle = new TextBox();
            btnAddCourse = new Button();
            txtGradeStudentNumber = new TextBox();
            txtGradeCourseNumber = new TextBox();
            txtGrade = new TextBox();
            dataGridView = new DataGridView();
            txtLoadStudentNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnLoadStudentData = new Button();
            btnAddGrade = new Button();
            label13 = new Label();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.AccessibleName = "";
            txtStudentNumber.BackColor = Color.White;
            txtStudentNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            txtStudentNumber.Location = new Point(674, 312);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(196, 34);
            txtStudentNumber.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.AccessibleName = "";
            txtLastName.BackColor = Color.White;
            txtLastName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            txtLastName.Location = new Point(674, 375);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(196, 34);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.AccessibleName = "";
            txtFirstName.BackColor = Color.White;
            txtFirstName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            txtFirstName.Location = new Point(675, 449);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(195, 34);
            txtFirstName.TabIndex = 2;
            // 
            // btnAddStudent
            // 
            btnAddStudent.AccessibleName = "";
            btnAddStudent.BackColor = Color.Lime;
            btnAddStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddStudent.Location = new Point(885, 372);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(302, 41);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Click ici pour Ajouter Etudiant";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click_1;
            // 
            // txtCourseNumber
            // 
            txtCourseNumber.AccessibleName = "";
            txtCourseNumber.BackColor = Color.White;
            txtCourseNumber.Location = new Point(199, 309);
            txtCourseNumber.Name = "txtCourseNumber";
            txtCourseNumber.Size = new Size(158, 31);
            txtCourseNumber.TabIndex = 4;
            txtCourseNumber.TextChanged += txtCourseNumber_TextChanged;
            // 
            // txtCourseCode
            // 
            txtCourseCode.AccessibleName = "";
            txtCourseCode.BackColor = Color.White;
            txtCourseCode.Location = new Point(176, 375);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(181, 31);
            txtCourseCode.TabIndex = 5;
            txtCourseCode.TextChanged += txtCourseCode_TextChanged;
            // 
            // txtCourseTitle
            // 
            txtCourseTitle.AccessibleName = "";
            txtCourseTitle.BackColor = Color.White;
            txtCourseTitle.Location = new Point(176, 449);
            txtCourseTitle.Name = "txtCourseTitle";
            txtCourseTitle.Size = new Size(181, 31);
            txtCourseTitle.TabIndex = 6;
            txtCourseTitle.TextChanged += txtCourseTitle_TextChanged;
            // 
            // btnAddCourse
            // 
            btnAddCourse.AccessibleName = "";
            btnAddCourse.BackColor = Color.Lime;
            btnAddCourse.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCourse.Location = new Point(44, 541);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(294, 41);
            btnAddCourse.TabIndex = 7;
            btnAddCourse.Text = "Click ici pour Ajouter Cours";
            btnAddCourse.UseVisualStyleBackColor = false;
            // 
            // txtGradeStudentNumber
            // 
            txtGradeStudentNumber.AccessibleName = "";
            txtGradeStudentNumber.BackColor = Color.White;
            txtGradeStudentNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtGradeStudentNumber.Location = new Point(184, 3);
            txtGradeStudentNumber.Name = "txtGradeStudentNumber";
            txtGradeStudentNumber.Size = new Size(173, 31);
            txtGradeStudentNumber.TabIndex = 8;
            // 
            // txtGradeCourseNumber
            // 
            txtGradeCourseNumber.AccessibleName = "";
            txtGradeCourseNumber.BackColor = Color.White;
            txtGradeCourseNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtGradeCourseNumber.Location = new Point(176, 79);
            txtGradeCourseNumber.Name = "txtGradeCourseNumber";
            txtGradeCourseNumber.Size = new Size(181, 31);
            txtGradeCourseNumber.TabIndex = 9;
            // 
            // txtGrade
            // 
            txtGrade.AccessibleName = "";
            txtGrade.BackColor = Color.White;
            txtGrade.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtGrade.Location = new Point(176, 164);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(181, 31);
            txtGrade.TabIndex = 10;
            txtGrade.TextChanged += txtGrade_TextChanged;
            // 
            // dataGridView
            // 
            dataGridView.AccessibleName = "";
            dataGridView.BackgroundColor = Color.Cyan;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = SystemColors.ActiveBorder;
            dataGridView.Location = new Point(491, 43);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(696, 269);
            dataGridView.TabIndex = 12;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtLoadStudentNumber
            // 
            txtLoadStudentNumber.AccessibleName = "";
            txtLoadStudentNumber.Location = new Point(692, 544);
            txtLoadStudentNumber.Name = "txtLoadStudentNumber";
            txtLoadStudentNumber.Size = new Size(178, 31);
            txtLoadStudentNumber.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(494, 315);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 15;
            label1.Text = "Numero Detudiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(956, 120);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 16;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(491, 452);
            label4.Name = "label4";
            label4.Size = new Size(186, 28);
            label4.TabIndex = 18;
            label4.Text = " Prenom Detudiant";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Red;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(17, 6);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 19;
            label5.Text = "Numero detudiant";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Red;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(17, 82);
            label6.Name = "label6";
            label6.Size = new Size(160, 25);
            label6.TabIndex = 20;
            label6.Text = "Numero de Cours";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Red;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(16, 164);
            label7.Name = "label7";
            label7.Size = new Size(161, 25);
            label7.TabIndex = 21;
            label7.Text = "Note de letudiant";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Red;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(24, 309);
            label8.Name = "label8";
            label8.Size = new Size(174, 28);
            label8.TabIndex = 22;
            label8.Text = "Numero de Cours";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Red;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(24, 378);
            label9.Name = "label9";
            label9.Size = new Size(158, 28);
            label9.TabIndex = 23;
            label9.Text = "Code de Cours  ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Red;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(24, 449);
            label10.Name = "label10";
            label10.Size = new Size(155, 28);
            label10.TabIndex = 24;
            label10.Text = "Titre  de  cours ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Red;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(491, 547);
            label11.Name = "label11";
            label11.Size = new Size(205, 28);
            label11.TabIndex = 25;
            label11.Text = "Charger les etudiants";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Red;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label12.Location = new Point(492, 375);
            label12.Name = "label12";
            label12.Size = new Size(185, 28);
            label12.TabIndex = 27;
            label12.Text = "Nom  de  letudiant";
            // 
            // btnLoadStudentData
            // 
            btnLoadStudentData.AccessibleName = "";
            btnLoadStudentData.BackColor = Color.Lime;
            btnLoadStudentData.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLoadStudentData.Location = new Point(885, 534);
            btnLoadStudentData.Name = "btnLoadStudentData";
            btnLoadStudentData.Size = new Size(302, 41);
            btnLoadStudentData.TabIndex = 29;
            btnLoadStudentData.Text = "Click ici pour Charger données étudiant";
            btnLoadStudentData.UseVisualStyleBackColor = false;
            // 
            // btnAddGrade
            // 
            btnAddGrade.AccessibleName = "";
            btnAddGrade.BackColor = Color.Lime;
            btnAddGrade.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddGrade.Location = new Point(44, 231);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(294, 38);
            btnAddGrade.TabIndex = 28;
            btnAddGrade.Text = "Click ici pour Ajouter Note";
            btnAddGrade.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Yellow;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(491, 12);
            label13.Name = "label13";
            label13.Size = new Size(696, 28);
            label13.TabIndex = 30;
            label13.Text = "LAFFICHAGE DES RESULTATS DE LA GESTION DES NOTES DE LETUDIANT";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(0, 0, 192);
            btnPrint.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(982, 452);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(134, 40);
            btnPrint.TabIndex = 31;
            btnPrint.Text = "Imprimer";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1199, 597);
            Controls.Add(btnPrint);
            Controls.Add(label13);
            Controls.Add(btnLoadStudentData);
            Controls.Add(btnAddGrade);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLoadStudentNumber);
            Controls.Add(dataGridView);
            Controls.Add(txtGrade);
            Controls.Add(txtGradeCourseNumber);
            Controls.Add(txtGradeStudentNumber);
            Controls.Add(btnAddCourse);
            Controls.Add(txtCourseTitle);
            Controls.Add(txtCourseCode);
            Controls.Add(txtCourseNumber);
            Controls.Add(btnAddStudent);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNumber);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnAddStudent;
        private TextBox txtCourseNumber;
        private TextBox txtCourseCode;
        private TextBox txtCourseTitle;
        private Button btnAddCourse;
        private TextBox txtGradeStudentNumber;
        private TextBox txtGradeCourseNumber;
        private TextBox txtGrade;
        private DataGridView dataGridView;
        private TextBox txtLoadStudentNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnLoadStudentData;
        private Button btnAddGrade;
        private Label label13;
        private Button btnPrint;
    }
}
