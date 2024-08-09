namespace TaskManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            lblDescription = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            txtDateStart = new Label();
            dtpicStart = new DateTimePicker();
            txtPriority = new Label();
            cboPriority = new ComboBox();
            dgvTask = new DataGridView();
            dbTaskId = new DataGridViewTextBoxColumn();
            dbTitle = new DataGridViewTextBoxColumn();
            dbDescription = new DataGridViewTextBoxColumn();
            dbStatus = new DataGridViewTextBoxColumn();
            dbStart = new DataGridViewTextBoxColumn();
            dbPriority = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTask).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(34, 92);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Название: ";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(34, 133);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(82, 20);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Описание:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(142, 89);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(257, 27);
            txtTitle.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(142, 130);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(257, 67);
            txtDescription.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(34, 214);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Статус: ";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(142, 214);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(257, 28);
            cboStatus.TabIndex = 5;
            // 
            // txtDateStart
            // 
            txtDateStart.AutoSize = true;
            txtDateStart.Location = new Point(34, 260);
            txtDateStart.Name = "txtDateStart";
            txtDateStart.Size = new Size(68, 20);
            txtDateStart.TabIndex = 6;
            txtDateStart.Text = "Начало: ";
            // 
            // dtpicStart
            // 
            dtpicStart.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpicStart.Format = DateTimePickerFormat.Custom;
            dtpicStart.Location = new Point(142, 255);
            dtpicStart.Name = "dtpicStart";
            dtpicStart.Size = new Size(257, 27);
            dtpicStart.TabIndex = 7;
            // 
            // txtPriority
            // 
            txtPriority.AutoSize = true;
            txtPriority.Location = new Point(34, 303);
            txtPriority.Name = "txtPriority";
            txtPriority.Size = new Size(92, 20);
            txtPriority.TabIndex = 8;
            txtPriority.Text = "Приоритет: ";
            // 
            // cboPriority
            // 
            cboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPriority.FormattingEnabled = true;
            cboPriority.Location = new Point(142, 300);
            cboPriority.Name = "cboPriority";
            cboPriority.Size = new Size(257, 28);
            cboPriority.TabIndex = 9;
            // 
            // dgvTask
            // 
            dgvTask.AllowUserToDeleteRows = false;
            dgvTask.BackgroundColor = Color.White;
            dgvTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTask.Columns.AddRange(new DataGridViewColumn[] { dbTaskId, dbTitle, dbDescription, dbStatus, dbStart, dbPriority });
            dgvTask.Location = new Point(429, 12);
            dgvTask.Name = "dgvTask";
            dgvTask.ReadOnly = true;
            dgvTask.RowHeadersWidth = 51;
            dgvTask.Size = new Size(694, 498);
            dgvTask.TabIndex = 10;
            dgvTask.DoubleClick += dgvTask_DoubleClick;
            // 
            // dbTaskId
            // 
            dbTaskId.DataPropertyName = "TaskId";
            dbTaskId.HeaderText = "Идентификатор задачи";
            dbTaskId.MinimumWidth = 6;
            dbTaskId.Name = "dbTaskId";
            dbTaskId.ReadOnly = true;
            dbTaskId.Visible = false;
            dbTaskId.Width = 125;
            // 
            // dbTitle
            // 
            dbTitle.DataPropertyName = "TaskTitle";
            dbTitle.HeaderText = "Название";
            dbTitle.MinimumWidth = 6;
            dbTitle.Name = "dbTitle";
            dbTitle.ReadOnly = true;
            dbTitle.Width = 125;
            // 
            // dbDescription
            // 
            dbDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dbDescription.DataPropertyName = "TaskDescription";
            dbDescription.HeaderText = "Описание";
            dbDescription.MinimumWidth = 6;
            dbDescription.Name = "dbDescription";
            dbDescription.ReadOnly = true;
            // 
            // dbStatus
            // 
            dbStatus.DataPropertyName = "TaskStatus";
            dbStatus.HeaderText = "Статус";
            dbStatus.MinimumWidth = 6;
            dbStatus.Name = "dbStatus";
            dbStatus.ReadOnly = true;
            dbStatus.Width = 125;
            // 
            // dbStart
            // 
            dbStart.DataPropertyName = "TaskStart";
            dbStart.HeaderText = "Начало";
            dbStart.MinimumWidth = 6;
            dbStart.Name = "dbStart";
            dbStart.ReadOnly = true;
            dbStart.Width = 125;
            // 
            // dbPriority
            // 
            dbPriority.DataPropertyName = "TaskPriority";
            dbPriority.HeaderText = "Приоритет";
            dbPriority.MinimumWidth = 6;
            dbPriority.Name = "dbPriority";
            dbPriority.ReadOnly = true;
            dbPriority.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(34, 361);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(228, 361);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Очистить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(34, 396);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(228, 396);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(171, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 177, 39);
            ClientSize = new Size(1135, 522);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(dgvTask);
            Controls.Add(cboPriority);
            Controls.Add(txtPriority);
            Controls.Add(dtpicStart);
            Controls.Add(txtDateStart);
            Controls.Add(cboStatus);
            Controls.Add(lblStatus);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Менеджер задач";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Label txtDateStart;
        private DateTimePicker dtpicStart;
        private Label txtPriority;
        private ComboBox cboPriority;
        private DataGridView dgvTask;
        private Button btnAdd;
        private DataGridViewTextBoxColumn dbTaskId;
        private DataGridViewTextBoxColumn dbTitle;
        private DataGridViewTextBoxColumn dbDescription;
        private DataGridViewTextBoxColumn dbStatus;
        private DataGridViewTextBoxColumn dbStart;
        private DataGridViewTextBoxColumn dbPriority;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
