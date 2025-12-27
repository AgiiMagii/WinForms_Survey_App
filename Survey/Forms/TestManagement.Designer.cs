namespace Survey.Forms
{
    partial class TestManagement
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
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.np_Duration = new System.Windows.Forms.NumericUpDown();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.chb_IsActive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_regForm = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Process = new System.Windows.Forms.Button();
            this.gv_Tests = new System.Windows.Forms.DataGridView();
            this.gv_Questions = new System.Windows.Forms.DataGridView();
            this.txt_Question = new System.Windows.Forms.TextBox();
            this.txt_Answer1 = new System.Windows.Forms.TextBox();
            this.txt_Answer4 = new System.Windows.Forms.TextBox();
            this.txt_Answer2 = new System.Windows.Forms.TextBox();
            this.txt_Answer3 = new System.Windows.Forms.TextBox();
            this.np_CorrectAnsw = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gb_newQuestion = new System.Windows.Forms.GroupBox();
            this.btn_ClearQ = new System.Windows.Forms.Button();
            this.btn_ProcessQuest = new System.Windows.Forms.Button();
            this.pb_EditTest = new System.Windows.Forms.PictureBox();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.np_Duration)).BeginInit();
            this.gb_regForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Tests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Questions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_CorrectAnsw)).BeginInit();
            this.gb_newQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_EditTest)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 34);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "←  Back ";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(25, 223);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(184, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // np_Duration
            // 
            this.np_Duration.Location = new System.Drawing.Point(25, 262);
            this.np_Duration.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.np_Duration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.np_Duration.Name = "np_Duration";
            this.np_Duration.Size = new System.Drawing.Size(109, 20);
            this.np_Duration.TabIndex = 2;
            this.np_Duration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_Author
            // 
            this.txt_Author.Location = new System.Drawing.Point(25, 301);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(184, 20);
            this.txt_Author.TabIndex = 3;
            // 
            // chb_IsActive
            // 
            this.chb_IsActive.AutoSize = true;
            this.chb_IsActive.Location = new System.Drawing.Point(153, 337);
            this.chb_IsActive.Name = "chb_IsActive";
            this.chb_IsActive.Size = new System.Drawing.Size(56, 17);
            this.chb_IsActive.TabIndex = 5;
            this.chb_IsActive.Text = "Active";
            this.chb_IsActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Test Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Author";
            // 
            // gb_regForm
            // 
            this.gb_regForm.Controls.Add(this.label13);
            this.gb_regForm.Controls.Add(this.label12);
            this.gb_regForm.Controls.Add(this.label11);
            this.gb_regForm.Controls.Add(this.label4);
            this.gb_regForm.Controls.Add(this.btn_Clear);
            this.gb_regForm.Controls.Add(this.btn_Process);
            this.gb_regForm.Controls.Add(this.txt_Name);
            this.gb_regForm.Controls.Add(this.np_Duration);
            this.gb_regForm.Controls.Add(this.txt_Author);
            this.gb_regForm.Controls.Add(this.label3);
            this.gb_regForm.Controls.Add(this.label2);
            this.gb_regForm.Controls.Add(this.chb_IsActive);
            this.gb_regForm.Controls.Add(this.label1);
            this.gb_regForm.Location = new System.Drawing.Point(12, 86);
            this.gb_regForm.Name = "gb_regForm";
            this.gb_regForm.Size = new System.Drawing.Size(226, 461);
            this.gb_regForm.TabIndex = 10;
            this.gb_regForm.TabStop = false;
            this.gb_regForm.Text = "Update and Register";
            this.gb_regForm.Visible = false;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(25, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 33);
            this.label11.TabIndex = 14;
            this.label11.Text = "● Fill in form and process to register a new test";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "minutes";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(28, 382);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear Form";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(25, 413);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(184, 23);
            this.btn_Process.TabIndex = 11;
            this.btn_Process.Text = "Process";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // gv_Tests
            // 
            this.gv_Tests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Tests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Tests.Location = new System.Drawing.Point(254, 12);
            this.gv_Tests.Name = "gv_Tests";
            this.gv_Tests.Size = new System.Drawing.Size(718, 136);
            this.gv_Tests.TabIndex = 11;
            this.gv_Tests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Tests_CellContentClick);
            this.gv_Tests.SelectionChanged += new System.EventHandler(this.gv_Tests_SelectionChanged);
            // 
            // gv_Questions
            // 
            this.gv_Questions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Questions.Location = new System.Drawing.Point(254, 194);
            this.gv_Questions.Name = "gv_Questions";
            this.gv_Questions.Size = new System.Drawing.Size(718, 135);
            this.gv_Questions.TabIndex = 12;
            this.gv_Questions.SelectionChanged += new System.EventHandler(this.gv_Questions_SelectionChanged);
            // 
            // txt_Question
            // 
            this.txt_Question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Question.Location = new System.Drawing.Point(135, 41);
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.Size = new System.Drawing.Size(536, 20);
            this.txt_Question.TabIndex = 13;
            // 
            // txt_Answer1
            // 
            this.txt_Answer1.Location = new System.Drawing.Point(135, 83);
            this.txt_Answer1.Name = "txt_Answer1";
            this.txt_Answer1.Size = new System.Drawing.Size(307, 20);
            this.txt_Answer1.TabIndex = 14;
            // 
            // txt_Answer4
            // 
            this.txt_Answer4.Location = new System.Drawing.Point(135, 161);
            this.txt_Answer4.Name = "txt_Answer4";
            this.txt_Answer4.Size = new System.Drawing.Size(307, 20);
            this.txt_Answer4.TabIndex = 15;
            // 
            // txt_Answer2
            // 
            this.txt_Answer2.Location = new System.Drawing.Point(135, 109);
            this.txt_Answer2.Name = "txt_Answer2";
            this.txt_Answer2.Size = new System.Drawing.Size(307, 20);
            this.txt_Answer2.TabIndex = 16;
            // 
            // txt_Answer3
            // 
            this.txt_Answer3.Location = new System.Drawing.Point(135, 135);
            this.txt_Answer3.Name = "txt_Answer3";
            this.txt_Answer3.Size = new System.Drawing.Size(307, 20);
            this.txt_Answer3.TabIndex = 17;
            // 
            // np_CorrectAnsw
            // 
            this.np_CorrectAnsw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.np_CorrectAnsw.Location = new System.Drawing.Point(561, 86);
            this.np_CorrectAnsw.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.np_CorrectAnsw.Name = "np_CorrectAnsw";
            this.np_CorrectAnsw.Size = new System.Drawing.Size(110, 20);
            this.np_CorrectAnsw.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "New Question";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Correct Answer is";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Answer 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Answer 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Answer 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Answer 4";
            // 
            // gb_newQuestion
            // 
            this.gb_newQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_newQuestion.Controls.Add(this.btn_ClearQ);
            this.gb_newQuestion.Controls.Add(this.btn_ProcessQuest);
            this.gb_newQuestion.Controls.Add(this.txt_Answer1);
            this.gb_newQuestion.Controls.Add(this.label10);
            this.gb_newQuestion.Controls.Add(this.txt_Question);
            this.gb_newQuestion.Controls.Add(this.label5);
            this.gb_newQuestion.Controls.Add(this.txt_Answer4);
            this.gb_newQuestion.Controls.Add(this.np_CorrectAnsw);
            this.gb_newQuestion.Controls.Add(this.label9);
            this.gb_newQuestion.Controls.Add(this.label6);
            this.gb_newQuestion.Controls.Add(this.txt_Answer2);
            this.gb_newQuestion.Controls.Add(this.label7);
            this.gb_newQuestion.Controls.Add(this.label8);
            this.gb_newQuestion.Controls.Add(this.txt_Answer3);
            this.gb_newQuestion.Location = new System.Drawing.Point(254, 340);
            this.gb_newQuestion.Name = "gb_newQuestion";
            this.gb_newQuestion.Size = new System.Drawing.Size(718, 207);
            this.gb_newQuestion.TabIndex = 26;
            this.gb_newQuestion.TabStop = false;
            this.gb_newQuestion.Text = "Add a Question";
            // 
            // btn_ClearQ
            // 
            this.btn_ClearQ.Location = new System.Drawing.Point(469, 128);
            this.btn_ClearQ.Name = "btn_ClearQ";
            this.btn_ClearQ.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearQ.TabIndex = 28;
            this.btn_ClearQ.Text = "Clear Form";
            this.btn_ClearQ.UseVisualStyleBackColor = true;
            this.btn_ClearQ.Click += new System.EventHandler(this.btn_ClearQ_Click);
            // 
            // btn_ProcessQuest
            // 
            this.btn_ProcessQuest.Location = new System.Drawing.Point(469, 159);
            this.btn_ProcessQuest.Name = "btn_ProcessQuest";
            this.btn_ProcessQuest.Size = new System.Drawing.Size(202, 23);
            this.btn_ProcessQuest.TabIndex = 26;
            this.btn_ProcessQuest.Text = "Process";
            this.btn_ProcessQuest.UseVisualStyleBackColor = true;
            this.btn_ProcessQuest.Click += new System.EventHandler(this.btn_ProcessQuest_Click);
            // 
            // pb_EditTest
            // 
            this.pb_EditTest.Image = global::Survey.Properties.Resources.Custom_Icon_Design_Mono_General_2_Edit_64;
            this.pb_EditTest.Location = new System.Drawing.Point(159, 12);
            this.pb_EditTest.Name = "pb_EditTest";
            this.pb_EditTest.Size = new System.Drawing.Size(79, 68);
            this.pb_EditTest.TabIndex = 27;
            this.pb_EditTest.TabStop = false;
            this.pb_EditTest.Click += new System.EventHandler(this.pb_EditTest_Click);
            // 
            // lbl_Message
            // 
            this.lbl_Message.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_Message.Location = new System.Drawing.Point(467, 154);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(0, 25);
            this.lbl_Message.TabIndex = 28;
            this.lbl_Message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(25, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 33);
            this.label12.TabIndex = 15;
            this.label12.Text = "● Select a test to make corrections and process to update";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(25, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 33);
            this.label13.TabIndex = 16;
            this.label13.Text = "● To register a new test when the\r\n existing one is selected, clear the form";
            // 
            // TestManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 559);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.pb_EditTest);
            this.Controls.Add(this.gb_newQuestion);
            this.Controls.Add(this.gv_Questions);
            this.Controls.Add(this.gv_Tests);
            this.Controls.Add(this.gb_regForm);
            this.Controls.Add(this.btn_back);
            this.Name = "TestManagement";
            this.Text = "Test Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestManagement_FormClosing);
            this.Load += new System.EventHandler(this.TestManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.np_Duration)).EndInit();
            this.gb_regForm.ResumeLayout(false);
            this.gb_regForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Tests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Questions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_CorrectAnsw)).EndInit();
            this.gb_newQuestion.ResumeLayout(false);
            this.gb_newQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_EditTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.NumericUpDown np_Duration;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.CheckBox chb_IsActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_regForm;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.DataGridView gv_Tests;
        private System.Windows.Forms.DataGridView gv_Questions;
        private System.Windows.Forms.TextBox txt_Question;
        private System.Windows.Forms.TextBox txt_Answer1;
        private System.Windows.Forms.TextBox txt_Answer4;
        private System.Windows.Forms.TextBox txt_Answer2;
        private System.Windows.Forms.TextBox txt_Answer3;
        private System.Windows.Forms.NumericUpDown np_CorrectAnsw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gb_newQuestion;
        private System.Windows.Forms.PictureBox pb_EditTest;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ProcessQuest;
        private System.Windows.Forms.Button btn_ClearQ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}