using Flower.Base;
using Flower.Enumerator;

namespace Flower.Flowers
{
    public class StaminaFlower : BaseFlower
    {
        public StaminaFlower(int staminaPoint, EnumFlowerColor flowerColor) 
        { 
            _staminaPoint = staminaPoint;
            SetFloraColor(flowerColor);
        }

    }
}
