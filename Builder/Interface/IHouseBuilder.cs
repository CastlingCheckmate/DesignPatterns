using BuilderPattern.Enumerations;

namespace BuilderPattern.Interface
{

    public interface IHouseBuilder
    {

        IHouseBuilder BuildFoundation();
        IHouseBuilder BuildWalls();
        IHouseBuilder BuildRoof();
        IHouseBuilder Demontage();

    }

}