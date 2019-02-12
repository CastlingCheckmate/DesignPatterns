using System;

using BuilderPattern.Enumerations;

namespace BuilderPattern
{

    public sealed class House : ICloneable
    {

        private Materials? _foundationMaterial;
        private Materials? _wallsMaterial;
        private Materials? _roofMaterial;

        public House()
        {
            _foundationMaterial = _wallsMaterial = _roofMaterial = null;
        }

        public Materials? FoundationMaterial
        {
            get => _foundationMaterial;

            set => _foundationMaterial = value;
        }

        public Materials? WallsMaterial
        {
            get => _wallsMaterial;

            set => _wallsMaterial = value;
        }

        public Materials? RoofMaterial
        {
            get => _roofMaterial;

            set => _roofMaterial = value;
        }

        public object Clone()
        {
            return new House()
            {
                FoundationMaterial = this.FoundationMaterial
                , RoofMaterial = this.RoofMaterial
                , WallsMaterial = this.WallsMaterial
            };
        }

    }

}