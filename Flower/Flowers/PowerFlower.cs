using Flower.Base;
using Flower.Enumerator;

namespace Flower.Flowers
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
