namespace TaskManager
{
    public partial class Form1 : Form
    {
        private TaskContext taskDb = new TaskContext();
        private Task? task;
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBoxInitial()
        {
            string[] optionsStatus = { "�� ���������", "� ��������", "���������" };
            cboStatus.Items.AddRange(optionsStatus);
            string[] optionsPriority = { "������", "�������", "�������" };
            cboPriority.Items.AddRange(optionsPriority);
        }

        private void Clear()
        {
            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            cboStatus.SelectedIndex = -1;
            dtpicStart.Value = DateTime.Now;
            cboPriority.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxInitial();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            ActiveControl = txtTitle;
            ShowDataGridView();
        }

        private void ShowDataGridView()
        {
            dgvTask.AutoGenerateColumns = false;
            dgvTask.DataSource = taskDb.Tasks.ToList<Task>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            task = new()
            {
                TaskTitle = txtTitle.Text,
                TaskDescription = txtDescription.Text,
                TaskStatus = cboStatus.SelectedItem.ToString(),
                TaskStart = dtpicStart.Value,
                TaskPriority = cboPriority.SelectedItem.ToString()
            };
            try
            {
                taskDb.Tasks.Add(task);
                taskDb.SaveChanges();
                ShowDataGridView();
                MessageBox.Show("������ ������� ���������!");
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("������! �� ������� �������� ������.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvTask_DoubleClick(object sender, EventArgs e)
        {
            int taskId = Convert.ToInt32(dgvTask.CurrentRow.Cells["dbTaskId"].Value);
            try
            {
                task = taskDb.Tasks.Find(taskId);
                txtTitle.Text = task.TaskTitle;
                txtDescription.Text = task.TaskDescription;
                cboStatus.SelectedItem = task.TaskStatus;
                dtpicStart.Value = task.TaskStart;
                cboPriority.SelectedItem = task.TaskPriority;
            }
            catch (Exception)
            {
                MessageBox.Show("������!");
            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (task != null)
            {
                task.TaskTitle = txtTitle.Text;
                task.TaskDescription = txtDescription.Text;
                task.TaskStatus = cboStatus.SelectedItem.ToString();
                task.TaskStart = dtpicStart.Value;
                task.TaskPriority = cboPriority.SelectedItem.ToString();
                try
                {
                    taskDb.Tasks.Update(task);
                    taskDb.SaveChanges();
                    ShowDataGridView();
                    MessageBox.Show("������ ������� ���������!");
                    Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("������! �� ������� ��������");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (task!=null)
            {
                try
                {
                    taskDb.Tasks.Remove(task);
                    taskDb.SaveChanges();
                    ShowDataGridView();
                    MessageBox.Show("������ ������� �������!");
                    Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("������! �� ������� �������");
                }
            }
        }
    }
}
