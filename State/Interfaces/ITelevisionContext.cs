namespace StatePattern.Interfaces
{

    public interface ITelevisionContext
    {

        ITelevisionState State
        {
            set;
        }

    }

}