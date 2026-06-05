using BookStore.Models;

namespace BookStore
{
    public static class AppSession
    {
        public static UserInfo CurrentUser;

        public static bool IsGuest
        {
            get { return CurrentUser == null; }
        }

        public static bool IsAdmin
        {
            get
            {
                if (CurrentUser == null) return false;
                return CurrentUser.RoleName == "Администратор";
            }
        }

        public static bool IsManager
        {
            get
            {
                if (CurrentUser == null) return false;
                return CurrentUser.RoleName == "Менеджер";
            }
        }

        public static bool IsClient
        {
            get
            {
                if (CurrentUser == null) return false;
                return CurrentUser.RoleName == "Клиент";
            }
        }

        public static void Clear()
        {
            CurrentUser = null;
        }
    }
}