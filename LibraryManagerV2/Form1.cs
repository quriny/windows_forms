using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LibraryManagerV2
{
    public partial class Form1 : Form
    {
        private BookContext bookDb;
        private List<Book> bookList;
        private Book? book;
        public Form1()
        {
            bookDb = new BookContext();
            InitializeComponent();
            ShowDataGridView();
            Clear();
            ActiveControl = txtTitle;
        }
        private void Clear()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtDescription.Text = "";
            btnAdd.Text = "Add";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            book = new()
            {
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                Description = txtDescription.Text.Trim()
            };
            try
            {
                bookDb.Books.Add(book);
                bookDb.SaveChanges();
                MessageBox.Show(" нига успешно добавлена!");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ќшибка! {ex.Message}");
            }
            ShowDataGridView();
        }

        private void ShowDataGridView()
        {
            dataGridView1.DataSource = bookDb.Books.ToList<Book>();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookId"].Value);
            try
            {
                book = bookDb.Books.Find(bookId);
                txtTitle.Text = book.Title;
                txtAuthor.Text = book.Author;
                txtDescription.Text = book.Description;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ќшибка! {ex.Message}");
            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (book != null)
            {
                book.Title = txtTitle.Text;
                book.Author = txtAuthor.Text;
                book.Description = txtDescription.Text;
                try
                {
                    bookDb.Books.Update(book);
                    bookDb.SaveChanges();
                    MessageBox.Show(" нига успешно обновлена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ќшибка! {ex.Message}");
                }
                ShowDataGridView();
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(book != null)
            {
                try
                {
                    bookDb.Books.Remove(book);
                    bookDb.SaveChanges();
                    MessageBox.Show(" нига успешно удалена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ќшибка! {ex.Message}");
                }
                ShowDataGridView();
                Clear();
            }
        }
    }
}
