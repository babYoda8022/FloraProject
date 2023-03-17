using Flower.Base;
using Flower.Enumerator;

namespace Flower.Floras
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
