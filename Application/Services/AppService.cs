using App.Exceptions;

namespace App.Services
{
    public class AppService
    {
        public int Value { get; private set; }
        public AppService(int value)
        {
            if (value < 0)
            {
                throw new AppException("O valor não pode ser menor que zero. " + "Exceção vinda do App.");
            }

            Value = value;
        }
    }
}