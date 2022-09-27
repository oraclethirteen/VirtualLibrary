namespace VirtualLibrary
{
    public class BookFindingAllView
    {
        private readonly BookService _bookService;

        public BookFindingAllView(BookService bookService)
        {
            _bookService = bookService;
        }

        public void Show()
        {
            try
            {
                var allBooks = _bookService.FindAllBooks();

                foreach (var book in allBooks)
                {
                    SuccessMessage.Show(
                        $"ID: {book.Id}, " +
                        $"Title: {book.Title}, " +
                        $"UserID (читатель): {book.UserId}");
                }
            }

            catch (Exception ex)
            {
                AlertMessage.Show("Произошла ошибка!\n" + ex.Message);
            }
        }
    }
}
