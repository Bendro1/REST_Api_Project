using System.Runtime.Serialization;

namespace Courseproject.Business.Exceptions;

[Serializable]
public class TeamNotFoundExceptions : Exception
{
    public int Id { get; }

    public TeamNotFoundExceptions()
    {
    }

    public TeamNotFoundExceptions(int id)
    {
        this.Id = id;
    }

    public TeamNotFoundExceptions(string? message) : base(message)
    {
    }

    public TeamNotFoundExceptions(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected TeamNotFoundExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}