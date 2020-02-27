namespace MediatorPattern.Interfaces
{

    public interface ITargetComponent
    {

        IMediator Mediator
        {
            get;
        }

        void Receive(params object[] parameters);

    }

}