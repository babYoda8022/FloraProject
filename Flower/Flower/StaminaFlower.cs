using Flower.Base;
using Flower.Enumerator;

namespace Flower.Floras
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
