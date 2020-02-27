namespace ChainOfResponsibilityPattern.Interfaces
{

    public interface IHandler<T>
    {

        bool Handle(T request);

        IHandler<T> Next
        {
            set;
        }

    }

}