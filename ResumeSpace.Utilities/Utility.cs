namespace ResumeSpace.Utilities
{
    public static class Utility
    {
        public static int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate.Date < today.AddYears(-age))
                age--;
            return age;
        }
    }
}