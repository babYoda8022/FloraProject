
namespace Flora.Base
{
    public partial class BaseFlora
    {
        private int _swimLevel = 0;
        public int SwimLevel { get { return _swimLevel; } }

        private int _flyLevel = 0;
        public int FlyLevel { get { return _flyLevel; } }

        private int _runLevel = 0;
        public int RunLevel { get { return _runLevel; } }

        private int _powerLevel = 0;
        public int PowerLevel { get { return _powerLevel; } }

        private int _staminaLevel = 0;
        public int StaminaLevel { get { return _staminaLevel; } }

        private int _swimPoints = 0;
        public int SwimPoints { get { return _swimPoints; } }

        private int _flyPoints = 0;
        public int FlyPoints { get { return _flyPoints; } }

        private int _runPoints = 0;
        public int RunPoints { get { return _runPoints; } }

        private int _powerPoints = 0;
        public int PowerPoints { get { return _powerPoints; } }

        private int _staminaPoints = 0;
        public int StaminaPoints { get { return _staminaPoints; } }
        public void SetSwinPoints(int valuePoints)
        {
            _swimPoints += valuePoints;

            if(SwimPoints > 10)
            {
                _swimLevel++;
                int restPoint = Int16.Parse(Convert.ToString(valuePoints / 10));
                _swimPoints = restPoint;
            }
        }
        public void SetFlyPoints(int valuePoints)
        {
            _flyPoints += valuePoints;

            if(SwimPoints > 10)
            {
                _flyLevel++;
                int restPoint = Int16.Parse(Convert.ToString(valuePoints / 10));
                _flyPoints = restPoint;
            }
        }
        public void SetRunPoints(int valuePoints)
        {
            _runPoints += valuePoints;

            if(RunPoints > valuePoints)
            {
                _runLevel++;
                int restPoint = Int16.Parse(Convert.ToString(valuePoints / 10));
                _runPoints = restPoint;
            }
        }
        public void SetPowerPoints(int valuePoints)
        {
            _powerPoints += valuePoints;
            
            if(PowerPoints > 10)
            {
                _powerLevel++;
                int restPoint = Int16.Parse(Convert.ToString(valuePoints / 10));
                _powerPoints = restPoint;
            }
        }
        public void SetStaminaPoints(int valuePoints)
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
