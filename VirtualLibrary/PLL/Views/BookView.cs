namespace VirtualLibrary
{
    public class BookView
    {
        public void Show()
        {
            InfoMessage.Show("\n\t<<< V I R T U A L    L I B R A R Y >>>\n");
            Console.WriteLine("Добавить книгу (1)");
            Console.WriteLine("Поиск книг по жанру и дате (2)");
            Console.WriteLine("Список всех книг (3)");
            Console.WriteLine("Полное описание книги (4)");
            Console.WriteLine("Новинки книг (5)");
            Console.WriteLine("Книги определённого автора (6)");
            Console.WriteLine("Книги определённого жанра (7)");
            Console.WriteLine("Получить книгу на руки (8)");
            Console.WriteLine("Вернуть книгу в библиотеку (9)");
            Console.WriteLine("Редактировать данные книги (10)");
            Console.WriteLine("Удалить книгу (11)");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Program.bookAddingView.Show();
                        break;
                    }

                case "2":
                    {
                        Program.bookFindingByGenreAndYearView.Show();
                        break;
                    }

                case "3":
                    {
                        Program.bookFindingAllView.Show();
                        break;
                    }

                case "4":
                    {
                        Program.bookFullDescriptionView.Show();
                        break;
                    }

                case "5":
                    {
                        Program.bookFindingLastYearView.Show();
                        break;
                    }

                case "6":
                    {
                        Program.bookCountingByAuthorView.Show();
                        break;
                    }

                case "7":
                    {
                        Program.bookCountingByGenreView.Show();
                        break;
                    }

                case "8":
                    {
                        Program.bookHandOveringView.Show();
                        break;
                    }

                case "9":
                    {
                        Program.bookReturningView.Show();
                        break;
                    }

                case "10":
                    {
                        Program.bookUpdatingView.Show();
                        break;
                    }

                case "11":
                    {
                        Program.bookDeletingView.Show();
                        break;
                    }
            }
        }
    }
}
