using BuilderPattern.Enumerations;
using BuilderPattern.Interface;

namespace BuilderPattern.Implementation
{

    internal sealed class WoodHouseBuilder : IHouseBuilder
    {

        private House _constructed;

        public WoodHouseBuilder()
        {
            _constructed = new House();
        }

        public IHouseBuilder BuildFoundation()
        {
            _constructed.FoundationMaterial = Materials.Wood;
            return this;
        }

        public IHouseBuilder BuildWalls()
        {
            _constructed.WallsMaterial = Materials.Wood;
            return this;
        }

        public IHouseBuilder BuildRoof()
        {
            _constructed.RoofMaterial = Materials.Wood;
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