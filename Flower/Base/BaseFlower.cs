using Flower.Enumerator;
namespace Flower.Base
{
    public partial class BaseFlower
    {
        private EnumFlowerColor _flowerColor = EnumFlowerColor.None;
        
        private EnumLifeCircleFlower _lifeCircleFlower = EnumLifeCircleFlower.Seed;
        internal EnumLifeCircleFlower LifeCircleFlower { get { return _lifeCircleFlower; } }

        internal void SetLifeCircleFlora(EnumLifeCircleFlower lifeCircleFlower)
        {
            _lifeCircleFlower = lifeCircleFlower;
        }
        internal void SetFloraColor(EnumFlowerColor flowerColor)
        {
            _flowerColor = flowerColor;
        }

    }
}
