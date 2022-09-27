namespace VirtualLibrary
{
    public class BookReturningView
    {
        private readonly BookService _bookService;

        public BookReturningView(BookService bookService)
        {
            _bookService = bookService;
        }

        public void Show()
        {
            var bookData = new BookData();

            Console.WriteLine("Введите ID книги:");
            int.TryParse(Console.ReadLine(), out int bookId);
            bookData.Id = bookId;

            try
            {
                _bookService.ReturnBook(bookData);

                SuccessMessage.Show($"Книга успешно возвращена в библиотеку!");
            }

            catch (BookNotFoundException)
            {
                AlertMessage.Show("Книга с таким ID не найдена!");
            }

            catch (Exception ex)
            {
                AlertMessage.Show("Произошла ошибка!\n" + ex.Message);
            }
        }
    }
}
