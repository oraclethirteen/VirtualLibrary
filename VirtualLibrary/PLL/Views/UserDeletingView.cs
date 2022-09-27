namespace VirtualLibrary
{
    public class UserDeletingView
    {
        private readonly UserService _userService;

        public UserDeletingView(UserService userService)
        {
            _userService = userService;
        }

        public void Show()
        {
            var userData = new UserData();

            Console.WriteLine("Введите ID пользователя:");
            int.TryParse(Console.ReadLine(), out int id);
            userData.Id = id;

            try
            {
                _userService.DeleteUser(userData);

                SuccessMessage.Show("Пользователь успешно удалён!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь с данным ID не найден!");
            }

            catch (Exception ex)
            {
                AlertMessage.Show("Произошла ошибка!\n" + ex.Message);
            }
        }
    }
}
