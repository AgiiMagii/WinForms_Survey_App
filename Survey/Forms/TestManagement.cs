using Survey.Lib;
using Survey.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Survey.Forms
{
    public partial class TestManagement : Form
    {
        Helper helper = new Helper();
        Factory factory = new Factory();
        Validation validation = new Validation();
        private ErrorProvider errorProvider = new ErrorProvider();
        Test selectedTest = null;
        List<string> errors = new List<string>();
        List<TestView> tests = new List<TestView>();
        List<QuestionView> questions = new List<QuestionView>();

        private readonly Main _main;
        public TestManagement(Main main)
        {
            InitializeComponent();
            _main = main;
            AttachTextBoxEvents(gb_newQuestion);
            AttachTextBoxEvents(gb_regForm);
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
        }
        private void AttachTextBoxEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox tb)
                {
                    tb.TextChanged += TextBox_TextChanged;
                }

                if (control.HasChildren)
                {
                    AttachTextBoxEvents(control);
                }
            }
        }
        public void UpdateError(Control control, bool isValid, string errorMessage)
        {
            if (!isValid)
            {
                control.BackColor = Color.MistyRose;
                errorProvider.SetError(control, errorMessage);

            }
            else
            {
                control.BackColor = Color.White;
                errorProvider.SetError(control, "");
            }
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
        private Question GenerateNewQuestion(long testId)
        {
            Question question = new Question();
            question.Id_Test = testId;
            question.Question1 = txt_Question.Text;
            question.Answer1 = txt_Answer1.Text;
            question.Answer2 = txt_Answer2.Text;
            question.Answer3 = txt_Answer3.Text;
            question.Answer4 = txt_Answer4.Text;
            question.CorrectNr = (byte)np_CorrectAnsw.Value;
            return question;
        }
        private void btn_Process_Click(object sender, EventArgs e)
        {
            try
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

                        errors = validation.TestValidation(testToUpdate);
                        if (errors.Count > 0)
                        {
                            string errorMessage = string.Join("\n", errors);
                            helper.ShowMessage(errorMessage, lbl_Message, true);
                            return;
                        }

                        factory.UpdateTest(testToUpdate);
                        helper.ShowMessage(Messages.Info_UpdateSuccess, lbl_Message, true);
                    }
                }
                else
                {
                    Test newTest = GenerateNewTest();
                    errors = validation.TestValidation(newTest);
                    if (errors.Count > 0)
                    {
                        string errorMessage = string.Join("\n", errors);
                        helper.ShowMessage(errorMessage, lbl_Message, true);
                        return;
                    }
                    factory.AddTest(newTest);
                    helper.ShowMessage(Messages.Info_CreateSuccess, lbl_Message, true);
                }
                tests = factory.GetTests();
                helper.ReloadGrid<TestView>(gv_Tests, tests, true);
                helper.ClearForm(this.Controls);
                gb_regForm.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Messages.Error_Process + ex.Message);
            }
        }
        private void gv_Tests_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_Tests.SelectedRows.Count > 0)
            {
                long testId = (long)gv_Tests.SelectedRows[0].Cells["Id_Test"].Value;
                selectedTest = factory.GetTestById(testId);
                questions = factory.GetQuestionViewByTestId(testId);
                if (selectedTest != null)
                {
                    txt_Name.Text = selectedTest.Name;
                    np_Duration.Value = selectedTest.Duration.HasValue ? selectedTest.Duration.Value : 0;
                    txt_Author.Text = selectedTest.Author;
                    chb_IsActive.Checked = selectedTest.IsActive;
                    helper.ReloadGrid<QuestionView>(gv_Questions, questions, true);
                }
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            helper.ClearForm(this.Controls);
            gv_Tests.ClearSelection();
            gv_Questions.DataSource = null;
        }
        private void gv_Questions_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_Questions.SelectedRows.Count > 0)
            {
                txt_Question.Text = gv_Questions.SelectedRows[0].Cells["Question1"].Value.ToString();
                txt_Answer1.Text = gv_Questions.SelectedRows[0].Cells["Answer1"].Value.ToString();
                txt_Answer2.Text = gv_Questions.SelectedRows[0].Cells["Answer2"].Value.ToString();
                txt_Answer3.Text = gv_Questions.SelectedRows[0].Cells["Answer3"].Value.ToString();
                txt_Answer4.Text = gv_Questions.SelectedRows[0].Cells["Answer4"].Value.ToString();
                np_CorrectAnsw.Value = Convert.ToDecimal(gv_Questions.SelectedRows[0].Cells["CorrectAnswer"].Value);
            }
        }
        private void btn_ProcessQuest_Click(object sender, EventArgs e)
        {
            if (gv_Tests.SelectedRows.Count == 0)
            {
                helper.ShowMessage(Messages.Warning_Select, lbl_Message, true);
                return;
            }

            long testId = (long)gv_Tests.SelectedRows[0].Cells["Id_Test"].Value;
            long? questionId = gv_Questions.SelectedRows.Count > 0
                ? (long?)gv_Questions.SelectedRows[0].Cells["Id_Question"].Value
                : null;
            try
            {
                if (questionId != null)
                {

                    Question questionToUpdate = factory.GetQuestionEntities().FirstOrDefault(q => q.Id_Question == questionId);
                    questionToUpdate.Id_Test = testId;
                    questionToUpdate.Question1 = txt_Question.Text;
                    questionToUpdate.Answer1 = txt_Answer1.Text;
                    questionToUpdate.Answer2 = txt_Answer2.Text;
                    questionToUpdate.Answer3 = txt_Answer3.Text;
                    questionToUpdate.Answer4 = txt_Answer4.Text;
                    questionToUpdate.CorrectNr = (byte)np_CorrectAnsw.Value;

                    errors = validation.QuestionValidation(questionToUpdate);
                    if (errors.Count > 0)
                    {
                        string errorMessage = string.Join("\n", errors);
                        helper.ShowMessage(errorMessage, lbl_Message, true);
                        return;
                    }

                    factory.UpdateQuestion(questionToUpdate);
                    helper.ShowMessage(Messages.Info_UpdateSuccess, lbl_Message, true);
                }
                else
                {
                    Question newQuestion = GenerateNewQuestion(testId);
                    errors = validation.QuestionValidation(newQuestion);
                    if (errors.Count > 0)
                    {
                        string errorMessage = string.Join("\n", errors);
                        helper.ShowMessage(errorMessage, lbl_Message, true);
                        return;
                    }

                    factory.AddQuestion(newQuestion);
                    helper.ShowMessage(Messages.Info_CreateSuccess, lbl_Message, true);
                }
                questions = factory.GetQuestionViewByTestId(testId);
                helper.ReloadGrid<QuestionView>(gv_Questions, questions, true);
                helper.ClearForm(gb_newQuestion.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Messages.Error_Process + ex.Message);
            }
        }
        private void btn_ClearQ_Click(object sender, EventArgs e)
        {
            helper.ClearForm(gb_newQuestion.Controls);
            gv_Questions.ClearSelection();
        }
        private void gv_Tests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gv_Tests.Columns["btnDelete"].Index)
            {
                long testId = (long)gv_Tests.Rows[e.RowIndex].Cells["Id_Test"].Value;
                Test testToDelete = factory.GetTestById(testId);
                if (testToDelete != null)
                {
                    DialogResult confirmResult = MessageBox.Show(Messages.Warning_Delete, "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            factory.DeleteTest(testToDelete);
                            tests = factory.GetTests();
                            helper.ReloadGrid<TestView>(gv_Tests, tests, true);
                            helper.ShowMessage(Messages.Info_DeleteSuccess, lbl_Message, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(Messages.Error_Delete + ex.Message);
                        }
                    }
                }
            }
        }
        private void gv_Questions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gv_Questions.Columns["btnDelete"].Index)
            {
                long questionId = (long)gv_Questions.Rows[e.RowIndex].Cells["Id_Question"].Value;
                Question questionToDelete = factory.GetQuestionEntities().FirstOrDefault(q => q.Id_Question == questionId);
                if (questionToDelete != null)
                {
                    DialogResult confirmResult = MessageBox.Show(Messages.Warning_Delete, "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            factory.DeleteQuestion(questionToDelete);
                            long testId = (long)gv_Tests.SelectedRows[0].Cells["Id_Test"].Value;
                            questions = factory.GetQuestionViewByTestId(testId);
                            helper.ReloadGrid<QuestionView>(gv_Questions, questions, true);
                            helper.ShowMessage(Messages.Info_DeleteSuccess, lbl_Message, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(Messages.Error_Delete + ex.Message);
                        }
                    }
                }
            }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == txt_Question)
                UpdateError(tb, Validation.IsQuestionValidSoFar(tb.Text), Messages.Error_TextTooLong);
            else
                UpdateError(tb, Validation.IsInputTextValidSoFar(tb.Text), Messages.Error_TextTooLong);
        }
        private void btn_EditQuest_Click(object sender, EventArgs e)
        {
            bool willShow = !gb_newQuestion.Visible;
            gb_newQuestion.Visible = willShow;

            if (willShow)
                gb_regForm.Visible = false;
        }
        private void btn_EditTest_Click(object sender, EventArgs e)
        {
            bool willShow = !gb_regForm.Visible;
            gb_regForm.Visible = willShow;

            if (willShow)
                gb_newQuestion.Visible = false;
        }
    }
}
