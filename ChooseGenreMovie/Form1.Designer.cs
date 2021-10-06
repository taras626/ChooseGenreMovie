
namespace ChooseGenreMovie
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.p_MainMenu = new System.Windows.Forms.Panel();
            this.p_Test = new System.Windows.Forms.Panel();
            this.p_Result = new System.Windows.Forms.Panel();
            this.b_End = new System.Windows.Forms.Button();
            this.l_Result = new System.Windows.Forms.Label();
            this.l_TextOfQuestion = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.b_Further = new System.Windows.Forms.Button();
            this.b_Exit = new System.Windows.Forms.Button();
            this.b_Back = new System.Windows.Forms.Button();
            this.l_Question = new System.Windows.Forms.Label();
            this.b_Settings = new System.Windows.Forms.Button();
            this.b_Test = new System.Windows.Forms.Button();
            this.l_Title = new System.Windows.Forms.Label();
            this.l_Desc = new System.Windows.Forms.Label();
            this.gb_Desc = new System.Windows.Forms.GroupBox();
            this.p_MainMenu.SuspendLayout();
            this.p_Test.SuspendLayout();
            this.p_Result.SuspendLayout();
            this.gb_Desc.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_MainMenu
            // 
            this.p_MainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_MainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.p_MainMenu.Controls.Add(this.p_Test);
            this.p_MainMenu.Controls.Add(this.b_Settings);
            this.p_MainMenu.Controls.Add(this.b_Test);
            this.p_MainMenu.Controls.Add(this.l_Title);
            this.p_MainMenu.Controls.Add(this.l_Desc);
            this.p_MainMenu.Location = new System.Drawing.Point(17, 15);
            this.p_MainMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_MainMenu.Name = "p_MainMenu";
            this.p_MainMenu.Size = new System.Drawing.Size(856, 521);
            this.p_MainMenu.TabIndex = 0;
            // 
            // p_Test
            // 
            this.p_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_Test.Controls.Add(this.gb_Desc);
            this.p_Test.Controls.Add(this.p_Result);
            this.p_Test.Controls.Add(this.l_TextOfQuestion);
            this.p_Test.Controls.Add(this.b_Further);
            this.p_Test.Controls.Add(this.b_Exit);
            this.p_Test.Controls.Add(this.b_Back);
            this.p_Test.Controls.Add(this.l_Question);
            this.p_Test.Location = new System.Drawing.Point(0, 0);
            this.p_Test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_Test.Name = "p_Test";
            this.p_Test.Size = new System.Drawing.Size(856, 521);
            this.p_Test.TabIndex = 1;
            this.p_Test.Visible = false;
            // 
            // p_Result
            // 
            this.p_Result.Controls.Add(this.b_End);
            this.p_Result.Controls.Add(this.l_Result);
            this.p_Result.Location = new System.Drawing.Point(0, 0);
            this.p_Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_Result.Name = "p_Result";
            this.p_Result.Size = new System.Drawing.Size(856, 522);
            this.p_Result.TabIndex = 9;
            this.p_Result.Visible = false;
            // 
            // b_End
            // 
            this.b_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_End.Location = new System.Drawing.Point(729, 474);
            this.b_End.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_End.Name = "b_End";
            this.b_End.Size = new System.Drawing.Size(100, 28);
            this.b_End.TabIndex = 1;
            this.b_End.Text = "Завершить";
            this.b_End.UseVisualStyleBackColor = true;
            this.b_End.Click += new System.EventHandler(this.b_End_Click);
            // 
            // l_Result
            // 
            this.l_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Result.AutoSize = true;
            this.l_Result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Result.Location = new System.Drawing.Point(80, 89);
            this.l_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_Result.Name = "l_Result";
            this.l_Result.Size = new System.Drawing.Size(70, 27);
            this.l_Result.TabIndex = 0;
            this.l_Result.Text = "label1";
            this.l_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_TextOfQuestion
            // 
            this.l_TextOfQuestion.AutoSize = true;
            this.l_TextOfQuestion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_TextOfQuestion.Location = new System.Drawing.Point(159, 89);
            this.l_TextOfQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_TextOfQuestion.Name = "l_TextOfQuestion";
            this.l_TextOfQuestion.Size = new System.Drawing.Size(0, 27);
            this.l_TextOfQuestion.TabIndex = 8;
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(37, 173);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(160, 31);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(37, 134);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(160, 31);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(37, 95);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(160, 31);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(37, 56);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(160, 31);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // b_Further
            // 
            this.b_Further.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Further.Location = new System.Drawing.Point(621, 473);
            this.b_Further.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_Further.Name = "b_Further";
            this.b_Further.Size = new System.Drawing.Size(100, 28);
            this.b_Further.TabIndex = 3;
            this.b_Further.Text = "Далее";
            this.b_Further.UseVisualStyleBackColor = true;
            this.b_Further.Click += new System.EventHandler(this.b_Further_Click);
            // 
            // b_Exit
            // 
            this.b_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Exit.Location = new System.Drawing.Point(729, 473);
            this.b_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_Exit.Name = "b_Exit";
            this.b_Exit.Size = new System.Drawing.Size(100, 28);
            this.b_Exit.TabIndex = 2;
            this.b_Exit.Text = "Выход";
            this.b_Exit.UseVisualStyleBackColor = true;
            this.b_Exit.Click += new System.EventHandler(this.b_Exit_Click);
            // 
            // b_Back
            // 
            this.b_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_Back.Location = new System.Drawing.Point(25, 473);
            this.b_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_Back.Name = "b_Back";
            this.b_Back.Size = new System.Drawing.Size(100, 28);
            this.b_Back.TabIndex = 1;
            this.b_Back.Text = "Назад";
            this.b_Back.UseVisualStyleBackColor = true;
            this.b_Back.Click += new System.EventHandler(this.b_Back_Click);
            // 
            // l_Question
            // 
            this.l_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Question.AutoSize = true;
            this.l_Question.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Question.Location = new System.Drawing.Point(51, 89);
            this.l_Question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_Question.Name = "l_Question";
            this.l_Question.Size = new System.Drawing.Size(95, 27);
            this.l_Question.TabIndex = 0;
            this.l_Question.Text = "Вопрос:";
            // 
            // b_Settings
            // 
            this.b_Settings.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Settings.Location = new System.Drawing.Point(233, 293);
            this.b_Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_Settings.Name = "b_Settings";
            this.b_Settings.Size = new System.Drawing.Size(387, 86);
            this.b_Settings.TabIndex = 3;
            this.b_Settings.Text = "Подключить тест";
            this.b_Settings.UseVisualStyleBackColor = true;
            this.b_Settings.Click += new System.EventHandler(this.b_Settings_Click);
            // 
            // b_Test
            // 
            this.b_Test.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Test.Location = new System.Drawing.Point(233, 199);
            this.b_Test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_Test.Name = "b_Test";
            this.b_Test.Size = new System.Drawing.Size(387, 86);
            this.b_Test.TabIndex = 2;
            this.b_Test.Text = "Начать тест!";
            this.b_Test.UseVisualStyleBackColor = true;
            this.b_Test.Click += new System.EventHandler(this.b_Test_Click);
            // 
            // l_Title
            // 
            this.l_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_Title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Title.Location = new System.Drawing.Point(0, 0);
            this.l_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_Title.Name = "l_Title";
            this.l_Title.Size = new System.Drawing.Size(856, 114);
            this.l_Title.TabIndex = 0;
            this.l_Title.Text = "Добрый вечер! \r\nНаш опросник \"Опросник Т.В.\" поможет вам \r\nвыбрать жанр кино на с" +
    "егодняшний вечер! ";
            this.l_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_Desc
            // 
            this.l_Desc.AutoSize = true;
            this.l_Desc.Location = new System.Drawing.Point(52, 479);
            this.l_Desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_Desc.Name = "l_Desc";
            this.l_Desc.Size = new System.Drawing.Size(53, 17);
            this.l_Desc.TabIndex = 4;
            this.l_Desc.Text = "fdklsag";
            // 
            // gb_Desc
            // 
            this.gb_Desc.Controls.Add(this.radioButton1);
            this.gb_Desc.Controls.Add(this.radioButton2);
            this.gb_Desc.Controls.Add(this.radioButton3);
            this.gb_Desc.Controls.Add(this.radioButton4);
            this.gb_Desc.Location = new System.Drawing.Point(25, 162);
            this.gb_Desc.Name = "gb_Desc";
            this.gb_Desc.Size = new System.Drawing.Size(804, 304);
            this.gb_Desc.TabIndex = 10;
            this.gb_Desc.TabStop = false;
            this.gb_Desc.Text = "Описание";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(889, 550);
            this.Controls.Add(this.p_MainMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_MainMenu.ResumeLayout(false);
            this.p_MainMenu.PerformLayout();
            this.p_Test.ResumeLayout(false);
            this.p_Test.PerformLayout();
            this.p_Result.ResumeLayout(false);
            this.p_Result.PerformLayout();
            this.gb_Desc.ResumeLayout(false);
            this.gb_Desc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_MainMenu;
        private System.Windows.Forms.Label l_Title;
        private System.Windows.Forms.Panel p_Test;
        private System.Windows.Forms.Button b_Further;
        private System.Windows.Forms.Button b_Exit;
        private System.Windows.Forms.Button b_Back;
        private System.Windows.Forms.Label l_Question;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button b_Test;
        private System.Windows.Forms.Button b_Settings;
        private System.Windows.Forms.Label l_Desc;
        private System.Windows.Forms.Label l_TextOfQuestion;
        private System.Windows.Forms.Panel p_Result;
        private System.Windows.Forms.Button b_End;
        private System.Windows.Forms.Label l_Result;
        private System.Windows.Forms.GroupBox gb_Desc;
    }
}

