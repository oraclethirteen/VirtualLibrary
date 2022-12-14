namespace VirtualLibrary
{
    public class BookDeletingView
    {
        private readonly BookService _bookService;

        public BookDeletingView(BookService bookService)
        {
            _bookService = bookService;
        }

        public void Show()
        {
            var bookData = new BookData();

            Console.WriteLine("Введите ID книги:");
            int.TryParse(Console.ReadLine(), out int id);
            bookData.Id = id;

            try
            {
                _bookService.DeleteBook(bookData);

                SuccessMessage.Show("Книга успешно удалена!");
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
