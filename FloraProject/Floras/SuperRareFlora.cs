using Flora.Base;
using Flora.Enumerator;

namespace Flora.Floras
{
    public class RareFlora : BaseFlora
    {
        public RareFlora(string name, int life)
        {
            Name = name;
            SetIsAlive(true);
            Life = life;
            SetMaxLife(life);
            SetRandomPersonality();
            SetRandomMood();
            SetRandomColor();
            SetRarity(EnumRarityFlora.Rare);
        }
    }
}
