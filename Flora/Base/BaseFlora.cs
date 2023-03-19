using Flora.Enumerator;

namespace Flora.Base
{
    public partial class BaseFlora
    {
        public string Name { get; set; }
        protected int _life = 0;
        public int Life { get { return _life; } }

        protected int _maxLife = 0;
        public int MaxLife { get { return _maxLife; } }

        private bool _isAlive = false;
        public bool IsAlive { get { return _isAlive; } }

        private EnumLifeCircleFlora _lifeCycle = EnumLifeCircleFlora.Child;
        public EnumLifeCircleFlora LifeCycle { get { return _lifeCycle; } }
        public void AddLife(int value)
        {
            int difLifeMaxlife = MaxLife - _life;

            if (value <= difLifeMaxlife)
                _life += value;
            else
                _life += difLifeMaxlife;
        }
        public void RemoveLife(int value)
        {
            if (value >= _life)
            {
                _life -= value;
                SetIsAlive(false);
            }
            _life -= value;
        }
        public void SetLifeCycle(EnumLifeCircleFlora lifeCircle)
        {
            _lifeCycle = lifeCircle;
        }
        public void SetIsAlive(bool isAlive)
        {
            _isAlive = isAlive;
        }
    }
}
