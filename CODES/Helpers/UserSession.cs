public static class UserSession
    {
        public static Employee? CurrentEmployee { get; set; }
        public static Account? CurrentAccount { get; set; }

        public static void LogOut()
        {
            CurrentEmployee = null;
            CurrentAccount = null;
        }
    }