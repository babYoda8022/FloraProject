using Flora.Enumerator;

namespace Flora.Base
{
    public partial class BaseFlora
    {
        internal string? Name { get; set; }
        internal int Life { get; set; }

        private int _maxLife = 0;
        internal int MaxLife { get { return _maxLife; } }

        private bool _isAlive = false;
        internal bool IsAlive { get { return _isAlive; } }

        private EnumLifeCircleFlora _lifeCycle = EnumLifeCircleFlora.Child;
        internal EnumLifeCircleFlora LifeCycle { get { return _lifeCycle; } }
        internal void AddLife(int value)
        {
            int difLifeMaxlife = MaxLife - Life;

            if (value <= difLifeMaxlife)
                Life += value;
            else
                Life += difLifeMaxlife;
        }
        internal void RemoveLife(int value)
        {
            if (value >= Life)
            {
                Life -= value;
                SetIsAlive(false);
            }
            Life -= value;
        }
        internal void SetLifeCycle(EnumLifeCircleFlora lifeCircle)
        {
            _lifeCycle = lifeCircle;
        }
        internal void SetIsAlive(bool isAlive)
        {
            _isAlive = isAlive;
        }
        internal void SetMaxLife(int maxLife)
        {
            _maxLife = maxLife;
        }
    }
}
