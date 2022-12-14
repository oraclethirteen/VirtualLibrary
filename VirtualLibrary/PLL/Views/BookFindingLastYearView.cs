namespace VirtualLibrary
{
    public class BookFindingLastYearView
    {
        private readonly BookService _bookService;

        public BookFindingLastYearView(BookService bookService)
        {
            _bookService = bookService;
        }

        public void Show()
        {
            try
            {
                var book = _bookService.FindLastYearBook();

                SuccessMessage.Show(
                    $"ID: {book.Id}\n" +
                    $"Title: {book.Title}\n" +
                    $"Author: {book.Author}\n" +
                    $"Year: {book.Year}\n" +
                    $"Genre: {book.Genre}\n" +
                    $"UserID (читатель): {book.UserId}");
            }

            catch (Exception ex)
            {
                AlertMessage.Show("Произошла ошибка!\n" + ex.Message);
            }
        }
    }
}
