using Flora.Base;
using Flora.Enumerator;

namespace Flora.Floras
{
    public class SuperRareFlora : BaseFlora
    {
        public SuperRareFlora(string name, int life)
        {
            Name = name;
            SetIsAlive(true);
            _life = life;
            _maxLife = life;
            SetRandomPersonality();
            SetRandomMood();
            SetRandomColor();
            _rarity = EnumRarityFlora.SuperRare;
        }
    }
}
