
namespace Flora.Base
{
    public partial class BaseFlora
    {
        private int _swimLevel = 0;
        internal int SwimLevel { get { return _swimLevel; } }

        private int _flyLevel = 0;
        internal int FlyLevel { get { return _flyLevel; } }

        private int _runLevel = 0;
        internal int RunLevel { get { return _runLevel; } }

        private int _powerLevel = 0;
        internal int PowerLevel { get { return _powerLevel; } }

        private int _staminaLevel = 0;
        internal int StaminaLevel { get { return _staminaLevel; } }

        private int _swimPoints = 0;
        internal int SwimPoints { get { return _swimPoints; } }

        private int _flyPoints = 0;
        internal int FlyPoints { get { return _flyPoints; } }

        private int _runPoints = 0;
        internal int RunPoints { get { return _runPoints; } }

        private int _powerPoints = 0;
        internal int PowerPoints { get { return _powerPoints; } }

        private int _staminaPoints = 0;
        internal int StaminaPoints { get { return _staminaPoints; } }
        internal void SetSwinPoints(int valuePoints)
        {
            _swimPoints += valuePoints;

            if(SwimPoints > 10)
            {
                _swimLevel++;
                int restPoint = Int16.Parse(Convert.ToString(valuePoints / 10));
                _swimPoints = restPoint;
            }
        }
        internal void SetFlyPoints(int valuePoints)
        {
            _flyPoints += valuePoints;

            if(SwimPoints > 10)
            {
                _flyLevel++;
                int restPoint = Int16.Parse(Convert.ToString(valuePoints / 10));
                _flyPoints = restPoint;
            }
        }
        internal void SetRunPoints(int valuePoints)
        {
            _runPoints += valuePoints;

            if(RunPoints > valuePoints)
            {
                _runLevel++;
                int restPoint = Int16.Parse(Convert.ToString(valuePoints / 10));
                _runPoints = restPoint;
            }
        }
        internal void SetPowerPoints(int valuePoints)
        {
            _powerPoints += valuePoints;
            
            if(PowerPoints > 10)
            {
                _powerLevel++;
                int restPoint = Int16.Parse(Convert.ToString(valuePoints / 10));
                _powerPoints = restPoint;
            }
        }
        internal void SetStaminaPoints(int valuePoints)
        {
            _staminaPoints += valuePoints;

            if(StaminaPoints > 10)
            {
                _staminaLevel++;
                int restPoint = Int16.Parse(Convert.ToString(valuePoints / 10));
                _staminaPoints = restPoint;
                double newMaxLife = _maxLife * 0.5;
                SetMaxLife((int)newMaxLife); 
            }
        }
    }
}
