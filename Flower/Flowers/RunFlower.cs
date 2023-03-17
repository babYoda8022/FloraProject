using Flower.Base;
using Flower.Enumerator;

namespace Flower.Flowers
{
    public class RunFlower : BaseFlower
    {
        public RunFlower(int runPoint, EnumFlowerColor flowerColor) 
        { 
            _runPoint = runPoint;
            SetFloraColor(flowerColor);
        }

    }
}
