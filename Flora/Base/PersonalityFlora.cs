using Flora.Enumerator;

namespace Flora.Base
{
    public partial class BaseFlora
    {
        private EnumMoodFlora _mood;
        public EnumMoodFlora Mood { get { return _mood;} }

        private EnumPersonalityFlora _personality = EnumPersonalityFlora.NoPersonality;
        public EnumPersonalityFlora Personality { get { return _personality; } }

        public void SetRandomMood()
        {
            int randomMood = new Random().Next(0, 7);
            _mood = (EnumMoodFlora)randomMood;
        }
        public void SetRandomPersonality()
        {
            int randomPersonality = new Random().Next(0, 10);
            _personality = (EnumPersonalityFlora)randomPersonality;
        }
    }
}
