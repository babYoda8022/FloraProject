using Flower.Base;
using Flower.Enumerator;

namespace Flower.Floras
{
    public class SwimFlower : BaseFlower
    {
        public SwimFlower(int swimPoint, EnumFlowerColor flowerColor) 
        { 
            _swimPoint = swimPoint;
            SetFloraColor(flowerColor);
        }

    }
}
