using Domain.Exceptions;

namespace Domain.Services
{
    public class DomainService
    {
        public int Value { get; private set; }
        public DomainService()
        {

        }
        public DomainService(int value)
        {
            if (value < 0)
            {
                throw new DomainException("O valor não pode ser menor que zero. " + "Exceção vinda da Domain.");
            }

            Value = value;
        }
    }
}