namespace VirtualLibrary
{
    public class BookHandOveringView
    {
        private readonly BookService _bookService;

        public BookHandOveringView(BookService bookService)
        {
            _bookService = bookService;
        }

        public void Show()
        {
            var bookData = new BookData();
            var userData = new UserData();

            Console.WriteLine("Введите ID книги:");
            int.TryParse(Console.ReadLine(), out int bookId);
            bookData.Id = bookId;

            Console.WriteLine("Введите ID пользователя:");
            int.TryParse(Console.ReadLine(), out int userId);
            userData.Id = userId;

            try
            {
                _bookService.HandOverBook(bookData, userData);

                SuccessMessage.Show($"Книга успешно выдана пользователю!");
            }

            catch (BookNotFoundException)
            {
                AlertMessage.Show("Книга с таким ID не найдена!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь с таким ID не найден!");
            }

            catch (BookExistException)
            {
                AlertMessage.Show("Книга с таким ID уже выдана!");
            }

            catch (Exception ex)
            {
                AlertMessage.Show("Произошла ошибка!\n" + ex.Message);
            }
        }
    }
}
