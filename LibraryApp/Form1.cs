using LibraryApp.EF_Core;
using Microsoft.EntityFrameworkCore;
using LibraryApp.Models;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        private readonly LibraryDBContext context = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGenres();
            LoadAuthors();
            LoadBooks();
        }

        private void LoadGenres()
        {
            var genres = context.Genres.AsNoTracking().OrderBy(g => g.Name).ToList();
            listBoxGenre.DataSource = genres;
            listBoxGenre.DisplayMember = "Name";

            comboBoxGenres.DataSource = genres;
            comboBoxGenres.DisplayMember = "Name";
            comboBoxGenres.ValueMember = "Id";

        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            string genreName = txtGenre.Text.Trim();
            if (string.IsNullOrWhiteSpace(genreName))
            {
                MessageBox.Show("Потрібно заповнити поле з назвою жанру!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGenre.Focus();
                return;
            }
            var res = context.Genres.Where(g => g.Name == genreName).FirstOrDefault();
            if (res != null)
            {
                MessageBox.Show("Жанр з такою назваю вже існує!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGenre.Focus();
                return;
            }

            context.Genres.Add(new Genre() { Id = 0, Name = genreName });
            context.SaveChanges();
            LoadGenres();
            txtGenre.Clear();
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            int k = listBoxGenre.SelectedIndex;
            if (k == -1)
            {
                MessageBox.Show("Потрібно вибрати жанр у списку!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selId = (listBoxGenre.SelectedItem as Genre)!.Id;
            var genre = context.Genres.Where(g => g.Id == selId).FirstOrDefault();
            if (genre == null)
            {
                MessageBox.Show("Такий жанр відсутній у базі!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                context.Genres.Remove(genre);
                context.SaveChanges();
                LoadGenres();
            }
            catch (DbUpdateException)
            {

                context.Entry(genre).State = EntityState.Unchanged;
                MessageBox.Show("Неможливо видалити жанр до нього привязані книги!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public void LoadAuthors()
        {
            var authors = context.Authors.AsNoTracking().OrderBy(a => a.LastName).ThenBy(a => a.FirstName).ToList();
            listBoxAuth.DataSource = null;
            listBoxAuth.DataSource = authors;

            comboBoxAuthors.DataSource = null;
            comboBoxAuthors.DataSource = authors
                .Select(a => new
                {
                    a.Id,
                    FullName = $"{a.LastName} {a.FirstName}"
                })
                .ToList();

            comboBoxAuthors.DisplayMember = "FullName";
            comboBoxAuthors.ValueMember = "Id";

        }

        private void btnAddAuth_Click(object sender, EventArgs e)
        {
            string firstName = txtFirtName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Потрібно заповнити поле імя чи прізвище автора!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirtName.Focus();
                return;
            }
            if (!int.TryParse(txtYearOfBirth.Text, out int birthYear) || birthYear < 1 || birthYear > DateTime.Now.Year)
            {
                MessageBox.Show("Рік народження повинен бути числом!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYearOfBirth.Focus();
                return;
            }
            bool exists = context.Authors.Any(a => a.FirstName == firstName && a.LastName == lastName && a.BirthYear == birthYear);
            if (exists)
            {
                MessageBox.Show("Такий автор вже існує у БД!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            context.Authors.Add(new Author
            {
                Id = 0,
                FirstName = firstName,
                LastName = lastName,
                BirthYear = birthYear
            });
            context.SaveChanges();
            txtFirtName.Clear();
            txtLastName.Clear();
            txtYearOfBirth.Clear();
            LoadAuthors();
        }

        private void btnDeleteAuth_Click(object sender, EventArgs e)
        {
            if (listBoxAuth.SelectedItem is not Author selected)
            {
                MessageBox.Show("Потрібно вибрати автора у списку!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var author = context.Authors.FirstOrDefault(a => a.Id == selected.Id);
            if (author == null)
            {
                MessageBox.Show("Такий автор відсутній у базі!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                context.Authors.Remove(author);
                context.SaveChanges();
                LoadAuthors();
                LoadBooks();
            }
            catch (DbUpdateException)
            {

                context.Entry(author).State = EntityState.Unchanged;
                MessageBox.Show("Неможливо видалити автора до нього привязані книги!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void LoadBooks()
        {
            var books = context.Books.AsNoTracking().Include(b => b.Author).Include(b => b.Genre).OrderBy(b => b.Title).ToList();
            listBoxBook.DataSource = null;
            listBoxBook.DataSource = books;

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Потрібно заповнити поле назви книжки!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }
            if (!int.TryParse(txtPublishYear.Text, out int publishYear) || publishYear < 1 || publishYear > DateTime.Now.Year)
            {
                MessageBox.Show("Рік видання повинен бути коректним числом!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPublishYear.Focus();
                return;
            }
            if (!int.TryParse(txtPages.Text, out int pages) || pages <= 0)
            {
                MessageBox.Show("Кількість сторінок повинна бути додатнім числом!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPages.Focus();
                return;
            }
            if(comboBoxAuthors.SelectedValue is not int authorId||comboBoxGenres.SelectedValue is not int genreId)
            {
                MessageBox.Show("Потрібно вибрати автора чи жанр!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            context.Books.Add(new Book
            {
                Id = 0,
                Title=title,
                PublishYear=publishYear,
                Pages=pages,
                IsAvailable=checkIsAval.Checked,
                AuthorId=authorId,
                GenreId=genreId
            });
            context.SaveChanges();
            txtFirtName.Clear();
            txtLastName.Clear();
            txtPublishYear.Clear();
            txtPages.Clear();
            checkIsAval.Checked = true;
            LoadBooks();
        }
    }
}
