namespace API.Extensions
{
    public static class DateTimeExtensios
    {
        public static int CalculateAge(this DateOnly dateOdBirth)
        {
            var today = DateOnly.FromDateTime(DateTime.UtcNow);

            var age = today.Year - dateOdBirth.Year;

            if (dateOdBirth > today.AddYears(-age)) age--;
            
            return age;
        }
    }
}