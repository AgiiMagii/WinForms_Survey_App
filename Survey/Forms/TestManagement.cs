using Survey.Lib;
using Survey.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey.Forms
{
    public partial class TestManagement : Form
    {
        Helper helper = new Helper();
        Factory factory = new Factory();
        Test selectedTest = null;
        List<TestView> tests = new List<TestView>();
        List<Question> questions = new List<Question>();
        private readonly Main _main;
        public TestManagement(Main main)
        {
            InitializeComponent();
            _main = main;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            _main.Location = this.Location;
            _main.Size = this.Size;
            _main.Show();
            this.Close();
        }
        private void TestManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_main.Visible)
                Application.Exit();
        }
        private void TestManagement_Load(object sender, EventArgs e)
        {
            tests = factory.GetTests();
            helper.ReloadGrid<TestView>(gv_Tests, tests, true);
        }
        private Test GenerateNewTest()
        {
            Test test = new Test();
            test.Name = txt_Name.Text;
            test.Duration = np_Duration.Value > 0 ? (short?)np_Duration.Value : null;
            test.Author = txt_Author.Text;
            test.CreateDate = DateTime.Now;
            test.IsActive = chb_IsActive.Checked;
            return test;
        }
        private void btn_Process_Click(object sender, EventArgs e)
        {
            if (gv_Tests.SelectedRows.Count > 0)
            {
                long testId = (long)gv_Tests.SelectedRows[0].Cells["Id_Test"].Value;
                Test testToUpdate = factory.GetTestEntities().FirstOrDefault(t => t.Id_Test == testId);
                if (testToUpdate != null)
                {
                    testToUpdate.Name = txt_Name.Text;
                    testToUpdate.Duration = np_Duration.Value > 0 ? (short?)np_Duration.Value : null;
                    testToUpdate.Author = txt_Author.Text;
                    testToUpdate.CreateDate = DateTime.Now;
                    testToUpdate.IsActive = chb_IsActive.Checked;

                    factory.UpdateTest(testToUpdate);
                }
            }
            else
            {
                Test newTest = GenerateNewTest();
                factory.AddTest(newTest);
            }
            tests = factory.GetTests();
            helper.ReloadGrid<TestView>(gv_Tests, tests, true);
            helper.ClearForm(this.Controls);
        }
        private void gv_Tests_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_Tests.SelectedRows.Count > 0)
            {
                long testId = (long)gv_Tests.SelectedRows[0].Cells["Id_Test"].Value;
                selectedTest = factory.GetTestById(testId);
                if (selectedTest != null)
                {
                    txt_Name.Text = selectedTest.Name;
                    np_Duration.Value = selectedTest.Duration.HasValue ? selectedTest.Duration.Value : 0;
                    txt_Author.Text = selectedTest.Author;
                    chb_IsActive.Checked = selectedTest.IsActive;
                    questions = GetQuestionsByTestId(testId);
                    helper.ReloadGrid<Question>(gv_Questions, questions, false);
                }
            }
        }
        private void btn_AddQuest_Click(object sender, EventArgs e)
        {
            if (gv_Tests.SelectedRows.Count > 0)
            {
                long testId = (long)gv_Tests.SelectedRows[0].Cells["Id_Test"].Value;
                Question question = new Question();
                question.Id_Test = testId;
                question.Question1 = txt_Question.Text;
                question.Answer1 = txt_Answer1.Text;
                question.Answer2 = txt_Answer2.Text;
                question.Answer3 = txt_Answer3.Text;
                question.Answer4 = txt_Answer4.Text;
                question.CorrectNr = (byte)np_CorrectAnsw.Value;
                try
                {
                    factory.AddQuestion(question);
                    MessageBox.Show("Question added successfully.");
                    helper.ClearForm(this.Controls);
                    questions = GetQuestionsByTestId(testId);
                    helper.ReloadGrid<Question>(gv_Questions, questions, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding question: " + ex.Message);


                }
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            helper.ClearForm(this.Controls);
            gv_Tests.ClearSelection();
        }
        private List<Question> GetQuestionsByTestId(long testId)
        {
            return factory.GetTestEntities().FirstOrDefault(t => t.Id_Test == testId)?.Question.ToList() ?? new List<Question>();
        }
    }
}
