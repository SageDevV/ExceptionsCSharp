using ConsoleLog.Exceptions;

namespace ConsoleLog.Services
{
    public class ConsoleLogService 
    {
        public int Value { get; private set; }
        public ConsoleLogService(int value) 
        {
            if (value < 0)
            {
                throw new ConsoleLogException("O valor não pode ser menor que zero. " + "Exceção vinda do ConsoleLog.");
            }

            Value = value;
        }
    }
}
