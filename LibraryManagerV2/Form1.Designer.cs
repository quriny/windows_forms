namespace LibraryManagerV2
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
            lblTitle = new Label();
            lblAuthor = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            btnAdd = new Button();
            checker = new Label();
            btnCancel = new Button();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(40, 119);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(82, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Название:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(40, 158);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(58, 24);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Автор:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(40, 198);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(84, 24);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Описание:";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(192, 255, 255);
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Location = new Point(147, 194);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(223, 95);
            txtDescription.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.FromArgb(192, 255, 255);
            txtAuthor.BorderStyle = BorderStyle.None;
            txtAuthor.Location = new Point(147, 155);
            txtAuthor.Margin = new Padding(3, 4, 3, 4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(223, 22);
            txtAuthor.TabIndex = 4;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(192, 255, 255);
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Location = new Point(147, 115);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(223, 22);
            txtTitle.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 255);
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(40, 296);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 35);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // checker
            // 
            checker.AutoSize = true;
            checker.Location = new Point(14, 307);
            checker.Name = "checker";
            checker.Size = new Size(0, 24);
            checker.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 255, 255);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Location = new Point(210, 296);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 35);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(414, 14);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(553, 511);
            dataGridView1.TabIndex = 9;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 255, 255);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Location = new Point(210, 338);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(161, 35);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 255, 255);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Location = new Point(40, 338);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(161, 35);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(978, 540);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancel);
            Controls.Add(checker);
            Controls.Add(btnAdd);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthor);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Font = new Font("Sitka Display", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Список книг";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAuthor;
        private Label lblDescription;
        private TextBox txtDescription;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Button btnAdd;
        private Label checker;
        private Button btnCancel;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
