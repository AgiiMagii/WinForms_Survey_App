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
            this.btn_Process = new System.Windows.Forms.Button();
            this.gv_Tests = new System.Windows.Forms.DataGridView();
            this.gv_Questions = new System.Windows.Forms.DataGridView();
            this.txt_Question = new System.Windows.Forms.TextBox();
            this.txt_Answer1 = new System.Windows.Forms.TextBox();
            this.txt_Answer4 = new System.Windows.Forms.TextBox();
            this.txt_Answer2 = new System.Windows.Forms.TextBox();
            this.txt_Answer3 = new System.Windows.Forms.TextBox();
            this.np_CorrectAnsw = new System.Windows.Forms.NumericUpDown();
            this.btn_AddQuest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gb_Answers = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.np_Duration)).BeginInit();
            this.gb_regForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Tests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Questions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_CorrectAnsw)).BeginInit();
            this.gb_Answers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.txt_Name.Location = new System.Drawing.Point(96, 40);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(120, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // np_Duration
            // 
            this.np_Duration.Location = new System.Drawing.Point(96, 77);
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
            this.np_Duration.Size = new System.Drawing.Size(120, 20);
            this.np_Duration.TabIndex = 2;
            this.np_Duration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_Author
            // 
            this.txt_Author.Location = new System.Drawing.Point(96, 115);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(120, 20);
            this.txt_Author.TabIndex = 3;
            // 
            // chb_IsActive
            // 
            this.chb_IsActive.AutoSize = true;
            this.chb_IsActive.Location = new System.Drawing.Point(160, 159);
            this.chb_IsActive.Name = "chb_IsActive";
            this.chb_IsActive.Size = new System.Drawing.Size(56, 17);
            this.chb_IsActive.TabIndex = 5;
            this.chb_IsActive.Text = "Active";
            this.chb_IsActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Author";
            // 
            // gb_regForm
            // 
            this.gb_regForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_regForm.Controls.Add(this.btn_Clear);
            this.gb_regForm.Controls.Add(this.btn_Process);
            this.gb_regForm.Controls.Add(this.txt_Name);
            this.gb_regForm.Controls.Add(this.np_Duration);
            this.gb_regForm.Controls.Add(this.txt_Author);
            this.gb_regForm.Controls.Add(this.label3);
            this.gb_regForm.Controls.Add(this.label2);
            this.gb_regForm.Controls.Add(this.chb_IsActive);
            this.gb_regForm.Controls.Add(this.label1);
            this.gb_regForm.Location = new System.Drawing.Point(12, 72);
            this.gb_regForm.Name = "gb_regForm";
            this.gb_regForm.Size = new System.Drawing.Size(226, 240);
            this.gb_regForm.TabIndex = 10;
            this.gb_regForm.TabStop = false;
            this.gb_regForm.Text = "Update and Register";
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(23, 199);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(193, 23);
            this.btn_Process.TabIndex = 11;
            this.btn_Process.Text = "Process";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // gv_Tests
            // 
            this.gv_Tests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Tests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Tests.Location = new System.Drawing.Point(254, 33);
            this.gv_Tests.Name = "gv_Tests";
            this.gv_Tests.Size = new System.Drawing.Size(718, 156);
            this.gv_Tests.TabIndex = 11;
            this.gv_Tests.SelectionChanged += new System.EventHandler(this.gv_Tests_SelectionChanged);
            // 
            // gv_Questions
            // 
            this.gv_Questions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Questions.Location = new System.Drawing.Point(254, 199);
            this.gv_Questions.Name = "gv_Questions";
            this.gv_Questions.Size = new System.Drawing.Size(718, 150);
            this.gv_Questions.TabIndex = 12;
            // 
            // txt_Question
            // 
            this.txt_Question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Question.Location = new System.Drawing.Point(331, 355);
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.Size = new System.Drawing.Size(641, 20);
            this.txt_Question.TabIndex = 13;
            // 
            // txt_Answer1
            // 
            this.txt_Answer1.Location = new System.Drawing.Point(31, 48);
            this.txt_Answer1.Name = "txt_Answer1";
            this.txt_Answer1.Size = new System.Drawing.Size(215, 20);
            this.txt_Answer1.TabIndex = 14;
            // 
            // txt_Answer4
            // 
            this.txt_Answer4.Location = new System.Drawing.Point(31, 126);
            this.txt_Answer4.Name = "txt_Answer4";
            this.txt_Answer4.Size = new System.Drawing.Size(215, 20);
            this.txt_Answer4.TabIndex = 15;
            // 
            // txt_Answer2
            // 
            this.txt_Answer2.Location = new System.Drawing.Point(31, 74);
            this.txt_Answer2.Name = "txt_Answer2";
            this.txt_Answer2.Size = new System.Drawing.Size(215, 20);
            this.txt_Answer2.TabIndex = 16;
            // 
            // txt_Answer3
            // 
            this.txt_Answer3.Location = new System.Drawing.Point(31, 100);
            this.txt_Answer3.Name = "txt_Answer3";
            this.txt_Answer3.Size = new System.Drawing.Size(215, 20);
            this.txt_Answer3.TabIndex = 17;
            // 
            // np_CorrectAnsw
            // 
            this.np_CorrectAnsw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.np_CorrectAnsw.Location = new System.Drawing.Point(862, 381);
            this.np_CorrectAnsw.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.np_CorrectAnsw.Name = "np_CorrectAnsw";
            this.np_CorrectAnsw.Size = new System.Drawing.Size(110, 20);
            this.np_CorrectAnsw.TabIndex = 18;
            // 
            // btn_AddQuest
            // 
            this.btn_AddQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddQuest.Location = new System.Drawing.Point(862, 407);
            this.btn_AddQuest.Name = "btn_AddQuest";
            this.btn_AddQuest.Size = new System.Drawing.Size(110, 23);
            this.btn_AddQuest.TabIndex = 19;
            this.btn_AddQuest.Text = "Add";
            this.btn_AddQuest.UseVisualStyleBackColor = true;
            this.btn_AddQuest.Click += new System.EventHandler(this.btn_AddQuest_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "New Question";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(767, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Correct Answer is";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "4";
            // 
            // gb_Answers
            // 
            this.gb_Answers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_Answers.Controls.Add(this.txt_Answer1);
            this.gb_Answers.Controls.Add(this.label10);
            this.gb_Answers.Controls.Add(this.txt_Answer4);
            this.gb_Answers.Controls.Add(this.label9);
            this.gb_Answers.Controls.Add(this.txt_Answer2);
            this.gb_Answers.Controls.Add(this.label8);
            this.gb_Answers.Controls.Add(this.txt_Answer3);
            this.gb_Answers.Controls.Add(this.label7);
            this.gb_Answers.Location = new System.Drawing.Point(284, 397);
            this.gb_Answers.Name = "gb_Answers";
            this.gb_Answers.Size = new System.Drawing.Size(259, 163);
            this.gb_Answers.TabIndex = 26;
            this.gb_Answers.TabStop = false;
            this.gb_Answers.Text = "Answer Options";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Survey.Properties.Resources.Umut_Pulat_Tulliana_2_Korganizer_128;
            this.pictureBox1.Location = new System.Drawing.Point(35, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(23, 170);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear Form";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // TestManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_Answers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_AddQuest);
            this.Controls.Add(this.np_CorrectAnsw);
            this.Controls.Add(this.txt_Question);
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
            this.gb_Answers.ResumeLayout(false);
            this.gb_Answers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btn_AddQuest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gb_Answers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Clear;
    }
}