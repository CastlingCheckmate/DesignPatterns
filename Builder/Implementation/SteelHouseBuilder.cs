using BuilderPattern.Enumerations;
using BuilderPattern.Interface;

namespace BuilderPattern.Implementation
{

    internal sealed class SteelHouseBuilder : IHouseBuilder
    {

        private House _constructed;

        public SteelHouseBuilder()
        {
            _constructed = new House();
        }

        public IHouseBuilder BuildFoundation()
        {
            _constructed.FoundationMaterial = Materials.Steel;
            return this;
        }

        public IHouseBuilder BuildWalls()
        {
            _constructed.WallsMaterial = Materials.Steel;
            return this;
        }

        public IHouseBuilder BuildRoof()
        {
            _constructed.RoofMaterial = Materials.Steel;
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