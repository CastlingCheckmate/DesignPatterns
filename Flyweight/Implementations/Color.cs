using System;

namespace FlyweightPattern.Implementations
{

    public sealed class Color : IEquatable<Color>
    {

        private byte _r;
        private byte _g;
        private byte _b;
        private byte _a;

        public Color(byte r, byte g, byte b, byte a)
        {
            _r = r;
            _g = g;
            _b = b;
            _a = a;
        }

        public byte R =>
            _r;

        public byte G =>
            _g;

        public byte B =>
            _b;

        public byte A =>
            _a;

        public bool Equals(Color other)
        {
            if (other == null)
            {
                return false;
            }
            return R == other.R && G == other.G && B == other.B && A == other.A;
        }

    }

}