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
            Life = life;
            SetMaxLife(life);
            SetRandomPersonality();
            SetRandomMood();
            SetRandomColor();
            SetRarity(EnumRarityFlora.SuperRare);
        }
    }
}
