using System.Linq;

using BuilderPattern.Implementation;

namespace BuilderPattern.Implementation
{

    internal sealed class Program
    {

        static void Main(string[] args)
        {
            var steelBuilder = new WoodHouseBuilder();
            steelBuilder.BuildFoundation();
            steelBuilder.BuildRoof();
            steelBuilder.BuildWalls();
            var house = steelBuilder.GetResult();
            #region !
            house = ((SteelHouseBuilder)new SteelHouseBuilder()
                .BuildFoundation())
                .GetResult();
            house = ((BrickHouseBuilder)new BrickHouseBuilder(house)
                .BuildWalls())
                .GetResult();
            house = ((WoodHouseBuilder)new WoodHouseBuilder(house)
                .BuildRoof())
                .GetResult();
            #endregion
        }

    }

}