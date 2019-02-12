using BuilderPattern.Enumerations;
using BuilderPattern.Interface;

namespace BuilderPattern.Implementation
{

    internal sealed class BrickHouseBuilder : IHouseBuilder
    {

        private House _constructed;

        public BrickHouseBuilder(House house = null)
        {
            _constructed = house ?? (new House());
        }

        public IHouseBuilder BuildFoundation()
        {
            _constructed.FoundationMaterial = Materials.Bricks;
            return this;
        }

        public IHouseBuilder BuildWalls()
        {
            _constructed.WallsMaterial = Materials.Bricks;
            return this;
        }

        public IHouseBuilder BuildRoof()
        {
            _constructed.RoofMaterial = Materials.Bricks;
            return this;
        }

        public IHouseBuilder Demontage()
        {
            _constructed = new House();
            return this;
        }

        public House GetResult()
        {
            return (House)_constructed.Clone();
        }

    }

}