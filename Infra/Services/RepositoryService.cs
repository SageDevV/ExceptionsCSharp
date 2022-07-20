using Infra.Exceptions;

namespace Infra.Services
{
    public class RepositoryService
    {
        public int Value { get; private set; }

        public RepositoryService(int value)
        {
            if (value < 0)
            {
                throw new RepositoryException("O valor não pode ser menor que zero. " + "Exceção vinda do Repositório."); 
            }

            Value = value;
        }
    }
}