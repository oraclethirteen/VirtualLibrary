namespace VirtualLibrary
{
    public class MainView
    {
        public void Show()
        {
            InfoMessage.Show("\n\t<<< V I R T U A L    L I B R A R Y >>>\n");
            Console.WriteLine("Пользователи (1)");
            Console.WriteLine("Книги (2)");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Program.userView.Show();
                        break;
                    }

                case "2":
                    {
                        Program.bookView.Show();
                        break;
                    }
            }
        }
    }
}
