namespace ExercicioDeFixacao_Excecoes.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message)
            : base(message)
        {
        }
    }
}
