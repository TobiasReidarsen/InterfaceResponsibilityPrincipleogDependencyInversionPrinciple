namespace InterfaceResponsibilityPrincipleogDependencyInversionPrinciple
{
    internal class RandomPassword
    {
        private List<char> Password { get; set; }
        private int PasswordLenght { get; set; }

        public string MakePassword()
        {

            return "g32";
        }

        public RandomPassword(int passwordLenght)
        {
            PasswordLenght = passwordLenght;
            //_password = MakePassword();
        }
    }
}
