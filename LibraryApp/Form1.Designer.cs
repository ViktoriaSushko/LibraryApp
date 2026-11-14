namespace LibraryApp
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Genre = new GroupBox();
            label3 = new Label();
            btnDeleteGenre = new Button();
            button1 = new Button();
            txtGenre = new TextBox();
            listBoxGenre = new ListBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtYearOfBirth = new TextBox();
            txtLastName = new TextBox();
            txtFirtName = new TextBox();
            btnDeleteAuth = new Button();
            btnAddAuth = new Button();
            listBoxAuth = new ListBox();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnDelBook = new Button();
            btnAddBook = new Button();
            checkIsAval = new CheckBox();
            txtPages = new TextBox();
            txtPublishYear = new TextBox();
            txtTitle = new TextBox();
            listBoxBook = new ListBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxAuthors = new ComboBox();
            comboBoxGenres = new ComboBox();
            Genre.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Genre
            // 
            Genre.Controls.Add(label3);
            Genre.Controls.Add(btnDeleteGenre);
            Genre.Controls.Add(button1);
            Genre.Controls.Add(txtGenre);
            Genre.Controls.Add(listBoxGenre);
            Genre.Location = new Point(12, 12);
            Genre.Name = "Genre";
            Genre.Size = new Size(250, 267);
            Genre.TabIndex = 0;
            Genre.TabStop = false;
            Genre.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 171);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.Location = new Point(171, 227);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(73, 34);
            btnDeleteGenre.TabIndex = 3;
            btnDeleteGenre.Text = "Delete";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            btnDeleteGenre.Click += btnDeleteGenre_Click;
            // 
            // button1
            // 
            button1.Location = new Point(8, 227);
            button1.Name = "button1";
            button1.Size = new Size(73, 34);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddGenre_Click;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(8, 194);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(163, 27);
            txtGenre.TabIndex = 1;
            // 
            // listBoxGenre
            // 
            listBoxGenre.FormattingEnabled = true;
            listBoxGenre.Location = new Point(6, 27);
            listBoxGenre.Name = "listBoxGenre";
            listBoxGenre.Size = new Size(238, 144);
            listBoxGenre.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtYearOfBirth);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirtName);
            groupBox1.Controls.Add(btnDeleteAuth);
            groupBox1.Controls.Add(btnAddAuth);
            groupBox1.Controls.Add(listBoxAuth);
            groupBox1.Location = new Point(297, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 395);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Author";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 299);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 10;
            label6.Text = "YearOfBith";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 246);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 9;
            label5.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 193);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 8;
            label4.Text = "FirstName";
            // 
            // txtYearOfBirth
            // 
            txtYearOfBirth.Location = new Point(14, 322);
            txtYearOfBirth.Name = "txtYearOfBirth";
            txtYearOfBirth.Size = new Size(191, 27);
            txtYearOfBirth.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(14, 272);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(191, 27);
            txtLastName.TabIndex = 6;
            // 
            // txtFirtName
            // 
            txtFirtName.Location = new Point(14, 216);
            txtFirtName.Name = "txtFirtName";
            txtFirtName.Size = new Size(191, 27);
            txtFirtName.TabIndex = 5;
            // 
            // btnDeleteAuth
            // 
            btnDeleteAuth.Location = new Point(222, 355);
            btnDeleteAuth.Name = "btnDeleteAuth";
            btnDeleteAuth.Size = new Size(73, 34);
            btnDeleteAuth.TabIndex = 4;
            btnDeleteAuth.Text = "Delete";
            btnDeleteAuth.UseVisualStyleBackColor = true;
            btnDeleteAuth.Click += btnDeleteAuth_Click;
            // 
            // btnAddAuth
            // 
            btnAddAuth.Location = new Point(8, 355);
            btnAddAuth.Name = "btnAddAuth";
            btnAddAuth.Size = new Size(73, 34);
            btnAddAuth.TabIndex = 3;
            btnAddAuth.Text = "Add";
            btnAddAuth.UseVisualStyleBackColor = true;
            btnAddAuth.Click += btnAddAuth_Click;
            // 
            // listBoxAuth
            // 
            listBoxAuth.FormattingEnabled = true;
            listBoxAuth.Location = new Point(8, 26);
            listBoxAuth.Name = "listBoxAuth";
            listBoxAuth.Size = new Size(287, 164);
            listBoxAuth.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnDelBook);
            groupBox2.Controls.Add(btnAddBook);
            groupBox2.Controls.Add(checkIsAval);
            groupBox2.Controls.Add(txtPages);
            groupBox2.Controls.Add(txtPublishYear);
            groupBox2.Controls.Add(txtTitle);
            groupBox2.Controls.Add(listBoxBook);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBoxAuthors);
            groupBox2.Controls.Add(comboBoxGenres);
            groupBox2.Location = new Point(628, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(521, 395);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Book";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(338, 240);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 14;
            label9.Text = "Pages";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(339, 183);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 13;
            label8.Text = "Publish year";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(338, 124);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 12;
            label7.Text = "Title";
            // 
            // btnDelBook
            // 
            btnDelBook.Location = new Point(442, 355);
            btnDelBook.Name = "btnDelBook";
            btnDelBook.Size = new Size(73, 34);
            btnDelBook.TabIndex = 11;
            btnDelBook.Text = "Delete";
            btnDelBook.UseVisualStyleBackColor = true;
            btnDelBook.Click += btnDelBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(335, 355);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(73, 34);
            btnAddBook.TabIndex = 9;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // checkIsAval
            // 
            checkIsAval.AutoSize = true;
            checkIsAval.Location = new Point(338, 299);
            checkIsAval.Name = "checkIsAval";
            checkIsAval.Size = new Size(112, 24);
            checkIsAval.TabIndex = 8;
            checkIsAval.Text = "Is available?";
            checkIsAval.UseVisualStyleBackColor = true;
            // 
            // txtPages
            // 
            txtPages.Location = new Point(335, 266);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(176, 27);
            txtPages.TabIndex = 7;
            // 
            // txtPublishYear
            // 
            txtPublishYear.Location = new Point(335, 210);
            txtPublishYear.Name = "txtPublishYear";
            txtPublishYear.Size = new Size(176, 27);
            txtPublishYear.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(335, 147);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(176, 27);
            txtTitle.TabIndex = 5;
            // 
            // listBoxBook
            // 
            listBoxBook.FormattingEnabled = true;
            listBoxBook.HorizontalScrollbar = true;
            listBoxBook.Location = new Point(6, 29);
            listBoxBook.Name = "listBoxBook";
            listBoxBook.Size = new Size(323, 324);
            listBoxBook.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 70);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Authors";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 16);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 2;
            label1.Text = "Genres";
            // 
            // comboBoxAuthors
            // 
            comboBoxAuthors.FormattingEnabled = true;
            comboBoxAuthors.Location = new Point(335, 93);
            comboBoxAuthors.Name = "comboBoxAuthors";
            comboBoxAuthors.Size = new Size(180, 28);
            comboBoxAuthors.TabIndex = 1;
            // 
            // comboBoxGenres
            // 
            comboBoxGenres.FormattingEnabled = true;
            comboBoxGenres.Location = new Point(335, 39);
            comboBoxGenres.Name = "comboBoxGenres";
            comboBoxGenres.Size = new Size(180, 28);
            comboBoxGenres.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Genre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Genre.ResumeLayout(false);
            Genre.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox Genre;
        private TextBox txtGenre;
        private ListBox listBoxGenre;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnDeleteGenre;
        private Button button1;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxAuthors;
        private ComboBox comboBoxGenres;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtYearOfBirth;
        private TextBox txtLastName;
        private TextBox txtFirtName;
        private Button btnDeleteAuth;
        private Button btnAddAuth;
        private ListBox listBoxAuth;
        private ListBox listBoxBook;
        private TextBox txtTitle;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnDelBook;
        private Button btnAddBook;
        private CheckBox checkIsAval;
        private TextBox txtPages;
        private TextBox txtPublishYear;
    }
}
