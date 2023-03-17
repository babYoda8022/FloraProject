using Flower.Enumerator;
namespace Flower.Base
{
    public partial class BaseFlower
    {
        private EnumFlowerColor _flowerColor = EnumFlowerColor.None;
        
        private EnumLifeCircleFlower _lifeCircleFlower = EnumLifeCircleFlower.Seed;
        public EnumLifeCircleFlower LifeCircleFlower { get { return _lifeCircleFlower; } }

        public void SetLifeCircleFlora(EnumLifeCircleFlower lifeCircleFlower)
        {
            _lifeCircleFlower = lifeCircleFlower;
        }
        public void SetFloraColor(EnumFlowerColor flowerColor)
        {
            _flowerColor = flowerColor;
        }

    }
}
