namespace VirtualLibrary
{
    public class UserView
    {
        public void Show()
        {
            InfoMessage.Show("\n\t<<< V I R T U A L    L I B R A R Y >>>\n");
            Console.WriteLine("Регистрация нового пользователя (1)");
            Console.WriteLine("Список всех пользователей (2)");
            Console.WriteLine("Список всех книг (3)");
            Console.WriteLine("Редактировать данные пользователя (4)");
            Console.WriteLine("Удалить пользователя (5)");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Program.userAddingView.Show();
                        break;
                    }

                case "2":
                    {
                        Program.userFindingAllView.Show();
                        break;
                    }

                case "3":
                    {
                        Program.userBooksCountingView.Show();
                        break;
                    }

                case "4":
                    {
                        Program.userUpdatingView.Show();
                        break;
                    }

                case "5":
                    {
                        Program.userDeletingView.Show();
                        break;
                    }
            }
        }
    }
}
