using projet_gestion_detudiants;
using System.Data;
using System.Windows.Forms;

namespace projet_gestion_detudiants
{

    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Grade> grades = new List<Grade>();

        public Form1()
        {
            InitializeComponent();
            this.btnAddStudent.Click += new EventHandler(btnAddStudent_Click);
            this.btnAddCourse.Click += new EventHandler(btnAddCourse_Click);
            this.btnAddGrade.Click += new EventHandler(btnAddGrade_Click);
            this.btnLoadStudentData.Click += new EventHandler(btnLoadStudentData_Click);
            this.btnPrint.Click += new EventHandler(btnPrint_Click);
        }
        DataTable Table = new DataTable();
        private void Add_row_row_to_DataGridView_Using_TextBoxes_Load(object sender, EventArgs e)
        {
            Table.Columns.Add("Numero detudiant", typeof(int));
            Table.Columns.Add("Nom detudiant", typeof(string));
            Table.Columns.Add("Prenom detudiant", typeof(string));
            Table.Columns.Add("Numero de cours", typeof(int));
            Table.Columns.Add("Titre de cours", typeof(string));
            dataGridView.DataSource = Table;
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentNumber.Text, out int studentNumber) &&
                !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                !string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                Student newStudent = new Student(studentNumber, txtLastName.Text, txtFirstName.Text);
                students.Add(newStudent);
                RefreshStudentsDataGridView();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs de l'étudiant correctement.");
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCourseNumber.Text, out int courseNumber) &&
                !string.IsNullOrWhiteSpace(txtCourseCode.Text) &&
                !string.IsNullOrWhiteSpace(txtCourseTitle.Text))
            {
                Course newCourse = new Course(courseNumber, txtCourseCode.Text, txtCourseTitle.Text);
                courses.Add(newCourse);
                RefreshCoursesDataGridView();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs du cours correctement.");
            }
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGradeStudentNumber.Text, out int studentNumber) &&
                int.TryParse(txtGradeCourseNumber.Text, out int courseNumber) &&
                float.TryParse(txtGrade.Text, out float grade))
            {
                Grade newGrade = new Grade(studentNumber, courseNumber, grade);
                grades.Add(newGrade);
                RefreshGradesDataGridView();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs de la note correctement.");
            }
        }

        private void btnLoadStudentData_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLoadStudentNumber.Text, out int studentNumber))
            {
                var studentData = students.FirstOrDefault(s => s.NumeroDetudiant == studentNumber);
                var studentGrades = grades.Where(g => g.NumeroDetudiant == studentNumber).ToList();

                if (studentData != null)
                {

                    dataGridView.DataSource = null;
                    dataGridView.DataSource = studentGrades;
                }
                else
                {
                    MessageBox.Show("Étudiant non trouvé.");
                }
            }
            else
            {
                MessageBox.Show("Numéro d'étudiant invalide.");
            }
        }

        private void RefreshStudentsDataGridView()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = students;
        }

        private void RefreshCoursesDataGridView()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = courses;
        }

        private void RefreshGradesDataGridView()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = grades;
        }

        
        private void Form1_Load(object sender, EventArgs e) { }
        private void txtCourseNumber_TextChanged(object sender, EventArgs e) { }
        private void txtCourseCode_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void txtCourseTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentNumber.Text, out int studentNumber))
            {
                var student = students.FirstOrDefault(s => s.NumeroDetudiant == studentNumber);
                var studentGrades = grades.Where(g => g.NumeroDetudiant == studentNumber).ToList();
                if (student != null && studentGrades.Any())
                {
                    string transcriptText = GenerateTranscriptText(student, studentGrades);
                    SaveTranscriptToFile(transcriptText);
                }
                else
                {
                    MessageBox.Show("Numéro d'étudiant invalide ou aucune note trouvée.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un numéro d'étudiant valide.");
            }
        }

        private string GenerateTranscriptText(Student student, List<Grade> studentGrades)
        {
            
            var transcript = $"Numéro d'inscription: {student.NumeroDetudiant}\n" +
                             $"Prenom: {student.Nom}\n" +
                             $"Nom: {student.Prenom}\n\n";

            
            transcript += "Matière\tCode\tNote\n";

            
            foreach (var grade in studentGrades)
            {
                var course = courses.FirstOrDefault(c => c.NumeroDeCours == grade.NumeroDeCours);
                transcript += $"{course.NumeroDeCours}\t{course.Code}\t{grade.Note}\n";
            }


            var average = studentGrades.Average(g => g.Note);
            transcript += $"\nMoyenne Générale: {average}\n";
            transcript += $"Mention: {GetMention(average)}"; 

            return transcript;
        }

        private void SaveTranscriptToFile(string transcript)
        {
            string filePath = $"Transcript_{DateTime.Now:yyyyMMddHHmmss}.txt";
            File.WriteAllText(filePath, transcript);
            MessageBox.Show($"Le relevé de notes a été enregistré dans le fichier: {filePath}");
        }

        
        private string GetMention(float average)
        {
            if (average >= 90) return "Excellent";
            if (average >= 80) return "Très bien";
            if (average >= 70) return "Bien";
            if (average >= 60) return "Passable";
           
            return "Echec";
        }
    }

}
