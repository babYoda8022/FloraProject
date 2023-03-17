namespace Flower.Base
{
    public partial class BaseFlower
    {
        protected int _swimPoint;
        internal int SwimFlowerPoint { get { return _swimPoint; } }
        
        protected int _flyPoint;
        internal int FlyFlowerPoint { get { return _flyPoint; } }

        protected int _runPoint;
        internal int RunFlowerPoint { get { return _runPoint; } }

        protected int _powerPoint;
        internal int PowerFlowerPoint { get { return _powerPoint; } }

        protected int _staminaPoint;
        internal int StaminaFlowerPoint { get { return _staminaPoint; } }

    }
}
