using Flora.Base;
using Flora.Enumerator;

namespace Flora.Floras
{
    public class NormalFlora : BaseFlora
    {
        public NormalFlora(string name, int life)
        {
            Name = name;
            SetIsAlive(true);
            Life = life;
            SetMaxLife(life);
            SetRandomPersonality();
            SetRandomMood();
            SetRandomColor();
            SetRarity(EnumRarityFlora.Normal);
        }
    }
}
