using Microsoft.EntityFrameworkCore;

namespace LibraryAppGUI
{
    public partial class adminform : Form
    {
        private DbLibrary _context;

        public adminform(DbLibrary context)
        {
            InitializeComponent();
            _context = context;
            LoadBooks();
        }


        private void LoadBooks()
        {
            var books = ViewBooks(_context);

            if (books != null)
            {
                dataGridView.Rows.Clear();
                foreach (var book in books)
                {
                    // Buat DataGridViewRow baru
                    DataGridViewRow row = new DataGridViewRow();

                    // Tambahkan kolom-kolom sesuai dengan data buku
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = book.Id });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = book.Title });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = book.Author });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = book.ISBN });

                    // Tambahkan tombol delete ke dalam kolom
                    DataGridViewButtonCell deleteButtonCell = new DataGridViewButtonCell();
                    deleteButtonCell.Value = "Delete";
                    row.Cells.Add(deleteButtonCell);

                    // Tambahkan baris ke DataGridView
                    dataGridView.Rows.Add(row);
                }
            }
        }

        public List<Book> ViewBooks(DbLibrary context)
        {
            var loanedBookIds = context.Loans
                                       .Where(l => !l.ReturnDate.HasValue)
                                       .Select(l => l.BookId)
                                       .ToList();

            var books = context.Books
                               .Where(b => !loanedBookIds.Contains(b.Id))
                               .ToList();

            return books;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Do you want to delete this book?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int bookId = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value;
                    var bookToDelete = _context.Books.Find(bookId);

                    if (bookToDelete != null)
                    {
                        _context.Books.Remove(bookToDelete);
                        _context.SaveChanges();
                        LoadBooks();
                    }
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newBook = new Book
            {
                Title = textBox2.Text,
                Author = textBox3.Text,
                ISBN = textBox5.Text
            };

            _context.Books.Add(newBook);
            _context.SaveChanges();

            LoadBooks();
        }

        private List<Book> SearchBooksByTitle(DbLibrary context, string title)
        {
            var loanedBookIds = context.Loans
                                       .Where(l => !l.ReturnDate.HasValue)
                                       .Select(l => l.BookId)
                                       .ToList();

            var books = context.Books
                               .Where(b => !loanedBookIds.Contains(b.Id) && b.Title.Contains(title))
                               .ToList();

            return books;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim();
            var books = SearchBooksByTitle(_context, searchTerm);

            if (books != null)
            {
                dataGridView.Rows.Clear();
                foreach (var book in books)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView);

                    row.Cells[0].Value = book.Id;
                    row.Cells[1].Value = book.Title;
                    row.Cells[2].Value = book.Author;
                    row.Cells[3].Value = book.ISBN;

                    DataGridViewButtonCell deleteButtonCell = new DataGridViewButtonCell();
                    deleteButtonCell.Value = "Delete";
                    row.Cells[4] = deleteButtonCell;

                    dataGridView.Rows.Add(row);
                }
            }
        }

    }
}
