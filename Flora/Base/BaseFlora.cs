using Flora.Enumerator;

namespace Flora.Base
{
    public partial class BaseFlora
    {
        internal string? Name { get; set; }
        internal int Life { get; set; }

        private int _maxLife = 0;
        public int MaxLife { get { return _maxLife; } }

        private bool _isAlive = false;
        public bool IsAlive { get { return _isAlive; } }

        private EnumLifeCircleFlora _lifeCycle = EnumLifeCircleFlora.Child;
        public EnumLifeCircleFlora LifeCycle { get { return _lifeCycle; } }
        public void AddLife(int value)
        {
            int difLifeMaxlife = MaxLife - Life;

            if (value <= difLifeMaxlife)
                Life += value;
            else
                Life += difLifeMaxlife;
        }
        public void RemoveLife(int value)
        {
            if (value >= Life)
            {
                Life -= value;
                SetIsAlive(false);
            }
            Life -= value;
        }
        public void SetLifeCycle(EnumLifeCircleFlora lifeCircle)
        {
            _lifeCycle = lifeCircle;
        }
        public void SetIsAlive(bool isAlive)
        {
            _isAlive = isAlive;
        }
        public void SetMaxLife(int maxLife)
        {
            _maxLife = maxLife;
        }
    }
}
