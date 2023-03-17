using Flower.Base;
using Flower.Enumerator;

namespace Flower.Floras
{
    public class PowerFlower : BaseFlower
    {
        public PowerFlower(int powerPoint, EnumFlowerColor flowerColor) 
        { 
            _powerPoint = powerPoint;
            SetFloraColor(flowerColor);
        }

    }
}
