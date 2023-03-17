using Flower.Base;
using Flower.Enumerator;

namespace Flower.Flowers
{
    public class FlyFlower : BaseFlower
    {
        public FlyFlower(int powerPoint, EnumFlowerColor flowerColor) 
        { 
            _flyPoint = powerPoint;
            SetFloraColor(flowerColor);
        }

    }
}
