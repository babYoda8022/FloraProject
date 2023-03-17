using Flower.Base;
using Flower.Enumerator;

namespace Flower.Flowers
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
