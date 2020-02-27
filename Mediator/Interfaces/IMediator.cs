namespace MediatorPattern.Interfaces
{

    public interface IMediator
    {

        void Notify(ITargetComponent sender, params object[] parameters);

    }

}